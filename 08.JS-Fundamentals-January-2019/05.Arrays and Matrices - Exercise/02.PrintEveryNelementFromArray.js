function solve(input) {
    let stepNum = Number(input[input.length - 1]);
    let arr = [];

    for (let i = 0; i < input.length - 1; i++) {
        arr.push(input[i]);
    }
    for (let i = 0; i < arr.length; i+= stepNum) {
        console.log(arr[i]);
    }
}

solve(['dsa',
    'asd',
    'test',
    'tset',
    '2']
);

