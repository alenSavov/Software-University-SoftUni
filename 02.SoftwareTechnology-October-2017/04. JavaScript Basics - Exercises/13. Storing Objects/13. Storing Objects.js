function solve(input){
    let arrObj = [];
    for(let line of input){
        let lineArr = line.split(" -> ");
        let obj = {
            Name: lineArr[0],
            Age: lineArr[1],
            Grade: Number(lineArr[2])
        };
        arrObj.push(obj);
    }
    for(let object of arrObj){
        console.log(`Name: ${object.Name}`);
        console.log(`Age: ${object.Age}`);
        console.log(`Grade: ${object.Grade.toFixed(2)}`);

    }

}
solve(['Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57', 'Toni -> 13 -> 4.90']);