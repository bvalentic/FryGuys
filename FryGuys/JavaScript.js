
function validateForm() {
    var numError = 0;

    numError += validateFirstName();
    numError += validateLastName();
    numError += validateEmail();
    numError += validatePhone();
    numError += validatePassword();

    if (numError > 0) {
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
        document.getElementById("firstNameError").classList.remove("hidden");
        return 1;
    }
    else {
        document.getElementById("firstNameError").classList.add("hidden");
        return 0;
    }
}

function validateLastName() {
    var lastName = document.getElementById("lastName").value;
    var regEx = /[^a-zA-Z]+/;

    if (regEx.test(lastName)) {
        document.getElementById("lastNameError").classList.remove("hidden");
        return 1;
    }
    else {
        document.getElementById("lastNameError").classList.add("hidden")
        return 0;
    }
}

function validateEmail() {
    var email = document.getElementById("email").value;
    var regEx = /^([a-zA-Z0-9_\-\.]+)\@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$/;

    if (!regEx.test(email)) {
        document.getElementById("emailError").classList.remove("hidden");
        return 1
    }
    else {
        document.getElementById("emailError").classList.add("hidden");
        return 0;
    }
}

function validatePhone() {
    var phone = document.getElementById("phone").value;
    var regEx = /[\d]{3}-[\d]{3}-[\d]{4}/;
    if (!regEx.test(phone)) {
        document.getElementById("phoneError").classList.remove("hidden");
        return 1
    }
    else {
        document.getElementById("phoneError").classList.add("hidden");
        return 0;
    }
}

function validatePassword() {
    var password = document.getElementById("password").value;
    var passwordConfirm = document.getElementById("passwordConfirm").value;
    var regEx = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/;
    var numError = 0;

    if (!regEx.test(password) && password.length >= 8) {
        document.getElementById("passwordError").classList.remove("hidden");
        numError += 1;
    }
    else if (!(!regEx.test(password) && password.length >= 8)) {
        document.getElementById("passwordError").classList.add("hidden");
    }

    if (password.length < 8) {
        document.getElementById("passwordLengthError").classList.remove("hidden");
        numError += 1;
    }
    else if (!(password.length < 8)) {
        document.getElementById("passwordLengthError").classList.add("hidden");       
    }

    if (password !== passwordConfirm) {
        document.getElementById("passwordMatchError").classList.remove("hidden");
        numError += 1;
    }
    else if (!(password !== passwordConfirm)) {
        document.getElementById("passwordMatchError").classList.add("hidden");
    }
    return numError;
}

function GetValues() {
    var potato = findValue(".potato");
    var cut = findValue(".cut");
    var cook = findValue(".cook");

    alert("Potato: " + potato +"\nCut: " + cut + "\nCook: " + cook);
}

function findValue(string) {
    var classesNodeList = document.querySelectorAll(string);
    var checkedValue;

    for (var i = 0; i < classesNodeList.length; i++) {
        if (classesNodeList[i].checked == true) {
            checkedValue = classesNodeList[i].value;
        }
    }

    return checkedValue; 
}

function confirmChanges() {
    if (confirm("Click OK to confirm:")) {
        return true;
    }
    else {
        return false;
    }
}

function disableSeasoning() {
    if (document.getElementById("SeasonNone").checked === true) {
        document.getElementsByClassName("Season").checked = false;
        document.getElementById("Season").disabled = true;
    }
}