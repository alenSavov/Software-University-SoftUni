function solve(arr){
    let currentBiggestNum = arr[0];
    let resultArr = [];

    for (let i = 0; i < arr.length; i++) {
        let currentNum = arr[i];

       if (currentNum >= currentBiggestNum) {
           resultArr.push(currentNum);
           currentBiggestNum = currentNum;
       }
    }

    console.log(resultArr.join('\n'));
}

solve([20,
    3,
    2,
    15,
    6,
    1]




);