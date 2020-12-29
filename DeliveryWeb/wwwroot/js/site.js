// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var WhiteBacground = document.getElementById("WhiteBacground");

      
        WhiteBacground.onclick = function () {
            if (sideNav.style.left == "-200px") {
                sideNav.style.left = "0";
                menu.style.display = "none";
                cancle.style.left = "200px";

            }
            else {
        sideNav.style.left = "-250px";
                menu.style.display = "block";
                cancle.style.left = "-200px";
                navbarDropdown.style.marginBottom = "-10px";
                navbarDropdown.style.transition = "0.1s";
            }
        }
    