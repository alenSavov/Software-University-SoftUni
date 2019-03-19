function solve() {
    let myObj = {
        extend: function (template) {
            const entries = Object.entries(template);
            for (const [key, value] of entries) {
                if (typeof value === "function") {
                    Object.getPrototypeOf(this)[key] = value;
                } else {
                    this[key] = value;
                }
            }
        }
    };

    return myObj;
}

const obj = solve();
obj.extend({
    extensionMethod: function () {console.log('Attached to proto')},
    testFunc: () => {console.log('test')},
    extensionProperty: 'someString'
});
console.log(obj);