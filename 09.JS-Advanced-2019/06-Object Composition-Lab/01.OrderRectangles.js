function solve(inputArr){
    let rectangles = Array.from(inputArr).map((el) => {
        let width = parseInt(el[0]);
        let height = parseInt(el[1]);

        let rectangleObj = {
            width: width,
            height: height,
            area: function() {
                return width * height;
            },
            compareTo: function(otherArea){
                if(parseInt(this.area()) > parseInt(otherArea)){
                    return 1;
                } else if (parseInt(this.area()) === parseInt(otherArea)){
                    return 0;
                } else {
                    return -1;
                }
            }
        }

        return rectangleObj;
    });

    rectangles = Array.from(rectangles).sort((a, b) => {
        if(b.area() > a.area()) return 1;
        if(a.area() > b.area()) return -1;
        if(b.width > a.width) return 1;
        if(b.width < a.width) return -1;
        return 0;
    });

    return rectangles;
}

solve([[10,5],[5,12]])