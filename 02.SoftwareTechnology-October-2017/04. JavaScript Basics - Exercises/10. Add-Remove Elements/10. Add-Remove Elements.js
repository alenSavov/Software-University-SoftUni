function solve(input){

    let arr = [];
    for(let line of input){
        let[command, num] = line.split(" ");
        num = Number(num);
        switch(command){
            case "add":
                arr.push(num);
            break;
            case "remove":
                arr.splice(num, 1);
                break;
        }
    }
    arr.map(e => console.log(e));
}

solve(['add 3', 'add 5', 'remove 2', 'remove 0', 'add 7']);