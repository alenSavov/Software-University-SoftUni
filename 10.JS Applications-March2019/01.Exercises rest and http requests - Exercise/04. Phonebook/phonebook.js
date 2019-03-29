function attachEvents(){
    let phoneBookList = $("#phonebook");

    let loadBtn = $("#btnLoad");

    function deleteContact(btn, e) {
        let name = btn.target.parentElement.textContent.split(" ")[0];
        let key = "";

        Object.keys(e).forEach((el) =>{
            if(e[el].person === name){
                key = el;
            }
        });

        let url = "https://phonebook-nakov.firebaseio.com/phonebook/" + key + ".json";
        $.ajax({
            type: "DELETE",
            url: url,
            success: () => laodContacts()
        });
    }

    function laodContacts(){
        $("#phonebook").html("");

        $.get("https://phonebook-nakov.firebaseio.com/phonebook.json", function(e){
            Object.keys(e).forEach((el, index) =>{
                phoneBookList.append("<li>" + e[el].person + " " + e[el].phone + " <button>[Delete]</button></li>")
            });

            $("#phonebook > li > button").on("click", (btn) => deleteContact(btn, e));
        });
    }

    loadBtn.on("click", () => laodContacts());

    let createBtn = $("#btnCreate");
    createBtn.on("click", function(){
        let personName = $("#person").val();
        let phone = $("#phone").val();

        let obj = JSON.stringify({
            person: personName,
            phone: phone
        });

        let url = "https://phonebook-nakov.firebaseio.com/phonebook.json";
        $.ajax({
            type: "POST",
            url: url,
            data: obj,
            success: () => laodContacts()
        });

        $("#person").val("");
        $("#phone").val("");
    });
}