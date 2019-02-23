function leapYear() {

    let btn = document.querySelector('#exercise button')
        .addEventListener('click', checkTheYear);


    let h2 = document.getElementsByTagName('h2');
    let yearElement = document.getElementById('year');

    let test = document.querySelectorAll('#exercice h2');

    function checkTheYear(){
        let year = document.querySelector('#exercise input');
        let isLeap = isLeapYear(year.value);

        let h2 = document.querySelector('#year h2');

        if (isLeap) {
            h2.textContent = 'Leap Year';
        } else {
            h2.textContent = 'Not Leap Year';
        }

        let divContainer = document.querySelector('#year div');
        divContainer.textContent = year.value;

        year.value = '';
    }


    function isLeapYear(year) {
        return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
    }
}