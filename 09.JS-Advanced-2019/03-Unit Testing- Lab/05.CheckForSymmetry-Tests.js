let isSymmetric = require('./05.CheckForSymmetry');

let assert = require('chai').assert;

describe('is symmetric arrays', function () {
    it('return false if input is not array', function () {
        let testData = 'test';

        let result = isSymmetric(testData);

        assert.equal(result, false);
    });

    it('return false if input is not array and non-symmetric', function () {
        let testData = 'test';

        let result = isSymmetric(testData);

        assert.equal(result, false);
    });

    it('shoud rerturn true if the arrays is equals with even digits', function () {
        let arr = [1,2,3,3,2,1];

        let result = isSymmetric(arr);

        assert.equal(result, true);
    });

    it('shoud rerturn false if the arrays is not equals with even digits', function () {
        let arr = [1,2,3,3,2,5];

        let result = isSymmetric(arr);

        assert.equal(result, false);
    });

    it('shoud rerturn true with given odd string input', function () {
        let arr = ['a','b','c','b','a'];

        let result = isSymmetric(arr);

        assert.equal(result, true);
    });

    it('shoud rerturn true with given even string input', function () {
        let arr = ['a','b','c','c','b','a'];

        let result = isSymmetric(arr);

        assert.equal(result, true);
    });

    it('shoud rerturn true with only one string element', function () {
        let arr = ['a'];

        let result = isSymmetric(arr);

        assert.equal(result, true);
    });

    it('shoud rerturn true with two string elements', function () {
        let arr = ['a', 'a'];

        let result = isSymmetric(arr);

        assert.equal(result, true);
    });

    it('returns true for symmetric array of different types of elements', function () {
        let testArr = [3,'pesho',{X: 5},new Date(),{X: 5},'pesho',3];

        let result = isSymmetric(testArr);

        assert(result, true);
    });
})

