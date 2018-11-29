
function myFunction() {
    var x = document.getElementById("myText").value;
    document.getElementById("demo").innerHTML = x;
}

function validateForm() {
    var noError = true;
    noError = validateFirstName();
}

function validateFirstName() {
    var testName = document.getElementById('firstName');
    var firstName = document.getElementById("firstName").value;
    var regEx = new RegExp(/[A-Za-z]+[\s][A-Za-z]+/);
    if (firstName !== null) {
        alert('Hi, ' + firstName)
    };
    if (regEx.lastIndex !== null) {
        alert('non-letter found')
        return false;
    };
}