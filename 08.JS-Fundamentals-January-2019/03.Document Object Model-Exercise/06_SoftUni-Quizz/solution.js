function solve() {
    let nextQuestionBtns = document.getElementsByTagName("button");
    let sections = document.getElementsByTagName("section");

    let secondSection = sections[1];
    let thirdSection = sections[2];

    nextQuestionBtns[0].addEventListener('click', function () {
        secondSection.style.display = 'block';
    })

    nextQuestionBtns[1].addEventListener('click', function () {
        thirdSection.style.display = 'block';
    })

    let firstQuestionAnswer = 2013;
    let secondQuestionAnswer = "Pesho";
    let thirdQuestionAnswer = "Nakov";

    function CalculateCorrectAnswersCount(correctAnswersCount) {
        let answers = [];
        let radios = document.querySelectorAll('input');

        Array.from(radios).forEach(function (currentRadioBtn) {
            if (currentRadioBtn.checked == true) {
                answers.push(currentRadioBtn.value);
            }
        })

        if (answers.includes(firstQuestionAnswer.toString())) {
            correctAnswersCount++;
        }
        if (answers.includes(secondQuestionAnswer.toString())) {
            correctAnswersCount++;
        }
        if (answers.includes(thirdQuestionAnswer.toString())) {
            correctAnswersCount++;
        }

        return correctAnswersCount;
    }

    let thirdQuestionBtn = nextQuestionBtns[2];
    thirdQuestionBtn.addEventListener('click', function () {
        let resultDiv = document.getElementById('result');

        let correctAnswersCount = 0;
        correctAnswersCount = CalculateCorrectAnswersCount(correctAnswersCount);

        if(correctAnswersCount === 3){
            resultDiv.textContent = "You are recognized as top SoftUni fan!";
        }
        else{
            resultDiv.textContent = "You have " + correctAnswersCount + " right answers";
        }
    })
}