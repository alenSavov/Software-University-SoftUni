function printLines(input){
   for(let line of input){
       if(line !== "Stop"){
           console.log(line);
       }
       else{
           return;
       }
   }
}

printLines(['Line 1', 'Line 2', 'Line 3', 'Line 3', 'Stop']);