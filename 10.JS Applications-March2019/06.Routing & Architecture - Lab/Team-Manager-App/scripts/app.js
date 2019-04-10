$(() => {
    const app = Sammy('#main', function () {
        this.use("Handlebars", "hbs");

        // Index
        this.get("#/home", function() {
            this.render("../templates/home/home.hbs", {
                 loggedIn: sessionStorage.authtoken !== undefined,
                 hasTeam: sessionStorage.teamId !== undefined,
                 username: sessionStorage.username  }, null, {
                    header: "../templates/common/header.hbs", 
                    footer: "../templates/common/footer.hbs"
                }).then(function(result){
                    this.swap(result);
                });                
        });

        // Register
        this.get("#/register", function() {
            this.render("../templates/register/registerPage.hbs", {
                username: sessionStorage.username 
            }, null, {
                    header: "../templates/common/header.hbs", 
                    footer: "../templates/common/footer.hbs",
                    registerForm: "../templates/register/registerForm.hbs"
                }).then(function(result){
                    this.swap(result);
                });
        });

        this.post("#/register", function(context){
            let username = context.params.username;
            let password = context.params.password;
            let repeatPassword = context.params.repeatPassword;

            auth.register(username, password, repeatPassword).then((userInfo) =>{
                auth.saveSession(userInfo);
                this.redirect("#/home");
            });
        });

        // Login
        this.get("#/login", function() {
            this.render("../templates/login/loginPage.hbs", {
                username: sessionStorage.username 
            }, null, {
                    header: "../templates/common/header.hbs", 
                    footer: "../templates/common/footer.hbs",
                    loginForm: "../templates/login/loginForm.hbs"
                }).then(function(result){
                    this.swap(result);
                });
        });

        this.post("#/login", function(context){
            let username = context.params.username;
            let password = context.params.password;

            auth.login(username, password).then((userInfo) =>{
                auth.saveSession(userInfo);
                this.redirect("#/home");
            });
        });

        // About
        this.get("#/about", function() {
            this.render("../templates/about/about.hbs", {
                loggedIn: sessionStorage.authtoken !== undefined,
                hasTeam: sessionStorage.teamId !== undefined,
                username: sessionStorage.username 
            }, null, {
                    header: "../templates/common/header.hbs", 
                    footer: "../templates/common/footer.hbs"
                }).then(function(result){
                    this.swap(result);
                });
        });

        // Logout
        this.get("#/logout", function() {
            auth.logout();
            sessionStorage.removeItem("authtoken");
            sessionStorage.removeItem("username");
            sessionStorage.removeItem("userId");
            sessionStorage.removeItem("teamId");
            this.redirect("#/home");
        });

        // Get teams catalog
        this.get("#/catalog", function() {
            let teams = [];
            requester.get("appdata", "teams", "kinvey").then((data) => {
                teams = data;
                this.render(
                    "../templates/catalog/teamCatalog.hbs", {
                        loggedIn: sessionStorage.authtoken !== undefined,
                        hasTeam: sessionStorage.teamId !== undefined,
                        hasNoTeam: sessionStorage.teamId,
                        teams,
                        username: sessionStorage.username  },
                    null, {
                        team: "../templates/catalog/team.hbs",
                        header: "../templates/common/header.hbs", 
                        footer: "../templates/common/footer.hbs"
                }).then(function(result){
                    this.swap(result);
                });
            });
        })

        // Create team
        this.get("#/create", function() {
            this.render("../templates/create/createPage.hbs", {
                loggedIn: sessionStorage.authtoken !== undefined,
                hasTeam: sessionStorage.teamId !== undefined,
                username: sessionStorage.username 
            }, null, {
                    header: "../templates/common/header.hbs", 
                    footer: "../templates/common/footer.hbs",
                    createForm: "../templates/create/createForm.hbs",
                }).then(function(result){
                    this.swap(result);
                });
        });

        this.post("#/create", function(context) {
            let name = context.params.name;
            let comment = context.params.comment;

            requester.post("appdata", "teams", "kinvey", { name, comment })
                .then((team) => {
                    console.log(team);
                    this.redirect("#/join/" + team._id);
                });
        });

        // Team details
        this.get("#/catalog/:id", function(context) {
            requester.get("appdata", "teams/" + context.params.id.substr(1), "kinvey")
                .then((team) => {
                    requester.get("user", "", "kinvey")
                        .then((users) => {
                            let teamMembers = Array.from(users).filter((u) => u.teamId === team._id);
                            this.render("../templates/catalog/details.hbs", {
                                    loggedIn: sessionStorage.authtoken !== undefined,
                                    hasTeam: sessionStorage.teamId !== undefined,
                                    username: sessionStorage.username,
                                    comment: team.comment,
                                    name: team.name,
                                    teamId: team._id,
                                    members: teamMembers,
                                    isOnTeam: sessionStorage.teamId === team._id
                                }, null, {
                                        header: "../templates/common/header.hbs", 
                                        footer: "../templates/common/footer.hbs",
                                        teamControls: "../templates/catalog/teamControls.hbs",
                                        teamMember: "../templates/catalog/teamMember.hbs"
                                    }).then(function(result){
                                        this.swap(result);
                                    });
                                });
                });
        });

        // Join team
        this.get("#/join/:teamId", function(context) {
            let teamId = context.params.teamId;

            let userId = sessionStorage.userId;
            let username = sessionStorage.username;
            sessionStorage.teamId = teamId.substr(1);

            requester.update("user", userId, "kinvey", { _id: userId, username, teamId: teamId.substr(1) });

            this.redirect("#/home");    
        });

        // Leave team TODO: *FINISH
        this.get("#/leave", function(context) {
            requester.get("user", sessionStorage.userId, "kinvey")
                .then((user) => {
                    if(sessionStorage.teamId){
                        sessionStorage.teamId = undefined;
                        requester.update("user", sessionStorage.userId, "kinvey", { username: user.username, teamId: "" });
                    }
                })

            this.redirect("#/home");
        });
    });

    app.run();
});