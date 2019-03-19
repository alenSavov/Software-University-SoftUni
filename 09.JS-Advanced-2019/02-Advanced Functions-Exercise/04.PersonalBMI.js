function solve(name, age, weight, height) {
    let obj = {};
    let personalInfo = {};
    personalInfo.age = Math.round(age);
    personalInfo.weight = Math.round(weight);
    personalInfo.height = Math.round(height);

    let bmi = calculateBMI(weight,height);
    let status = getStatus(bmi);

    obj.name = name;
    obj.personalInfo = personalInfo;
    obj.BMI = Math.round(bmi);
    obj.status = getStatus(bmi)

    if (obj.status === 'obese') {
        obj.recommendation = 'admission required'
    }

    return obj;

    function getStatus(value) {
        if (value < 18.5) {
            return 'underweight';
        } else if (value > 18.5 && value < 25) {
            return 'normal';
        } else if (value > 25 && value < 30) {
            return 'overweight';
        } else if (value >= 30) {
            return 'obese';
        }
    }

    function calculateBMI(weight, height) {
        if (weight > 0 && height > 0) {
            let finalBmi = weight / (height / 100 * height / 100);
            return finalBmi;
        }
    }
}

let result = solve('Honey Boo Boo', 9, 57, 137);
console.log(result.personalInfo.age)
console.log(result.personalInfo.weight)
console.log(result.personalInfo.height)
console.log(result.BMI)
console.log(result.status)
console.log(result.recommendation)