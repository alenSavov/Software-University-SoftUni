function solution(input){
    let inputArr = input.map(Number);
    let numberSorted = inputArr.sort((a, b) => b - a);
    let count = Math.min(3 , numberSorted.length);

    for(let i = 0;i < count; i++){
        console.log(numberSorted[i]);
    }

}

solution(["10", "30", "15" ,"20" ,"50" ,"5"]);