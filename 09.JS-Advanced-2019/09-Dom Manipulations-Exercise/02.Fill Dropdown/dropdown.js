/*
function addItem() {
    let itemText = document.getElementById('newItemText');
    let itemValue = document.getElementById('newItemValue');

    let optionElement = document.createElement('option');
    optionElement.textContent = itemText.value;
    optionElement.value = itemValue.value;

    let menuElement = document.getElementById('menu');
    menuElement.appendChild(optionElement);

    itemText.value = '';
    itemValue.value = '';
}

*/


function create(sentences) {
    let arr = Array.from(sentences);

    for (let i = 0; i < arr.length; i++) {
        let divElement = document.createElement('div');
        let paragraphElement = document.createElement('p');
        paragraphElement.style.display = 'none';

        paragraphElement.textContent = arr[i];
        divElement.append(paragraphElement);
        document.getElementById('content').append(divElement);
    }

    let divElements = document.querySelectorAll('#content div');
    divElements.forEach(e => e.addEventListener('click', function () {
        console.log(e.getElementsByTagName('p'))
    }))
}