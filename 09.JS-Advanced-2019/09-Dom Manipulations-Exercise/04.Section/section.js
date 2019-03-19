function create(sentences) {
    Array.from(sentences).forEach(e => {
        let divElement = document.createElement('div');
        let paragraphElement = document.createElement('p');
        paragraphElement.style.display = 'none';

        paragraphElement.textContent = e;
        divElement.appendChild(paragraphElement);
        $('#content').append(divElement);
    })
    let divElements = document.querySelectorAll('#content div');

    divElements.forEach(e => e.addEventListener('click', function () {
        e.getElementsByTagName('p')[0].style.display = 'block';
    }))

}
