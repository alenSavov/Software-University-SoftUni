function toggle(){
    let showBtn = document.querySelector("span");
    let hiddenDiv = document.querySelector("#extra");

    if(showBtn.textContent === "More"){
        showBtn.textContent = "Less";
        hiddenDiv.style.display = "block";
    } else {
        showBtn.textContent = "More";
        hiddenDiv.style.display = "none";
    }
}