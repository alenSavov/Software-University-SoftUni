const handlers = {}

$(() => {
  const app = Sammy('#root', function () {
    this.use('Handlebars', 'hbs');
    // home page routes
    this.get('/index.html', handlers.getHome);
    this.get('/', handlers.getHome);
    this.get('#/home', handlers.getHome);

    // user routes
    this.get('#/register', handlers.getRegister);
    this.get('#/login', handlers.getLogin);

    this.post('#/register', handlers.registerUser);
    this.post('#/login', handlers.loginUser);
    this.get('#/logout', handlers.logoutUser);

    // ADD YOUR ROUTES HERE
    this.get('#/getCreateSong', handlers.getCreateSong);
    this.post('#/createSong', handlers.createSong);

    this.get('#/allSongs', handlers.getallSongs);

    this.get('#/mySongs', handlers.getMySongs);
    this.get('#/likeSong/:id', handlers.likeSong);
    this.get('#/listenSong/:id', handlers.listenSong);

    this.get('#/likeSong/:id', handlers.likeSong);
    this.get('#/removeSong/:id', handlers.removeSong);

  });
  app.run();
});