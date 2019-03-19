let addTo = function (passed) {

    let add = function (inner) {
        return passed + inner;
    };

    return add;
};

console.dir(addTo(3))