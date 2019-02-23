// 01.I like JavaScript!

let asd = ['1', '2'];


let input = "Gosho";

function greeting(input) {
    return `Hello ${input}, do you like JavaScript?`
}

console.log(greeting(input));

// 02.Even Numbers 1 to N 

function printEventNumber(input) {
    for (i = 1; i <= input; i++) {

        if (i % 2 == 0) {
            console.log(i)
        }
    }
}

console.log(printEventNumber(5))

// 03.	Fruit 

function calculatePrice(fruit, weight, pricePerKilogram) {
    let price = weight * (pricePerKilogram / 1000);
    let weightInKilograms = weight / 1000;

    return `I need ${price.toFixed(2)} leva to buy ${weightInKilograms.toFixed(2)} kilograms ${fruit}.`;
}

console.log(calculatePrice("orange", 2500, 1.80));

// 04.	Fitness Rates 
function calculatePrice(dayOfWeek, service, visitHour) {
    if (dayOfWeek === 'Monday' || dayOfWeek === 'Tuesday' || dayOfWeek === 'Wednesday' || dayOfWeek === 'Thursday' || dayOfWeek === 'Friday') {
        if (service === 'Fitness') {
            if (visitHour >= 8 && visitHour <= 15) {
                console.log(5);
            } else if (visitHour > 15 && visitHour <= 22) {
                console.log(7.5);
            }
        } else if (service === 'Sauna') {
            if (visitHour >= 8 && visitHour <= 15) {
                console.log(4);
            } else if (visitHour > 15 && visitHour <= 22) {
                console.log(6.5);
            }
        } else if (service === 'Instructor') {
            if (visitHour >= 8 && visitHour <= 15) {
                console.log(10);
            } else if (visitHour > 15 && visitHour <= 22) {
                console.log(12.5);
            }
        }
    } else if (dayOfWeek === 'Saturday' || dayOfWeek === 'Sunday') {
        if (service === 'Fitness') {
            console.log(8);
        } else if (service === 'Sauna') {
            console.log(7);
        } else if (service === 'Instructor') {
            console.log(15);
        }
    }
}

calculatePrice('Sunday', 'Fitness', 22.00);

// 06.	Same Numbers

function checkNumbers(number) {
    let value = number,
        sum = value
            .toString()
            .split('')
            .map(Number)
            .reduce(function (a, b) {
                return a + b;
            }, 0);

    let isEqual = true;

    let numberArr = number.toString().split('').map(Number);

    for (let i = 0; i < numberArr.length; i++) {
        if (numberArr[i] != numberArr[0]) {
            isEqual = false;
        }
    }

    console.log((isEqual));
    console.log(sum);

}

console.log(checkNumbers(4444));

// 07.	Time to Walk

function calculatesTimeToSchool(steps, footPrintLength, speedInKmForHour) {
    let distanceInMeters = steps * footPrintLength;

    let speedForMeterInSecond = speedInKmForHour / 3.6;

    let timeSecond = Math.round(distanceInMeters / speedForMeterInSecond);

    let rest = Math.floor(distanceInMeters / 500);
    timeSecond += rest * 60;

    let seconds = timeSecond % 60;
    let minutes = ((timeSecond - seconds) / 60) % 60;
    let hour = Math.floor(((timeSecond - seconds) / 3600));

    formatTheOutput(hour, minutes, seconds);

    function formatTheOutput(hour, minutes, seconds) {

        if (hour < 10) {
            hour = '0' + hour;
        }
        if (minutes < 10) {
            minutes = '0' + minutes;
        }
        if (seconds < 10) {
            seconds = '0' + seconds;
        }

        console.log(`${hour}:${minutes}:${seconds}`);
    }
}

console.log(calculatesTimeToSchool(4000, 0.60, 5));

// 05.	Greatest Common Divisor – GCD

function gcd_rec(a, b) {
    if (b) {
        return gcd_rec(b, a % b);
    } else {
        return Math.abs(a);
    }
}

console.log(gcd_rec(2154, 458));

// 08.	Flight Timetable

function solve(tokens) {
    return `${tokens[0]}: Destination - ${tokens[1]}, Flight - ${tokens[3]}, Time - ${tokens[2]}, Gate - ${tokens[4]}`;
}

console.log(solve(['Departures', 'London', '22:45', 'BR117', '42']));
console.log(solve(['Arrivals', 'Paris', '02:22', 'VD17', '3']));

// 09.	Calorie Object

function calories(arr) {
    let obj = {};

    for (let i = 0; i < arr.length - 1; i += 2) {
        obj[arr[i]] = Number(arr[i + 1]);
    }

    console.log(obj);
}

calories(['Yoghurt', 48, 'Rise', 138, 'Apple', 52]);

// 10. Coffee Machine

function solve(arr) {
    let totalSum = 0;

    for (let i = 0; i < arr.length; i++) {
        let order = arr[i].split(", ");

        let drinkPrice = 0;
        let coin = Number(order[0]);
        let drinkType = order[1];
        let sugar = 0;
        let neededMoney = 0;

        if(drinkType === 'coffee'){
            let caffeineOrDecaf = order[2];

            if(caffeineOrDecaf === 'caffeine'){
                drinkPrice = 0.8;
            } else{
                drinkPrice = 0.9;
            }

            if(order.length === 5){
                sugar = Number(order[4]);
                neededMoney = drinkPrice + Number((drinkPrice * 0.1).toFixed(1));
                if(sugar !== 0){
                    neededMoney += 0.1;
                }
            } else {
                sugar = Number(order[3]);
                neededMoney = drinkPrice;

                if(sugar !== 0){
                    neededMoney += 0.1;
                }
            }
        } else {
            drinkPrice = 0.8;

            if(order.length === 4){
                sugar = Number(order[3]);

                neededMoney = drinkPrice + Number((drinkPrice * 0.1).toFixed(1));

                if(sugar !== 0){
                    neededMoney += 0.1;
                }
            } else {
                sugar = Number(order[2]);

                neededMoney = drinkPrice;

                if(sugar !== 0){
                    neededMoney += 0.1;
                }
            }
        }

        if(coin >= neededMoney){
            totalSum += neededMoney;
            console.log(`You ordered ${drinkType}. Price: ${neededMoney.toFixed(2)}$ Change: ${(coin - neededMoney).toFixed(2)}$`);
        } else {
            console.log(`Not enough money for ${drinkType}. Need ${(neededMoney - coin).toFixed(2)}$ more.`);
        }
    }

    console.log(`Income Report: ${totalSum.toFixed(2)}$`)
}

solve(['1.00, coffee, caffeine, milk, 4', '0.40, tea, milk, 2', '1.00, coffee, decaf, 0']);