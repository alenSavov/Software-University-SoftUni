function solve(input) {
    let length = Number(input[0]);
    let arr = new Array(length).fill(0);
    for (let i = 1; i < input.length; i++){
        let[index, value] = input[i].split(" - ")
            .map(Number);
        arr[index] = value;
    }
    arr.map(e => console.log(e));
}
solve(['5',
    '0 - 3',
    '3 - -1',
    '4 - 2']);