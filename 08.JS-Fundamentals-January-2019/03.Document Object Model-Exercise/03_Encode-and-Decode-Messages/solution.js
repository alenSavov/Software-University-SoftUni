function solve() {
    let button = document.getElementsByTagName('button');
    button[0].addEventListener('click', encode);
    button[1].addEventListener('click', decode);
    let textAreas = document.getElementsByTagName('textarea');


    function encode() {
        let encodeMessage = textAreas[0].value;
        let newMessage = '';

        encodeMessage.split('').forEach((char) => {
            let asciValue = char.charCodeAt(0) + 1;

            newMessage += String.fromCharCode(asciValue);


        });
        textAreas[0].value = '';
        textAreas[1].value = newMessage;
    }

    function decode() {
        let decodeMessage = textAreas[1].value;

        let originalMessage = '';

        decodeMessage.split('').forEach((char) => {
            let asciValue = char.charCodeAt(0) - 1;

            originalMessage += String.fromCharCode(asciValue);
        });

        textAreas[1].value = originalMessage;
    }

}