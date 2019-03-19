(function solve(){
    String.prototype.ensureStart = function(str){
        if(!this.startsWith(str)){
            let tempStr = this;
            tempStr = str + tempStr;
            return tempStr;
        }
        return this.toString();
    }

    String.prototype.ensureEnd = function(str){
        if(!this.endsWith(str)){
            let tempStr = this;
            tempStr = tempStr + str;
            return tempStr;
        }

        return this.toString();
    }

    String.prototype.isEmpty = function(){
        if(this.length === 0){
            return true;
        } else {
            return false;
        }
    }

    String.prototype.truncate = function(n){
        if(this.toString().length <= n){
            return this.toString();
        }

        if(n < 4){
            let resultStr = ".".repeat(n);
            return resultStr;
        }

        let stringChunk = this.substr(0, n).trim();

        if(stringChunk.includes(" ")){
            let lastSpaceIndex = stringChunk.lastIndexOf(" ");
            let tempStr = stringChunk.substring(0, lastSpaceIndex) + "...";
            return tempStr;
        } else {
            let tempStr = stringChunk.toString();
            tempStr = tempStr.substring(0, n - 3);
            tempStr = tempStr + "...";

            return tempStr;
        }

    }

    String.format = function(string){
        let tempStr = string;
        let tempArguments = arguments;
        let tempParameters = Array.from(tempArguments).slice(1, Array.from(tempArguments).length);

        Array.from(tempParameters).forEach((p, index) => {
            let parameter = "{" + index.toString() + "}";
            if(tempStr.includes(parameter)){
                tempStr = tempStr.replace(parameter, p);
            }
        });

        return tempStr;
    }
})();