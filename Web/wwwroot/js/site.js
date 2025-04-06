document.addEventListener("DOMContentLoaded", function () {
    const togglePassword = document.querySelector("#togglePassword");
    const password = document.querySelector("#password");
    console.log(togglePassword);
    if(togglePassword != null){
    togglePassword.addEventListener("click", function () {
        
        const type = password.getAttribute("type") === "password" ? "text" : "password";
        password.setAttribute("type", type);

        this.classList.toggle("bi-eye");
    });
    }

    document.querySelectorAll('.toggle-password-icon').forEach(icon => {
        icon.addEventListener('click', function () {
            const input = this.previousElementSibling;
            if (input.type === 'password') {
                input.type = 'text';
                this.classList.remove('bi-eye-slash');
                this.classList.add('bi-eye');
            } else {
                input.type = 'password';
                this.classList.remove('bi-eye');
                this.classList.add('bi-eye-slash');
            }
        });
    });
});

function addUser() {
    window.location.href = 'add-user.html';
}
function backToUsers() {
    window.location.href = 'users.html';
}
function editUser() {
    window.location.href = 'edit-user.html'
}

