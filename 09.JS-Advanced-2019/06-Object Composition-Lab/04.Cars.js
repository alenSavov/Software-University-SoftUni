function solve(input) {
    let obj = {};

    Array.from(input).forEach((line) => {
        let inputTokens = line.split(' ');
        let command = inputTokens[0];

        if (command === 'create') {
            if (inputTokens.length === 2) {
                obj[inputTokens[1]] = '';
            } else if (inputTokens.length === 4) {
                obj[inputTokens[3]][inputTokens[1]] = '';
            }
        }

        if (command === 'set') {
            obj[inputTokens[1]][inputTokens[2]] = inputTokens[3];
        }

        if (command === 'print') {
            console.log(obj[inputTokens[1]]);
        }
    })
}

solve(['create c1',
    'create c2 inherit c1',
    'set c1 color red',
    'set c2 model new',
    'print c1',
    'print c2']
)