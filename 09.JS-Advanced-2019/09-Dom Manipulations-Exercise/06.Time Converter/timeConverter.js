function attachEventsListeners() {
    console.log('test')
    var bns = $('input[type=button]');
    console.log(bns)
    bns.on("click", function(e) {
        let pushedBtn = e.target.id;

    });
}
