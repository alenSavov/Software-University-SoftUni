function solve(workerObj) {
    if (workerObj.hasOwnProperty('handsShaking') && workerObj.handsShaking === true) {
        let bloodAlcoholLevel = workerObj.bloodAlcoholLevel;
        bloodAlcoholLevel = (Number(workerObj.weight) * 0.1) * Number(workerObj.experience);

        workerObj.bloodAlcoholLevel += bloodAlcoholLevel;
        workerObj.handsShaking = false;
    }

    return workerObj;
}

console.log(solve({ weight: 120,
    experience: 20,
    bloodAlcoholLevel: 200,
    handsShaking: true }
));
