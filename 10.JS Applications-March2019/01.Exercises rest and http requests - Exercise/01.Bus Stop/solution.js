function getInfo() {
    let submitButton = $('#submit');
    let stopId = $('#stopId').val();
    let url = `https://judgetests.firebaseio.com/businfo/${stopId}.json `;

    $.ajax({
        url: url,
        success: displayBuses,
        error: displayError,
    })

    $('#stopId').val('');

    function displayBuses(data) {
        let stopName = $('#stopName');
        stopName.text(data.name);

        let buses = $('#buses');
        for (let [key, value] of Object.entries(data.buses)) {
           buses.append($(`<li>Bus ${key} arrives in ${value} minutes</li>`))

        }
    }

    function displayError() {
        let stopName = $('#stopName').append('Error');
    }
}