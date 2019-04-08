$(() => {
    // Getting the targeted div
    let monkeysElement = $(".monkeys");

    Array.from(monkeys).forEach((monkey) => {
        // Displaying the source
        let source =
            "<div class='monkey'>" +
            "<h2>" + monkey.name + "</h2>" +
            "<img src='" + monkey.image + "'/>" +
            "<button>Info</button>" +
            "<p style='display:none' id='" + monkey.id + "'>" +
            monkey.info +
            "</p>" +
            "</div>";

        // Registering the partial
        Handlebars.registerPartial("monkey", source);

        // Getting the partial's html
        let template = $("#monkey-template").html();
        // Compiling the partial
        let compiledTemplate = Handlebars.compile(template);
        // Rendering the result
        let result = compiledTemplate(monkey);

        // Appending the result to the div
        monkeysElement.append(result);
    });

    // Show/Hide info functionality
    $("button").on("click", function(e){
        let infoBtn = $(e.target);
        let infoDiv = infoBtn.next();
        if(infoDiv.css("display") !== "none"){
            infoDiv.hide();
        } else {
            infoDiv.show();
        }
    });
})