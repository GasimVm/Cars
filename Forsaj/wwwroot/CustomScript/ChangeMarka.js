$(document).ready(function () {
    $("#Marka").change(function () {
        var MarkaId = $(this).val();
        $("#Model option").each(function (j, value) {
            $(this).attr("hidden", true)
        })
        $("#Model option").each(function (j, value) {
            if (value.attributes[1].nodeValue == MarkaId) {
                $(this).removeAttr("hidden")
            }
            });
    });

});