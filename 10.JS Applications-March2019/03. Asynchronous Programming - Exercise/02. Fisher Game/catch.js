function attachEvents() {
    const baseUrl = 'https://baas.kinvey.com/';
    const appKey = 'kid_BJlCShid4';
    const endpoint = 'biggestCatches';
    const username = 'pesho';
    const password = '123456';
    const headers = {
        'Authorization': `Basic ${btoa(username + ':' + password)}`, 'Content-Type': 'application/json'
    };

    $('#aside > button').on('click', loadCatches);
    $('#addForm > button').on('click', createCatches);
    $('#catches > div:nth-child(1) > button.update').on('click', updateCatches);

    async function loadCatches() {
        try {
            let catches = await $.ajax({
                url: baseUrl + 'appdata/' + appKey + '/' + endpoint,
                method: 'GET',
                headers
            });

            for (let catchInfo of catches) {
                let div = $(` <div class="catch" data-id=${catchInfo._id}>
                    <label>Angler</label>
                    <input type="text" class="angler" value=${catchInfo.angler} />
                    <label>Weight</label>
                    <input type="number" class="weight" value=${catchInfo.weight} />
                    <label>Species</label>
                    <input type="text" class="species" value=${catchInfo.species} />
                    <label>Location</label>
                    <input type="text" class="location" value=${catchInfo.location} />
                    <label>Bait</label>
                    <input type="text" class="bait" value=${catchInfo.bait} />
                    <label>Capture Time</label>
                    <input type="number" class="captureTime" value=${catchInfo.captureTime} />
                  </div>`);

                let updateBtn = $(`<button class="update">Update</button>`);
                let deleteBtn = $(`<button class="delete">Delete</button>`);
                updateBtn.on('click', updateCatches);
                deleteBtn.on('click', deleteCatches);

                div.append(updateBtn);
                div.append(deleteBtn);
                $('#catches').append(div);
            }
        } catch (err) {
            console.log(err);
        }
    }

    async function createCatches() {
        let angler = $('#addForm > input.angler').val();
        let weight = +$('#addForm > input.weight').val();
        let species = $('#addForm > input.species').val();
        let location = $('#addForm > input.location').val();
        let bait = $('#addForm > input.bait').val();
        let captureTime = +$('#addForm > input.captureTime').val();

        let catchesObj = {
            angler,
            weight,
            species,
            location,
            bait,
            captureTime
        };

        try {
            await $.ajax({
                url: baseUrl + 'appdata/' + appKey + '/' + endpoint,
                method: 'POST',
                headers,
                data: JSON.stringify(catchesObj)
            });
        } catch (err) {
            console.log(err);
        }

        $('#catches').empty();
        loadCatches();
    }

    async function updateCatches() {
        let id = $(this).parent().data('id');

        let angler = $(this).parent().find('input.angler').val();
        let weight = +$(this).parent().find('input.weight').val();
        let species = $(this).parent().find('input.species').val();
        let location = $(this).parent().find('input.location').val();
        let bait = $(this).parent().find('input.bait').val();
        let captureTime = +$(this).parent().find('input.captureTime').val();

        let newCatch = {
            angler,
            weight,
            species,
            location,
            bait,
            captureTime
        };
        try {
            await $.ajax({
                url: baseUrl + 'appdata/' + appKey + '/' + endpoint + '/' + id,
                method: 'PUT',
                headers,
                data: JSON.stringify(newCatch)
            });
        } catch (err) {
            console.log(err);
        }

        $('#catches').empty();
        loadCatches();
    }

    async function deleteCatches() {
        let id = $(this).parent().data('id');

        try {
            await $.ajax({
                url: baseUrl + 'appdata/' + appKey + '/' + endpoint + '/' + id,
                method: 'DELETE',
                headers
            });
        } catch (err) {
            console.log(err);
        }

        $('#catches').empty();
        loadCatches();
    }
}

