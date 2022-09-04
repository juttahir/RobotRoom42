// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var doShowError = @ViewBag.ShowError.ToString().ToLower();

$(document).ready(function () {
    $('#btnSubmit').click(showError);

    $('#linkClose').click(function () {
        $('#errorAlert').hide('fade');
    });

    // show the error
    if (doShowError) {
        showError();
    }
});