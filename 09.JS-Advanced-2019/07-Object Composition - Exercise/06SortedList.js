function solve(){
    let arr = [];

    let listObj = {
        add: function(element){
            arr.push(element);
            arr = this.sort();
            this.size++;
        },
        sort: function(){
            return Array.from(arr).sort((a, b) => a - b);
        },
        remove: function(index){
            if(index >= 0 && index <= arr.length - 1){
                this.size--;
                arr[index] = undefined;
                arr = Array.from(arr).filter((x) => {
                    if(x === undefined){
                        return false;
                    }
                    return true;
                });
                arr = this.sort();
            }
        },
        get: function(index){
            if(index >= 0 && index <= arr.length - 1){
                return arr[index];
            }
        },
        size: 0
    }

    return listObj;
}