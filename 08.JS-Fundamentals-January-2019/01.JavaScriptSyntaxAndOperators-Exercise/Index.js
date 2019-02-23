// 01.I like JavaScript!

let input = "Gosho";

function greeting(input){
    return `Hello ${input}, do you like JavaScript?`
}

console.log(greeting(input));

// 02.Even Numbers 1 to N

function printEventNumber(input){
    for(i =1; i <= input; i++){

        if (i %2 == 0) {
            console.log(i)
        }
    }
}

console.log(printEventNumber(5))

// 03.	Fruit

function calculatePrice(fruit, weight, pricePerKilogram){
    let price = weight * (pricePerKilogram / 1000);
    let weightInKilograms = weight / 1000;

    return `I need ${price.toFixed(2)} leva to buy ${weightInKilograms.toFixed(2)} kilograms ${fruit}.`;
}

console.log(calculatePrice("orange", 2500, 1.80));

// 04.	Fitness Rates

function calculatePriceForGym(day, service, hour){
    let dayOfWeeks = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
    let services = ["Fitness", "Sauna", "Instructor"];

    let price = 0;

    // Fitness
    if (services[0] == service) {
        let priceBefore15 = 5.00;
        let priceAfter15 = 7.50;
        let priceForWeekends = 8.00;

        if(day == dayOfWeeks[0]){
        }else if(day == dayOfWeeks[1]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[2]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[3]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[4]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[5]){
            price = priceForWeekends;
        }else if(day == dayOfWeeks[6]){
            price = priceForWeekends;
        }
    }

    // Sauna
    if (services[1] == service) {
        let priceBefore15 = 4.00;
        let priceAfter15 = 6.50;
        let priceForWeekends = 7.00;

        if(day == dayOfWeeks[0]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[1]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[2]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[3]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[4]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[5]){
            price = priceForWeekends;
        }else if(day == dayOfWeeks[6]){
            price = priceForWeekends;
        }
    }

    // Instructor
    if (services[2] == service) {
        let priceBefore15 = 10.00;
        let priceAfter15 = 12.50;
        let priceForWeekends = 15.00;

        if(day == dayOfWeeks[0]){
        }else if(day == dayOfWeeks[1]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[2]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[3]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[4]){
            if(+hour < +15.00){
                price = priceBefore15;
            }else{
                price = priceAfter15;
            }
        }else if(day == dayOfWeeks[5]){
            price = priceForWeekends;
        }else if(day == dayOfWeeks[6]){
            price = priceForWeekends;
        }
    }

    return `${price}`;
}

console.log(calculatePriceForGym("Monday", "Sauna", 15.30));
console.log(calculatePriceForGym("Sunday", "Fitness", 22.00));

// 06.	Same Numbers

function checkNumbers(number){

    let numbers = '' + number;

    for(var i = 0; i < numbers; i++){
        numbers.push(number[i]);
    }

    console.log(numbers);
}

console.log(checkNumbers(2222));