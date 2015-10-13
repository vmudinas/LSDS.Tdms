$(document).ready(function () {
        $("#idLoginB").on("click", function () {
            $("#PasswordChange").val(false);
        });
        $("#idPasswordChange").on("click", function () {
            $("#PasswordChange").val(true);
        });
    });