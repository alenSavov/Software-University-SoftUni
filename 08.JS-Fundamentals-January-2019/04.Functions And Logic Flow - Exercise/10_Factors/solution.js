function solve() {
    let number = Number(document.getElementById('num').value);

    let result = document.getElementById('result');
    result.innerHTML = calculate(number);

    function calculate(num) {

        var half = Math.floor(num / 2), // Ensures a whole number <= num.
            str = '1', // 1 will be a part of every solution.
            i, j;

        // Determine our increment value for the loop and starting point.
        num % 2 === 0 ? (i = 2, j = 1) : (i = 3, j = 2);

        for (i; i <= half; i += j) {
            num % i === 0 ? str += ' ' + i : false;
        }

        str += ' ' + num; // Always include the original number.
        return str;
    }
}