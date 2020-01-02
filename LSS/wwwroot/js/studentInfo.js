$("#studentEmail").blur(function () {
    val = this.value;
    if (!val.match(/^\w+@\w+\.\w+$/i)) {
        $(this).data({
            "s": 0
        });
        $("#emialError").show();
    } else {
        $(this).data({
            "s": 1
        });
        $("#emialError").hide();
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