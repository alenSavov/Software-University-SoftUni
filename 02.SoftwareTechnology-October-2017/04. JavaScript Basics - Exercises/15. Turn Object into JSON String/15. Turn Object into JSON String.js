function solve(input) {
    let obj = {};
    input.forEach(str => {
        let [key, value] = str.split(" -> ");
        value = isNaN(value) ? value : Number(value);
        obj[key] = value;
    });

    console.log(JSON.stringify(obj));
}
solve(['name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995',
    'town -> Sofia']);