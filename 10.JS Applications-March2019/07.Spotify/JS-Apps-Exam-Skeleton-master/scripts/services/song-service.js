const songService = (() => {

    function createSong(data) {
       return kinvey.post('appdata', 'songs', 'kenvey', data);
    }

    function getAllSongs() {
        return kinvey.get('appdata', 'songs', 'kenvey');
    }

    function getMySongs() {
        return kinvey.get('appdata', 'songs', 'kenvey');
    }

    function listenSong(id, song) {
        return kinvey.update('appdata', `songs/${id}`, 'kinvey', song);
    }

    function getASong(id) {
        return kinvey.get('appdata', `songs/${id}`, 'kenvey');
    }

    function likeSong(id, song) {
        return kinvey.update('appdata', `songs/${id}`, 'kinvey', song);
    }

    function removeSong(id) {
        return kinvey.remove('appdata', `songs/${id}`, 'kinvey');
    }

    return {
        createSong,
        getAllSongs,
        getMySongs,
        listenSong,
        getASong,
        likeSong,
        removeSong
    }
})();