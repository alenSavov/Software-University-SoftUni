class CheckingAccount {
    constructor(clientId, email, firstName, lastName) {
        this.clientId = clientId;
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
    }

    get clientId() {
        return this._clientId;
    }

    set clientId(clientId) {
        let lengthValidation = clientId.length === 6;
        let numberValidation = Number.isInteger(Number(clientId));

        if (!lengthValidation || !numberValidation) {
            throw new TypeError('Client ID must be a 6-digit number');
        }

        this._clientId = clientId;
    }

    set email(value) {
        if (!(/([\w]+@[a-zA-Z\.]+)/gm).test(value)){
            throw  new TypeError('Invalid e-mail')
        }
        this._email = value;
    }

    set firstName(value) {
        let nameLength = value.length >= 3 && value.length <= 20;
        let latinLettherValidation = (/^([a-zA-Z]+)$/gm).test(value);

        if (!nameLength) {
            throw new TypeError('First name must be between 3 and 20 characters long');
        }
        if (!latinLettherValidation) {
            throw new TypeError('First name must contain only Latin characters');
        }

        this._firstName = value;
    }

    set lastName(value) {
        let nameLength = value.length >= 3 && value.length <= 20;
        let latinLettherValidation = (/^([a-zA-Z]+)$/gm).test(value);

        if (!nameLength) {
            throw new TypeError('Last name must be between 3 and 20 characters long');
        }
        if (!latinLettherValidation) {
            throw new TypeError('Last name must contain only Latin characters');
        }

        this._lastName = value;
    }

    get email() {
        return this._email;
    }

    get firstName() {
        return this._firstName;
    }

    get lastName() {
        return this._lastName;
    }

}

//let acc = new CheckingAccount('1314', 'ivan@some.com', 'Ivan', 'Petrov')
//let acc = new CheckingAccount('131455', 'ivan@', 'Ivan', 'Petrov')
//let acc = new CheckingAccount('131455', 'ivan@some.com', 'I', 'Petrov')
//let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov')
let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov')
console.log(acc);