function subsum(arr, startIndex, endIndex) {

    if(!Array.isArray(arr)){
        return NaN;
    }

    if(arr.length === 0){
        return 0;
    }

    if(startIndex < 0){
        startIndex = 0;
    }

    if(endIndex >= arr.length){
        endIndex = arr.length - 1;
    }

    if(arr.some(e => isNaN(e))){
        return NaN;
    }

    return arr
        .slice(startIndex, endIndex + 1)
        .map(Number)
        .reduce((a, b) => a + b);
}

module.exports = subsum;

console.log(subsum([10, 20, 30, 40, 50, 60], 3, 300));

console.log(subsum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1));

console.log(subsum([10, 'twenty', 30, 40], 0, 2));