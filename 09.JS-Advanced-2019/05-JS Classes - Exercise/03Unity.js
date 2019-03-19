class Rat{
    constructor(name){
        this.name = name;
        this.unitedRats = [];
    }

    getRats(){
        return this.unitedRats;
    }

    toString(){
        let result = "";
        result += this.name + "\n";
        Array.from(this.unitedRats).forEach((rat) => {
            result += "##" + rat.name.toString() + "\n";
        });

        result = result.trim();

        return result;
    }

    unite(otherRat){
        if(!otherRat){

        } else if (otherRat.constructor.name !== "Rat"){

        } else {
            this.unitedRats.push(otherRat);
        }
    }
}

let test = new Rat('Pesho');
console.log(test.toString());

console.log(test.getRats());

test.unite(new Rat('Gosho'));
test.unite(new Rat('Pesho2'));

console.log(test.toString())