// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", () => {
    var aboutBox = document.getElementById("About-box");
    aboutBox.addEventListener("click", hideAboutBox);
})

function hideAboutBox() {
    var aboutBox = document.getElementById("About-box");
    aboutBox.style.display = "none";
}
