function solve(nums){
    let x = Number(nums[0]);
    let y = Number(nums[1]);
    let z = Number(nums[2]);

    let countNegativeNumbers = 0;

    for(let i = 0;i < nums.length;i++){
        if(nums[i] < 0){
            countNegativeNumbers++;
        }
    }

    if(countNegativeNumbers % 2 === 1){
        console.log("Negative");
    }
    else{
        console.log("Positive");
    }
}

solve(["2", "3", "-1"]);