function prikaziCijenu() {
    var cijenaDiv = document.getElementById('cijenaTextbox');
    var cijenaCheckbox = document.getElementById('cijenaCheckbox');

    if (cijenaCheckbox.checked) {
        cijenaDiv.classList.remove("hidden");
    }
    else
        cijenaDiv.classList.add("hidden");
}