class BookCollection {
    constructor(shelfGenre, room, shelfCapacity) {
        this.shelfGenre = shelfGenre;
        this.room = room;
        this.shelfCapacity = shelfCapacity;
        this.shelf = [];

        return this;
    }

    get room() {
        return this._room;
    }

    set room(value) {
        switch (value) {
            case 'livingRoom':
            case'bedRoom':
            case 'closet':
                this._room = value;
                break;
            default:
                throw `Cannot have book shelf in ${value}`;
        }
    }

    get shelfCondition() {
        return this.shelfCapacity - this.shelf.length;
    }

    addBook(bookName, bookAuthor, genre) {
        let book = {
            bookName: bookName,
            bookAuthor: bookAuthor,
        };

        if (this.shelfCondition <= 0) {
            this.shelf.shift();
        }

        this.shelf.push(book);
        this.shelf.sort((a, b) => a.bookAuthor.localeCompare(b.bookAuthor));

        return this;
    }

    throwAwayBook(bookName) {
        let result = this.shelf
            .filter(b => b.bookName === bookName);

        this.shelf.remove(result);

        return this;
    }

    showBooks(genre) {
        let result = `Results for search "${genre}":\n`;

        result += this.shelf
            .filter(b => b.genre === genre)
            .map(b => `\uD83D\uDCD6 ${b.bookAuthor} - "${b.bookName}"`)
            .join('\n');

        return result.trim();
    }

    toString() {
        if (this.shelf.length <= 0) {
            return "It's an empty shelf";
        }

        let result = `"${this.shelfGenre}" shelf in ${this.room} contains:\n`;
        result += this.shelf
            .map(b => `\uD83D\uDCD6 "${b.bookName}" - ${b.bookAuthor}`)
            .join('\n');

        return result.trim();
    }
}

let livingRoom = new BookCollection("Programming", "livingRoom", 5)
    .addBook("Introduction to Programming with C#", "Svetlin Nakov")
    .addBook("Introduction to Programming with Java", "Svetlin Nakov")
    .addBook("Programming for .NET Framework", "Svetlin Nakov");
console.log(livingRoom.toString());

