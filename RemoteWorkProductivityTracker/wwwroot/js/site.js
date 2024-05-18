// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function openNav(value) {
    document.getElementById("mySidebar").style.width = "250px";
   
    document.getElementById("inner_side_bar_text").textContent = value;
}

function closeNav() {
    document.getElementById("mySidebar").style.width = "0";
    
}