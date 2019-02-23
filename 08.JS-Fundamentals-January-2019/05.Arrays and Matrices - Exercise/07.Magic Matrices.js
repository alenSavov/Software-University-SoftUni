function solve(input) {
    let sumColumn = 0;
    let sumRow = 0;

    for (let i = 0; i < input.length; i++) {
        sumRow += input[i][1];
        sumColumn += input[i][2];
    }

    if (sumRow === sumColumn) {
        console.log('true');
    } else {
        console.log('false');
    }
}

solve([[11, 32, 45],
    [21, 0, 1],
    [21, 1, 1]]

);