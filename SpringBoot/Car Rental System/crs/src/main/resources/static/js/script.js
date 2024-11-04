// document.getElementById("login-form").addEventListener("submit", function (e) {
//     e.preventDefault();

//     const username = document.getElementById("username").value;
//     const password = document.getElementById("password").value;


//     if (username === "a" && password === "a") {
//         window.location.href = "index.html";
//     } else {
//         alert("Hibás felhasználónév vagy jelszó. Próbáld újra.");
//     }
// });

const carousel = new bootstrap.Carousel(document.getElementById('carouselExampleIndicators'), {
    interval: 0, // A Carousel áttűnési ideje 0 milliszekundumban (nincs automatikus mozgás)
});
    const szuroTorlesButton = document.getElementById('szurotorles');

    const tipusRadioButtons = document.querySelectorAll('#tipus input[type="radio"]');
    const valtasCheckboxes = document.querySelectorAll('#valtas input[type="checkbox"]');
    const fogyasztasRadioButtons = document.querySelectorAll('#fogyasztas input[type="radio"]');

    szuroTorlesButton.addEventListener('click', function() {
        tipusRadioButtons.forEach(radio => {
            radio.checked = false;
        });
        valtasCheckboxes.forEach(checkbox => {
            checkbox.checked = false;
        });
        fogyasztasRadioButtons.forEach(radio => {
            radio.checked = false;
        });
    });

    
document.getElementById("reszletek1").addEventListener("click", function() {
    document.getElementById("reszletekModal").style.display = "block";
});

document.getElementsByClassName("close")[0].addEventListener("click", function() {
    document.getElementById("reszletekModal").style.display = "none";
});

