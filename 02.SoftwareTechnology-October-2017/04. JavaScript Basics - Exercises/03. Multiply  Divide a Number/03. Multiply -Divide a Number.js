function solve(nums){
    let firstInteger = Number(nums[0]);
    let secondInteger = Number(nums[1]);
    let sum = 0;

    if(secondInteger >= firstInteger){
        sum = secondInteger * firstInteger;
        return sum;
    }
    else{
        sum = firstInteger / secondInteger;
        return sum;
    }
}

console.log(solve(["2", "3"]));