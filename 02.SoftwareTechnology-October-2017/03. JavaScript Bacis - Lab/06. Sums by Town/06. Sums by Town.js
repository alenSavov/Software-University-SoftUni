function solve(input) {
    let allTowns = {};
    for (let json of input) {
        let obj = JSON.parse(json);
        if (!(obj.town in allTowns)) {
            allTowns[obj.town] = 0;
        }
        allTowns[obj.town] += obj.income;
    }
    let sortedTowns = Object.keys(allTowns).sort((e2, e1) => e2 > e1);

    for (let town of sortedTowns){
        console.log(`${town} -> ${allTowns[town]}`);
    }
}

solve(['{"town":"Sofia","income":200}',
    '{"town":"Varna","income":120}',
    '{"town":"Pleven","income":60}',
    '{"town":"Varna","income":70}']);