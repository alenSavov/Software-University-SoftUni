function loadCommits() {
    $('#commits').empty();
    let username = $('#username').val();
    let repo = $('#repo').val();

    let url = `https://api.github.com/repos/${username}/${repo}/commits`;

    $.get(url)
        .then(displayCommits)
        .catch(displayError);
    
    function displayCommits(commits) {
        for(let commit of commits){
            let username = commit.commit.author.name;
            let message = commit.commit.message;

           let li = $(`<li>${username}: ${message}</li>`);
            $('#commits').append(li);
        }

    }
    
    function displayError() {
        let li = $(`<li>Error: 404 (Not Found)</li>`);
        $('#commits').append(li);
    }

}