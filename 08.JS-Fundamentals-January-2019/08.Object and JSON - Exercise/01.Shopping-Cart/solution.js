function solve() {

    let addProductButton = Array.from(document.querySelectorAll('p + button'));
    let textArea = document.querySelector('textarea');
    let buyButton = document.querySelectorAll('button')[3];

    let productSet = [];
    let totalPrice = 0;

    addProductButton.forEach((buttons) => {
        buttons.addEventListener('click', addProduct)
    });

    buyButton.addEventListener('click', buy);

    function addProduct(e){
        let product = e.target.parentNode;
        let name = product.querySelectorAll('p')[0].textContent;
        let price = product.querySelectorAll('p')[1].textContent.split(': ')[1];

        if (!productSet.includes(name)) {
            productSet.push(name);
        }

        totalPrice += Number(price);

        textArea.value += `Added ${name} for ${price} to the cart.\n`
    }

    function buy() {
        textArea.value += `You bought ${productSet.join(', ')} for ${totalPrice.toFixed(2)}.\n`
    }
}