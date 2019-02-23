function solve() {
    let buttons = document.getElementsByTagName('button');
    let nextBtn = buttons[0];
    let cancelBtn = buttons[1];

    let radioBtns = document.getElementsByTagName('input');
    let sectionElements = document.getElementsByTagName('section');

    let firstStepElements = document.getElementById('firstStep');
    let secondStepElements = document.getElementById('secondStep');
    let thirdStepElements = document.getElementById('thirdStep');

    let content = document.getElementById('content');
    let stepCounter = 1;

    nextBtn.addEventListener('click', function () {
        if (stepCounter == 1) {
            makeFirstStep(content, firstStepElements);
            stepCounter++;
            return;
        }
        if (stepCounter == 2 && CheckBtnIsSelected(radioBtns)) {
            makeSecondStep(secondStepElements);
            stepCounter++;
            return;
        }
        if (stepCounter == 3) {
            makeThirdStep(secondStepElements, thirdStepElements);
            stepCounter++;
        }
        if (stepCounter == 4) {


        }
    })

    cancelBtn.addEventListener('click', function () {
        finishProgram(sectionElements);
    })

    function finishProgram(sectionElements) {
        sectionElements[0].style.display = 'none';
    }

    function makeThirdStep(secondStepElements, thirdStepElements) {
        secondStepElements.style.display = 'none';
        thirdStepElements.style.display = 'block';
        nextBtn.innerText = 'Finish';

        cancelBtn.style.display = 'none';
    }

    function makeSecondStep(secondStepElements) {

        firstStepElements.style.display = 'none';
        nextBtn.style.display = 'none';
        secondStepElements.style.display = 'block';

        setTimeout(() => {
            nextBtn.style.display = 'block';
        }, 3000);
    }

    function makeFirstStep(content, firstStepElements) {
        content.style.background = 'none';
        firstStepElements.style.display = 'block';
    }

    function CheckBtnIsSelected(buttons) {

        for (let i = 0; i < buttons.length; i++) {
            if (buttons[0].checked == true) {
                return true;
            } else {
                return false;
            }
        }
    }
}