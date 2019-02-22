function solution(input){

    let n = Number(input[0]);
    let result = [];

    for(let i = 1; i <= n; i++)
    {
        let reversedI = Number(i.toString().split("").reverse().join(""));
        if(i === reversedI){
            result.push((i));
        }
    }

    let resultString = result.join(" ");
    console.log(resultString);
}

solution(['200']);