function attachEvents() {
    $('#submit').on('click', getWeather);
    let baseUrl = `https://judgetests.firebaseio.com/`;


    async function getWeather() {
        try {
            let weather = await $.ajax({
                url: baseUrl + 'locations.json',
                method: 'GET'
            });

            let townName = $('#location').val();
            let code = weather.filter(t => t.name === townName)[0].code;

            let locationWeather = await $.ajax({
                url: baseUrl + `forecast/today/${code}.json`,
                method: 'GET',
            });

            let current = $('#current');
            current.append(`<span class="condition symbol">${getSymbol(locationWeather.forecast.condition)}</span>`);
            current.append(`<span class="condition"></span>`);

            let conditionSpan = $('#current > span:nth-child(3)');
            conditionSpan.append(`<span class="forecast-data">${locationWeather.name}</span>`);
            conditionSpan.append(`<span class="forecast-data">${locationWeather.forecast.low}&#176;/${locationWeather.forecast.high}&#176;</span>`);
            conditionSpan.append(`<span class="forecast-data">${locationWeather.forecast.condition}</span>`);


            let getWeatherThreeDays = await $.ajax({
                url: baseUrl + `forecast/upcoming/${code}.json`,
                method: 'GET'
            });

            for (let day of getWeatherThreeDays.forecast) {
                let upcomingDay = $(`
                    <span class="upcoming">
                    <span class="symbol">${getSymbol(day.condition)}</span>
                    <span class="forecast-data">${day.low}&#176;/${day.high}&#176;</span>
                    <span class="forecast-data">${day.condition}</span>
                    </span>`
                );

                $('#upcoming').append(upcomingDay);
            }

            let forecastElement = $('#forecast');
            forecastElement.show();
        } catch (err) {
            $('#forecast').show();
            $('#forecast').text('Error');
        }
    }

    function getSymbol(condition) {
        if (condition === 'Sunny') {
            return '&#x2600;';
        } else if (condition === 'Partly sunny') {
            return '&#x26C5;';
        } else if (condition === 'Overcast') {
            return '&#x2601;';
        } else if (condition === 'Rain') {
            return '&#x2614;';
        }
    }
}