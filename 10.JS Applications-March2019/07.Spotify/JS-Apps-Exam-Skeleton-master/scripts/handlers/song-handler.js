handlers.getallSongs = async function (ctx) {

    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');
    try {
        let songs = await songService.getAllSongs();
        let userId = sessionStorage.getItem('id');
        songs.forEach((song) => song.isCreator = song._acl.creator === userId);
        ctx.songs = songs;

        ctx.loadPartials({
            header: 'templates/common/header.hbs',
            footer: 'templates/common/footer.hbs',
            song: 'templates/song/song.hbs'
        }).then(function () {
            this.partial('templates/song/allSongs.hbs');
        }).catch(function (err) {
            console.log(err);
        });
    } catch (e) {
        console.log(e)
    }
}

handlers.getCreateSong = function (ctx) {
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
        header: 'templates/common/header.hbs',
        footer: 'templates/common/footer.hbs'
    }).then(function () {
        this.partial('templates/song/createSong.hbs');
    }).catch(function (err) {
        console.log(err);
    });
}

handlers.createSong = function (ctx) {
    let data = {...ctx.params, likeCounter: 0, listenCounter: 0};

    if (data.title.length < 6) {
        notify.showError('The title should be at least 6 characters long!')
    } else if (data.artist < 3) {
        notify.showError('The artist should be at least 3 characters long!')
    } else if (!data.imageURL.startsWith('https://')) {
        notify.showError('The image should start with "http://" or "https://"')
    } else {
        songService.createSong(data)
            .then(function (res) {
                notifications.showSuccess('Successfully created song');
                ctx.redirect('#/mySongs');
            }).catch(function (err) {
            console.log(err);
        });
    }
};

handlers.getMySongs = async function (ctx) {
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');

    songService.getMySongs()
        .then(function (res) {
            let userId = sessionStorage.getItem('id');
            let songs = res;

            let mySongs = songs.filter(s => s._acl.creator === userId);
            mySongs.map(s => s.isCreator = userId);
            ctx.mySongs = mySongs;

            ctx.loadPartials({
                header: 'templates/common/header.hbs',
                footer: 'templates/common/footer.hbs',
                song: 'templates/song/song.hbs'
            })
                .then(function () {
                    this.partial('templates/song/mySongs.hbs');
                })
                .catch(function (error) {
                    notify.handleError(error);
                })
        });
}


handlers.listenSong = function (ctx) {
    let id = ctx.params.id;

    songService.getASong(id)
        .then(function (res) {
            let song = res;

            let newListen = Number(song.listenCounter) + 1;
            song.listenCounter = newListen;

            songService.listenSong(id, song)
                .then(function () {
                    notify.showInfo(`You just listened ${song.title}`);
                    ctx.redirect('#/allSongs');
                })
                .catch(function (error) {
                    notify.showError(error);
                });
        });
};

handlers.likeSong = function (ctx) {
    let id = ctx.params.id;

    songService.getASong(id)
        .then(function (res) {
            let song = res;

            let newLike = Number(song.likeCounter) + 1;
            song.likeCounter = newLike;

            songService.likeSong(id, song)
                .then(function () {
                    notify.showInfo(`Liked!`);
                    ctx.redirect('#/allSongs');
                })
                .catch(function (error) {
                    notify.showError(error);
                });
        });
};

handlers.removeSong = function (ctx) {
    let id = ctx.params.id;

    songService.getASong(id)
        .then(function (res) {
            let song = res;

            songService.removeSong(id)
                .then(function () {
                    notify.showInfo(`Song removed successfully!`);
                    ctx.redirect('#/allSongs');
                })
                .catch(function (error) {
                    notify.showError(error);
                });
        });
}

