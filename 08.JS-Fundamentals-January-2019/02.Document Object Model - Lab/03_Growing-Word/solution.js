function solve() {
    let counter = 0;
    let colorCounter = 0;

    let paragraph = document.getElementsByTagName('p')[2];

    let colorArr = ['blue', 'green', 'red'];

    let button = document.getElementsByTagName('button')[0];

    button.onclick = () => {
        console.log(paragraph);
        counter++;
        let newSize = counter * 2;
        paragraph.style.fontSize = newSize + 'px';

        if (colorCounter >= colorArr.length) {
            colorCounter = 0;
        }
        paragraph.style.color = colorArr[colorCounter];
        colorCounter++;
    };
}