$("#repassword").blur(function () {
    val1 = $("#password").val();
    val2 = this.value;
    if (val1 != val2) {
        $(this).data({
            "s": 0
        });
        $("#pwdError").show();
    } else {
        $(this).data({
            "s": 1
        });
        $("#pwdError").hide();
    }
});


$("form").submit(function () {
    $(".auth").blur();
    tot = 0;
    $(".auth").each(function () {
        tot += $(this).data("s");
    });
    if (tot != 1) {
        return false;
    } else {
        return true;
    }
});