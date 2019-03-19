let isOddOrEven = require('./02.EvenOrOdd');

let assert = require('chai').assert;

describe('is even or odd lenght', function () {
    it('should return undefined if input parameter is not a string', function () {
        let testData = 3;

        let result = isOddOrEven(testData.length);

        assert.equal(result, undefined);
    });

    it('should return correct value for odd length', function () {
        let testData = 'abc';

        let result = isOddOrEven(testData);

        assert.equal(result, 'odd');
    });

    it('should return correct value for even length', function () {
        let testData = 'abcd';

        let result = isOddOrEven(testData);

        assert.equal(result, 'even');
    });
})