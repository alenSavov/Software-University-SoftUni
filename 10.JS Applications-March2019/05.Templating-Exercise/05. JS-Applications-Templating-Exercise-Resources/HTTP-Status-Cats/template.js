$(() => {
    renderCatTemplate();

    function renderCatTemplate() {
        let template = $("#cat-template").html();
        let compiledTemplate = Handlebars.compile(template);
        let renderedResult = compiledTemplate({cats});

        let catsElement = $("#allCats");
        catsElement.html(renderedResult);

        $("button").on("click", function(e){
            let target = $(e.target);
            let idDiv = target.next();
            if(idDiv.attr("style")){
                target.text("Hide status code");
                idDiv.removeAttr("style");
            } else {
                target.text("Show status code");
                idDiv.attr("style", "display: none");
            }
        });
    }
});