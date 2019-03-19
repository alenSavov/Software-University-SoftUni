let lookupChar = require('./03.CharLookup');

let assert = require('chai').assert;

describe('lookupchar', function () {
    it('should return indefined with with first parameter different from string', function () {
        let testData = [];

        let result = lookupChar(testData, 1);

        assert.equal(result, undefined);
    });

    it('should return indefined with with second parameter different from integer', function () {
        let testData = 'abc';

        let result = lookupChar(testData, '1');

        assert.equal(result, undefined);
    });

    it('should return Incorrect index when the value of the index is bigger than the string length', function () {
        let testData = 'abcd';

        let result = lookupChar(testData, 4);

        assert.equal(result, 'Incorrect index');
    });

    it('should return Incorrect index when the value of the index is negative', function () {
        let testData = 'abcd';

        let result = lookupChar(testData, -4);

        assert.equal(result, 'Incorrect index');
    });

    it('should return correct character', function () {
        let testData = 'abcd';

        let result = lookupChar(testData, 1);

        assert.equal(result, 'b');
    });

    it('should return Incorrect index with index equal to string length', function () {
        let testData = 'abcd';

        let result = lookupChar(testData, 3);

        assert.equal(result, 'd');
    });

    it('should return empty string', function () {
        let testData = ' ';

        let result = lookupChar(testData, 0);

        assert.equal(result, ' ');
    });

    it('should return undefined if index is a floating point number', function () {
        let testData = 'abcd';

        let result = lookupChar(testData, 1.1);

        assert.equal(result, undefined);
    });
})