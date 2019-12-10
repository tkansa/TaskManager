// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function toggleTaskCompletedCheckbox(id) {
    var checkBoxStatus = document.getElementById(id).checked;
    var url = "/TaskModels/ToggleTaskCompletedCheckbox";
    $.get(url, { id: id, checkBoxStatus: checkBoxStatus });
}
