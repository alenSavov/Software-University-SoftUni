function acceptance() {
    let shippingCompany = $("input[name=shippingCompany]").val();
    let productName = $("input[name=productName]").val();
    let productQuantity = $("input[name=productQuantity]").val();
    let productScrape = $("input[name=productScrape]").val();

    let warehouseElement = $('#warehouse');
    let div = $('<div>');

    let p = $('<p>');

    let outOfStockBtn = $('<button>').attr({type: 'button'});
    outOfStockBtn.val('Out of stock');

    outOfStockBtn.on('click', function () {
        div.remove();

    });


    if (shippingCompany !== '' && productName !== '' && productQuantity !== '' && productScrape !== '') {

        if (!isNaN(productQuantity) && !isNaN(productScrape)) {

            if (productQuantity > 0) {
                if (productQuantity >= productScrape) {

                    p.text(`[${shippingCompany}] ${productName} - ${productQuantity} pieces`);

                    div.append(p);
                    div.append(outOfStockBtn);

                    reset();
                    warehouseElement.append(div);
                }
            }
        }


    }

    function reset() {
        $("input[name=shippingCompany]").val('');
        $("input[name=productName]").val('');
        $("input[name=productQuantity]").val('');
        $("input[name=productScrape]").val('');
    }
}