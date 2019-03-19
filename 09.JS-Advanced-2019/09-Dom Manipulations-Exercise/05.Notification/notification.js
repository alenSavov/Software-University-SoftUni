function notify(message) {

    let notification = $('#notification');

    let p = document.createElement('p');
    p.textContent = message;
    notification.append(p);
    notification[0].style.display = 'block';

    setTimeout(function()
    {
        notification[0].style.display = 'none';

    }, 2000);

}