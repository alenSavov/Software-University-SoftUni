function attachEvents () {
    $('#submit').on('click', sendMessage);
    $('#refresh').on('click', loadMessages);

    let baseUrl = 'https://test-bef85.firebaseio.com/.json';
    let name = $('#author');
    let content = $('#content');


    function sendMessage() {
        let newMsg = JSON.stringify({
            author: name.val(),
            content: content.val(),
            timespamp: Date.now(),
        })
        clearInputFields();
        $.post(baseUrl, newMsg);
    }

    function loadMessages() {
        $.ajax({
            url: baseUrl,
            success: displayMsg,
        })
    }

    function displayMsg(messages) {
        let messagesBox = $('#messages');

        Object.keys(messages).sort((a,b) => b.timestamp).forEach((m) => {
            let author = messages[m].author;
            let content = messages[m].content;
            messagesBox.append(`${author}: ${content} \n`)
        })
    }

    function clearInputFields() {
        name.val('');
        content.val('');
    }
}