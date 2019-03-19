let add = (function () {
    let sum = 0;
    
    function add(number) {
        sum += number;
        return add;
    }

    return add;
})();

add(1)(2)(3)