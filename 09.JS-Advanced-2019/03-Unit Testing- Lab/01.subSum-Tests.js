let subsum = require('./01.subSum');

let assert = require('chai').assert;

describe('sum values', function () {
    it('should return false if first parameter is not array', function () {
        let tesData = 'test';
        let startIndex = 0;
        let endIndex = 3;

        let result = subsum(tesData, startIndex, endIndex);

        assert.equal(result.toString(), 'NaN');
    });

    it('should return correct sum with startIndex less than zero', function () {
        let arr = ([1.1, 2.2, 3.3, 4.4, 5.5]);
        let startIndex = -3;
        let endIndex = 1;

        let result = subsum(arr, startIndex, endIndex);

        assert.equal(result, 3.3000000000000003);
    });

    it('should return correct sum with positive digits', function () {
        let arr = [10, 20, 30, 40, 50, 60];
        let startIndex = 3;
        let endIndex = 300;

        let result = subsum(arr, startIndex, endIndex);

        assert.equal(result, 150);
    });

    it('should return correct sum with negative digits', function () {
        let arr = [-10, -20, -30, -40, -50, -60];
        let startIndex = 3;
        let endIndex = 300;

        let result = subsum(arr, startIndex, endIndex);

        assert.equal(result, -150);
    });

    it('should return correct sum with endIndex bigger than the length from the array', function () {
        let arr = [10, 20, 30, 40, 50, 60];
        let startIndex = 3;
        let endIndex = 300;

        let result = subsum(arr, startIndex, endIndex);

        assert.equal(result, 150);
    });
})