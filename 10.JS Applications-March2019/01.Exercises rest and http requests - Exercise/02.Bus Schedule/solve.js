function solve() {
    let currentStop = 'depot';
    return {
        depart,
        arrive
    };

    function depart() {
        let baseUrl = 'https://judgetests.firebaseio.com/schedule/' + currentStop + ".json";

        $.ajax({
            url: baseUrl,
            success: function (result) {
                $('#info > span').text(`Next stop ${result.name}`);
                switchButtons('depart', 'arrive');
                currentStop = result.next;
            },
            error: errorFunction,
        })
    }

    function arrive() {
        switchButtons('arrive', 'depart');
        $('#info > span').text(`Arriving at Depot`);
    }

    function switchButtons(depart, arrive) {
        $(`#${depart}`).attr('disabled', true);
        $(`#${arrive}`).attr('disabled', false);
    }

    function errorFunction() {
        $('#info > span').text('Error');
        $(`#${depart}`).attr('disabled', true);
        $(`#${arrive}`).attr('disabled', true);
    }
}

let result = solve();
