function AbrirModal(m){
    let Modal = document.getElementById(m);
    Modal.style.display = "flex"; 
    setTimeout(function () {
        Modal.style.opacity = 1;
    }, 20);
}
function FecharModal(m){
    let Modal = document.getElementById(m);
    Modal.style.opacity = 0;
    setTimeout(function () {
        Modal.style.display = "none"; 
    }, 500);
}


function AbrirMenu(m,b) {
    let Modal = document.getElementById(m);
    let Button = document.getElementById(b);
    Modal.style.display = "block";
    Button.style.display = "none"
    setTimeout(function () {
        Modal.style.opacity = 1;
    }, 20);
}
function FecharMenu(m, b) {
    let Modal = document.getElementById(m);
    let Button = document.getElementById(b);

    Modal.style.opacity = 0;
    Button.style.display = "flex";
    setTimeout(function () {
        Modal.style.display = "none";
    }, 500);
}
