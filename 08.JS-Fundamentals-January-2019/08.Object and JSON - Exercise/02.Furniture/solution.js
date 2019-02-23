function solve() {
    let generateBtn = document.getElementsByTagName('button')[0];
    let buyBtn = document.getElementsByTagName('button')[1];

    generateBtn.addEventListener('click', generate);
    buyBtn.addEventListener('click', buy);

    function createPar(string) {
        let p = document.createElement('p');
        p.textContent = string;
        return p;
    }
    function createEl(type, attr, value) {
        let typeEl = document.createElement(type);
        typeEl.setAttribute(attr, value);
        return typeEl;
    }

    function addToDiv(arr) {
        for (let product of arr) {
            let divEl = document.getElementById('furniture-list');
            let divProduct = createEl('div', 'class', 'furniture');
            divProduct.appendChild(createPar(`Name: ${product.name}`));
            divProduct.appendChild(createEl('img', 'src', arr.img));
            divProduct.appendChild(createPar(`Price: ${product.price}`));
            divProduct.appendChild(createPar(`Decoration factor: ${product.decFactor}`));
            divProduct.appendChild(createEl('input', 'type', 'checkbox'));
            divEl.appendChild(divProduct);
        }
    }

    function generate() {
        let productArr = JSON.parse(document.getElementsByTagName('textarea')[0].value);
        addToDiv(productArr);
    }

    function buy() {
        let furnItems = Array.from(document.querySelectorAll('#furniture-list [class="furniture"]'))
        let [boughtItems, totalPrice, factor, count] = [[], 0, 0, 0];
        for (let product of furnItems) {
            if (product.children[4].checked) {
                boughtItems.push(product.children[0].textContent.split(': ')[1]);
                totalPrice += +product.children[2].textContent.split(': ')[1];
                factor += +product.children[3].textContent.split(': ')[1];
                count += 1;
            }
        }
        let outputArea = document.getElementsByTagName('textarea')[1];
        outputArea.textContent += `Bought furniture: ${boughtItems.join(', ')}\n`;
        outputArea.textContent += `Total price: ${totalPrice.toFixed(2)}\n`;
        outputArea.textContent += `Average decoration factor: ${factor / count}`;
    }
}