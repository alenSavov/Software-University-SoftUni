function solve(input){
    let car = {};
    car.model = input.model;

    let engines = [{ power: 90, volume: 1800 },
        { power: 120, volume: 2400 },
        { power: 200, volume: 3500 }];

    let targetEngine = engines.filter(e => e.power >= input.power)[0];
    car.engine = targetEngine;

    let typeCars = [{ type: 'hatchback', color: ''},
                   { type: 'coupe', color: '' }]

    let targetTypeCar = typeCars.filter(c => c.type === input.carriage)[0];
    targetTypeCar.color = input.color;
    car.carriage = targetTypeCar;

    let wheels = [];
    if (input.wheelsize %2 == 0 && input.wheelsize > 0) {
        for (let i = 0; i < 4; i++) {
        let whelsize = input.wheelsize - 1;
            wheels.push(whelsize);
        }
    } else {
        for (let i = 0; i < 4; i++) {
            wheels.push(input.wheelsize);
        }
    }
    car.wheels = wheels;

    return car;
}

console.log(solve({ model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14 }
));
/*
console.log(solve({ model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17 }
))*/
