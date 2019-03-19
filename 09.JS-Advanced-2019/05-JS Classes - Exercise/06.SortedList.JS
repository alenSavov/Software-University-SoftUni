class SortedList {
    constructor(){
        this._list = [];
        this.size = 0;
    }

    get list(){
        return this._list;
    }

    add(element) {
        this._list.push(element);
        this.size++;
        this.sort();
    }

    remove(index) {
        if (index < 0 || index > (this.list.length - 1)) {

        }else {
            this.list.splice(index, 1);
            this.size--;
            this.sort();
        }
    }

    get(index){
        if (index < 0 || index > (this.list.length - 1)) {
            throw  new  Error ();
        } else {
            return this.list[index];
        }
    }

    sort(){
        this._list = this.list.sort((a, b) => a - b);
    }
}

let sortObj = new SortedList();
sortObj.size = sortObj.list.length;

console.log(sortObj.size);