
function validateForm() {
    var errorString = "";

    errorString += validateFirstName();
    errorString += validateLastName();
    errorString += validatePassword();

    if (errorString.length >= 1) {
        alert(errorString);
        return false;
    }
    else {
        return true;
    }
    
}

function validateFirstName() {
    var firstName = document.getElementById("firstName").value;
    var regEx = /[^a-zA-Z]+/;

    if (regEx.test(firstName)) {
        return "First name entry invalid. \n";
    }
    else {
        return "";
    }
}

function validateLastName() {
    var lastName = document.getElementById("lastName").value;
    var regEx = /[^a-zA-Z]+/;

    if (regEx.test(lastName)) {
        return "Last name entry invalid. \n";
    }
    else {
        return "";
    }
}

function validatePassword() {
    var password = document.getElementById("password").value;
    var passwordConfirm = document.getElementById("passwordConfirm").value;
    var errorString = "";

    if (/[^a-z]/.test(password) || /[^A-Z]/.test(password) || /[^0-9]/.test(password)) {
        errorString += "Password does not follow proper format. \n"
    }

    if (password.length < 8) {
        errorString += "Password less than 8 characters. \n";
    }

    if (password !== passwordConfirm) {
        errorString += "Passwords do not match. \n";
    }
    return errorString;
}
