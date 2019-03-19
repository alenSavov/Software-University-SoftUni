function timer() {
    let isTriggered = false;

    let hours = $("#hours");
    let minutes = $("#minutes");
    let seconds = $("#seconds");

    let startTimerBtn = $("#start-timer");
    let stopTimerBtn = $("#stop-timer");

    let hoursCounter = 0;
    let minutesCounter = 0;
    let secondsCounter = 0;

    function incrementTimer(){
        isTriggered = true;

        secondsCounter++;
        if(secondsCounter > 59){
            secondsCounter = 0;
            minutesCounter++;
        } else if (minutesCounter > 59){
            minutesCounter = 0;
            hoursCounter++;
        }

        if(hoursCounter < 10){
            hours.text("0" + hoursCounter.toString());
        } else {
            hours.text(hoursCounter.toString());
        }
        if(minutesCounter < 10){
            minutes.text("0" + minutesCounter.toString());
        } else {
            minutes.text(minutesCounter.toString());
        }
        if(secondsCounter < 10){
            seconds.text("0" + secondsCounter.toString());
        } else {
            seconds.text(secondsCounter.toString());
        }
    }

    let intervalFunction;

    startTimerBtn.on("click", () => {
        if(!isTriggered){
            intervalFunction = setInterval(incrementTimer, 1000);
        }
    });

    stopTimerBtn.on("click", () => {
        isTriggered = false;
        clearInterval(intervalFunction);
    });
}