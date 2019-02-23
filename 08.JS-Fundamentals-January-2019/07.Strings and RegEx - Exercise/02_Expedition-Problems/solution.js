function solve() {

    let inputKey = document.querySelector('#str').value;
    let inputText = document.querySelector('#text').value;
    let output = document.querySelector('#result');

    let regExNorth = /(north|east).*?(\d{2})[^,]*?,[^,]*?(\d{6})/gi;
    let regExMessage = new RegExp(`${inputKey}(.*?)${inputKey}`, "g");
    let message = `Message: ${regExMessage.exec(inputText)[1]}`;

    let result;
    let north;
    let east;

    while (result = regExNorth.exec(inputText)) {
        if (result[1].toLowerCase() === 'north') {
            north = `${result[2]}.${result[3]} N`;
        } else {
            east = `${result[2]}.${result[3]} E`;
        }
    }

    createAddAppend('p', north, output);
    createAddAppend('p', east, output);
    createAddAppend('p', message, output);

    function createAddAppend(child, text, parent) {
        let childElement = document.createElement(child);
        childElement.textContent = text;
        parent.appendChild(childElement);
    }
}