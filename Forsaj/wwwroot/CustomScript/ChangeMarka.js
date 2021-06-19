$(document).ready(function () {
    $("#Marka").change(function () {
        var MarkaId = $(this).val();
         
        $("#Model option").each(function (j, value) {
            $(this).attr("hidden", true)
        })


        $("#Model option").each(function (i, val) {
            
            if (val.attributes[1].nodeValue == MarkaId) {
                 
                $(this).removeAttr("hidden")
                $(this).attr("hidden", false)
            }
            });
    });

});