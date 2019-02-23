function solve(input){
    let initialNum = 0;
    let resultArr = [];

    for (let i = 0; i < input.length; i++) {
        initialNum++;
        let command = input[i];

        if (command === 'add') {
            resultArr.push(initialNum);

        } else if (command === 'remove'){
            resultArr.pop();
        }
    }
    if (resultArr.length === 0) {
        resultArr.push('Empty');
    }
    console.log(resultArr.join('\n'));
}

solve(['remove',
    'remove',
    'remove']



);