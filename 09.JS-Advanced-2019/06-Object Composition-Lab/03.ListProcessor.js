function solve(input) {
    let collection = [];

    Array.from(input).forEach((line) => {
        let inputTokens = line.split(' ');
        let command = inputTokens[0];
        let string = inputTokens[1];

        if (command === 'add') {
            collection.push(string);
        }

        if (command === 'remove') {
            let filteredArr = collection.filter(el => el !== string);
            collection = filteredArr;
        }

        if (command === 'print') {
            console.log(collection.join(','));
        }
    })
}


solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);