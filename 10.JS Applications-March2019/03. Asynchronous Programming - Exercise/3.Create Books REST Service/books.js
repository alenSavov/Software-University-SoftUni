function attachEvents() {
    const baseUrl = 'https://baas.kinvey.com/';
    const appKey = 'kid_rkVoY1n_E';
    const endpoint = 'books';
    const username = 'pesho';
    const password = '123456';
    const headers = {
        'Authorization': `Basic ${btoa(username + ':' + password)}`, 'Content-Type': 'application/json'
    };

    $('#loadBooks').on('click', loadBooks);
    $('#newBook').on('click', createBook);


    async function loadBooks() {
        try {
            let books = await $.ajax({
                url: baseUrl + 'appdata/' + appKey + '/' + endpoint,
                method: 'GET',
                headers
            });


            for (let book of books) {
                let bookDiv =
                    $(` 
                   <div class="col-3 border border-dark" data-id=${book._id}>
                     <p class="align-center">${book.title}</p>
                     <hr/>
                     <p>${book.author}</p>
                     <p>${book.isbn}</p>
                     <hr/>    
                     <div id="buttonsDiv">
                     </div>
                    </div>`);

                let deleteBtn = $('<button type="button" id="updateBookBtn" class="btn btn-primary">Update</button>');
                let updateBtn = $(' <button type="button" id="deleteBookBtn" class="btn btn-danger">Delete</button>');
                deleteBtn.on('click', removeBook);
                updateBtn.on('click', editBook);

                let bookCollection = $('#booksCollection');
                bookCollection.append(bookDiv);
                $('#buttonsDiv').append(updateBtn);
                $('#buttonsDiv').append(deleteBtn);
            }

            $('#updateBookBtn').on('click', updateBook);
            $('.btn-danger').on('click', removeBook);

        } catch (err) {
            console.log(err);
        }

    }

    function showEditSection() {
        let editBookDiv = $('#editBookDiv');

        let editBookHTML = $(
            `<div class="form-group">
               <label for="formGroupExampleInput">Author</label>
               <input type="text" class="form-control" id="authorInput" placeholder="Author name">
              </div>
             <div class="form-group">
               <label for="formGroupExampleInput2">Title</label>
               <input type="text" class="form-control" id="titleInput" placeholder="Title">
             </div>
             <div class="form-group">
               <label for="formGroupExampleInput2">ISBN</label>
               <input type="text" class="form-control" id="isbnInput" placeholder="ISBN">
             </div>
             <div class="d-flex justify-content-center">
            <button type="button" id="editBtn" class="btn btn-primary">Edit</button>
            </div>
        `);

        editBookDiv.append(editBookHTML);
        editBookDiv.show();
        $('#editBtn').on('click', editBook);
    }

    async function removeBook() {
        let id = $(this).parent().parent().data('id');
        console.log(id)

        // try {
        //
        //     await $.ajax({
        //         url: baseUrl + 'appdata/' + appKey + '/' + endpoint + '/' + id,
        //         method: 'DELETE',
        //         headers
        //     });
        // } catch (err) {
        //     console.log(err);
        // }
        //
        // $('#tbody').empty();
        // loadBooks();
    }

    async function editBook() {

        let author = $('#authorInput').val();
        let title = $('#titleInput').val();
        let isbn = $('#isbnInput').val();
        let id = $(this);

        let updatedBook = {
            title,
            author,
            isbn
        };
        console.log(id)
        try {
            await $.ajax({
                url: baseUrl + 'appdata/' + appKey + '/' + endpoint + '/' + id,
                method: 'PUT',
                headers,
                data: JSON.stringify(updatedBook),
            });
        } catch (err) {
            console.log(err);
        }

        $('#tbody').empty();
        loadBooks();
        $('#editBookDiv').hide();

    }

    function createBook() {

        let createBookHTML = $(
            `<div class="form-group">
               <label for="formGroupExampleInput">Author</label>
               <input type="text" class="form-control" id="authorInput" placeholder="Author name">
              </div>
             <div class="form-group">
               <label for="formGroupExampleInput2">Title</label>
               <input type="text" class="form-control" id="titleInput" placeholder="Title">
             </div>
             <div class="form-group">
               <label for="formGroupExampleInput2">ISBN</label>
               <input type="text" class="form-control" id="isbnInput" placeholder="ISBN">
             </div>
             <div class="d-flex justify-content-center">
            <button type="button" id="createBtn" class="btn btn-success">Create</button>
            </div>
        `);

        let createBookDiv = $('#createBookDiv');
        createBookDiv.append(createBookHTML);
        createBookDiv.css('display', 'block');

        $('#createBtn').on('click', addBook);
    }

    async function addBook() {
        let author = $('#authorInput').val();
        let title = $('#titleInput').val();
        let isbn = $('#isbnInput').val();

        let book = {
            author,
            title,
            isbn
        };

        try {
            await $.ajax({
                url: baseUrl + 'appdata/' + appKey + '/' + endpoint,
                method: 'POST',
                headers,
                data: JSON.stringify(book),
            });
        } catch (err) {
            console.log(err);
        }

        $('#createBookDiv').css('display', 'none');
        $('#tbody').empty();
        loadBooks();
    }

}