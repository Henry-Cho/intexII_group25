// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// used for the calculating pages so it can be in float formatting
function ChangeCheckIntoFloat(name, id) {
    var check = document.getElementsByName(name);
    if (check[0].checked) {
        var hiddenInput = document.getElementById(id);
        hiddenInput.value = 1;
    }
    else {
        var hiddenInput = document.getElementById(id);
        hiddenInput.value = 0;
    }

}
// used for the calculating pages so it can be in float formatting
function ChangeSelectIntoFloat(id) {
    var select = document.getElementById(id);
    for (i = 0; i < select.length; i++) {
        if (select.options[i].value == select.options[select.selectedIndex].value) {
            if (select.options[i].value != "Default") {
                var hidden = document.getElementById(select.options[i].value);
                hidden.value = 1;
            }
        }
        else {
            if (select.options[i].value != "Default") {
                var hidden = document.getElementById(select.options[i].value);
                hidden.value = 0;
            }
        }
    }

}