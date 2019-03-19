function solve(selector){
    let parent = document.querySelector(selector);
    parent.classList.add("highlight");


    function highlightChildren(parentNode){
        let children = parentNode.children;

        let lengths = [];
        Array.from(children).forEach((ch) => {
            let childrenLength = Array.from(ch.children).length

            if(!lengths.includes(childrenLength)){
                ch.classList.add("highlight");
                if(childrenLength !== 0){
                    highlightChildren(ch);
                }
            }

            lengths.push(childrenLength);
        });
    }

    highlightChildren(parent);
}