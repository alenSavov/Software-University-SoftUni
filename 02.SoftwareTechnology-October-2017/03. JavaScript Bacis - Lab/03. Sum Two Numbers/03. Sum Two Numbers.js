function solution(input){
    let inputArr = input.map(Number);
    let sum = 0;

    inputArr.forEach(e => sum += e);
    console.log(sum);
}

solution(['10', '20']);