let sum = require('./sumOfNumbers');

let assert = require('chai').assert;
let expect = require('chai').expect;

 describe('Sum of numbers', function () {
     it('shoud be a function', function () {
         expect(typeof sum).equal('function');
     });

     it('shoud return correct sum', function () {
         let arr = [1,1,1,1,1];

         let expected = sum(arr);

         assert.equal(expected, 5);
     });

     it('should return correct sum with string input', () => {
         let arr = [1,1,1, '1'];

         let expected = sum(arr);

         assert.equal(expected, 4);
     });
 })