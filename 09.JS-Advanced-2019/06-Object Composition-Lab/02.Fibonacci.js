function fibonacci() {
    let x = 1;
    let y = 1;
    let z = 0;
    return function getNext() {
        [z, x, y] = [x, y, x + y];
        return z;
    };
}

let fun = fibonacci();

for (let i = 0; i < 10; i++) {
    console.log(fun());
}