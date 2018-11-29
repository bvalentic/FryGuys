
function validateForm() {
    var errorString = "";

    errorString += validateFirstName();
    errorString += validateLastName();

    if (errorString.length >= 1) {
        alert(errorString);
        window.location.href = '@Url.Content("~/Home/Register/")';
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
