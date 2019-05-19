function addSticker() {
    let titleElement = $('.title');
    let contentElement = $('.content');

    if (titleElement.val() && contentElement.val()) {
        createSticker();
        reset();
    }


    function createSticker() {
        let ul = $('#sticker-list');

        let li = $('<li>');
        li.addClass('note-content')

        let x = $('<a>');
        x.addClass('button');
        x.text('x');

        x.on('click',  () => li.remove());

        let h = $('<h2>');
        h.text(`${titleElement.val()}`)

        let hr = $('<hr>');

        let p = $('<p>');
        p.text(contentElement.val());

        li.append(x);
        li.append(h);
        li.append(hr);
        li.append(p);
        ul.append(li);
    }

    function reset() {
        titleElement.val('');
        contentElement.val('');
    }
}

