const SoftUniFy = require('./app');
const assert = require('chai').assert;

describe("Test class functionality", function() {

    describe('Download songs', function () {
        it('Add one song ', function () {
            let expected = new SoftUniFy();

            expected = expected.downloadSong("pesho","trepni","trepni trepni trepni");

            assert.deepEqual(expected, {
                "allSongs": {
                    "pesho": {
                        "rate": 0,
                        "songs": ["trepni - trepni trepni trepni"],
                        "votes": 0
                    }
                }
            });
        });

        it('Add two songs', function () {
            let expected = new SoftUniFy();

            expected = expected.downloadSong("pesho","trepni","trepni trepni trepni");
            expected = expected.downloadSong("gosho","krisko","losh ili dobur dvete mi lica obichash");

            assert.deepEqual(expected, {
                "allSongs": {
                    "pesho": {
                        "rate": 0,
                        "songs": ["trepni - trepni trepni trepni"],
                        "votes": 0
                    },
                    "gosho": {
                        "rate": 0,
                        "songs": ["krisko - losh ili dobur dvete mi lica obichash"],
                        "votes": 0
                    }
                }
            });
        });
    })

    describe('Play song', function () {
        it('play existing song ', function () {
            let expected = new SoftUniFy();

            expected = expected.downloadSong("pesho","trepni","trepni trepni trepni");
            expected = expected.playSong('trepni');

            assert.equal(expected, "pesho:\ntrepni - trepni trepni trepni\n");
        });

        it('if no existing song should return string ', function () {
            let expected = new SoftUniFy();

            expected = expected.playSong('test');

            assert.equal(expected, 'You have not downloaded a test song yet. Use SoftUniFy\'s function downloadSong() to change that!')
        });
    })

    describe('songsList', function () {
        it('gets all already downloaded songs', function () {
            let expected = new SoftUniFy();

            expected = expected.downloadSong("pesho","trepni","trepni trepni trepni");
            expected = expected.downloadSong("gosho","test","trepni trepni trepni");

            expected = expected.songsList;

            assert.equal(expected, 'trepni - trepni trepni trepni\n' +
                'test - trepni trepni trepni');
        });
    })

});