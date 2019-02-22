function solve(input) {
    let arr = new Map();
    let key;
    let value;
    for (let line of input){
        [key, value] = line.split(' ');
        if (value !== undefined){
            if (arr[key] === undefined){
                arr[key] = "";
            }
            arr[key] = value;
        }
    }
    return arr[key] === undefined ?
        console.log("None") :
        console.log(arr[key]);
}

solve(['key value',
    'key eulav',
    'test tset',
    'key']);