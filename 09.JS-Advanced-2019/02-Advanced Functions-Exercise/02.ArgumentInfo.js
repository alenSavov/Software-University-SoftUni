function solve(){
    let resultObj = {};

    Array.from(arguments)
        .forEach((el) => {
            let type = typeof(el);
            if(typeof(el) === "undefined"){
                console.log(typeof(el) + ": undefined");
                if(resultObj[typeof(el)] === undefined){
                    resultObj[typeof(el)] = 0;
                }
                resultObj[typeof(el)]++;
            }else {
                console.log(typeof(el) + ": " + el.toString());

                if(resultObj[typeof(el)] === undefined){
                    resultObj[typeof(el)] = 0;
                }
                resultObj[typeof(el)]++;
            }
        });

    Object.keys(resultObj).sort((a, b) => resultObj[b] - resultObj[a]).forEach((key) => {
        console.log(key + " = " + resultObj[key]);
    });
}

solve(
    42, 'cat', [], undefined
)