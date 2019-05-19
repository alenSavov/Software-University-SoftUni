function onlineShop(selector) {
    let form = `<div id="header">Online Shop Inventory</div>
    <div class="block">
        <label class="field">Product details:</label>
        <br>
        <input placeholder="Enter product" class="custom-select">
        <input class="input1" id="price" type="number" min="1" max="999999" value="1"><label class="text">BGN</label>
        <input class="input1" id="quantity" type="number" min="1" value="1"><label class="text">Qty.</label>
        <button id="submit" class="button" disabled>Submit</button>
        <br><br>
        <label class="field">Inventory:</label>
        <br>
        <ul class="display">
        </ul>
        <br>
        <label class="field">Capacity:</label><input id="capacity" readonly>
        <label class="field">(maximum capacity is 150 items.)</label>
        <br>
        <label class="field">Price:</label><input id="sum" readonly>
        <label class="field">BGN</label>
    </div>`;
    $(selector).html(form);

    let productElement = $('.custom-select');
    let priceElement = $('#price');
    let quantityElement = $('#quantity');

    let submitBtn = $('#submit');
    let capacity = $('#capacity');
    let sum = $('#sum');


    productElement = $('.custom-select').on('input', function () {
        submitBtn.attr('disabled', false);
    });

    let currectSum = 0;
    let currentCapacity = 0;
    submitBtn.on('click', function () {
        let ul = $('.display');
        let li = $('<li>');

        li.append(`Product: ${productElement.val()} Price: ${priceElement.val()} Quantity: ${quantityElement.val()}`);

        ul.append(li);

        currectSum += Number(+priceElement.val() * +quantityElement.val());
        sum.val(currectSum);

        currentCapacity += Number(quantityElement.val());

        if (+currentCapacity < 150) {
            capacity.val(currentCapacity);
        } else {
            capacity.val('full');
            makeInputsDisabled();
            capacity.addClass('fullCapacity');
        }

        reset();
        submitBtn.attr('disabled', true);
    })

    function reset() {
        productElement.val('');
        priceElement.val('');
        quantityElement.val('');
    }

    function makeInputsDisabled() {
        productElement.attr('disabled', true);
        quantityElement.attr('disabled', true);
        priceElement.attr('disabled', true);
        priceElement.attr('disabled', true);
    }
}
