function validate() {
    function validateUsername(username){
        let usernameRegex = new RegExp(/^[A-Za-z0-9]{3,20}$/);
        return usernameRegex.test(username);
    }

    function validatePassword(password){
        let passwordRegex = new RegExp(/^\w{5,15}$/);
        return passwordRegex.test(password);
    }

    function validateEmail(email){
        let emailRegex = new RegExp(/^.*\@.*\..*$/);
        return emailRegex.test(email);
    }

    let submitBtn = $("#submit");
    submitBtn.on("click", function(e){
        e.preventDefault();
        e.stopPropagation();
        let usernameField = $("#username");
        let passwordField = $("#password");
        let confirmPasswordField = $("#confirm-password");
        let emailField = $("#email");
        let companyNumberField = $("#companyNumber");

        let isUsernameValid = validateUsername(usernameField.val());
        if(!isUsernameValid){
            usernameField.attr("style", "");
            usernameField.css("border-color", "red");
        } else {
            usernameField.css("border", "none");
        }

        let doPasswordsMatch = passwordField.val() === confirmPasswordField.val();

        let isPasswordValid = validatePassword(passwordField.val());
        if(!isPasswordValid || !doPasswordsMatch){
            passwordField.attr("style", "");
            passwordField.css("border-color", "red");
        } else {
            passwordField.css("border", "none");
        }

        let isConfirmPasswordValid = validatePassword(confirmPasswordField.val());
        if(!isConfirmPasswordValid || !doPasswordsMatch){
            confirmPasswordField.attr("style", "");
            confirmPasswordField.css("border-color", "red");
        } else {
            confirmPasswordField.css("border", "none");
        }

        let isEmailValid = validateEmail(emailField.val());
        if(!isEmailValid){
            emailField.attr("style", "");
            emailField.css("border-color", "red");
        } else {
            emailField.css("border", "none");
        }

        let isCompanyFieldVisible = $("#companyInfo").css("display") !== "none";
        let isCompanyNumberValid = parseInt(companyNumberField.val()) > 1000 && parseInt(companyNumberField.val()) <= 9999;

        if(isCompanyFieldVisible){
            if(isCompanyNumberValid){
                companyNumberField.css("border", "none");
            } else {
                companyNumberField.attr("style", "");
                companyNumberField.css("border-color", "red");
            }
        }

        let validationDiv = $("#valid");

        if(isEmailValid && isConfirmPasswordValid && isPasswordValid && doPasswordsMatch && isUsernameValid){
            if(isCompanyFieldVisible){
                if(isCompanyNumberValid){
                    validationDiv.css("display", "");
                }
                else {
                    validationDiv.css("display", "none");
                }
            } else {
                validationDiv.css("display", "");
            }
        } else {
            validationDiv.css("display", "none");
        }
    });

    $("#company").on("click", function(e){
        let target = e.target;

        let companyInfoField = $("#companyInfo");
        if(target.checked === true){
            $(target).attr("checked", "checked");
            companyInfoField.attr("style", "");
        } else {
            $(target).attr("checked", "checked");
            companyInfoField.attr("style", "");
        }
    })
}