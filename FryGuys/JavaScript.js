
function validateForm() {
    var noError = true;
    var errorString = "";
    errorString += validateFirstName(noError);
    if (noError) {

    }
    else {

    }
}

function validateFirstName(noError) {
    var firstName = document.getElementById("firstName").value;
    var regEx = /[\W]*[\d]*[\W]*/;

    if (regEx.test(firstName)) {
        alert('non-letter found')
        noError = false;
        return "First name entry invalid. \n"
    };
}


