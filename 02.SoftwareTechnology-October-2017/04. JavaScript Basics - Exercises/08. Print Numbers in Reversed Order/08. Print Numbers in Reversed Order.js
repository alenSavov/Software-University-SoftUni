function printReversed(nums){
    for(let num of nums.map(Number).reverse()){
        console.log(num);
    }
}

console.log(printReversed(["10","15","20"]));