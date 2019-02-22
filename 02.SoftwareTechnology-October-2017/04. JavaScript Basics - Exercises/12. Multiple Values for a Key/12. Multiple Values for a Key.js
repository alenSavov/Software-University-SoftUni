function solve(input){
    let arr = new Map();
    let key;
    let value;
    for(let line of input){
        [key, value] = line.split(' ');
        if(value !== undefined){
            if(!(key in arr)){
                arr[key] = [];
            }
            arr[key].push(value);
        }
    }
    if(key in arr){
        arr[key].map((e) => console.log(e));
    }
    else{
        console.log("None");
    }
}

solve(['3 test',
'4 test1',
'4 test2',
'4 test3',
'4 test4',
'4 test5',
'4']);