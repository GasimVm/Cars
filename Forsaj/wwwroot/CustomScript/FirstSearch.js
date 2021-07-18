$(document).ready(function () {

    $(".btnFirstSearch").click(function () {
        var formData = new FormData();
        var markaId = $("#Marka option:selected").val();
        var modelId = $("#Model option:selected").val();
        var countryId = $("#Country option:selected").val()
        var cityId = $("#City option:selected").val()
        var priceMax = $(".priceMax").val()
        var priceMin = $(".priceMin").val()
        var yearMax = $(".yearMax").val()
        var yearMin = $(".yearMin").val()
        formData.append('markaId', markaId);
        formData.append('modelId', modelId);
        formData.append('countryId', countryId);
        formData.append('priceMax', priceMax);
        formData.append('priceMin', priceMin);
        formData.append('cityId', cityId);
        formData.append('yearMax', yearMax);
        formData.append('yearMin', yearMin);


        $.ajax({
            type: 'POST',
            url: '/Search/FirstSearch',
            data: formData,
            processData: false,
            contentType: false,
            success: function (response) {
                if (response.status === "success") {
                    $(".ana").html("");
                    $(".ana").append(response.message)

                }
                else {
                    swal("Xeta!", response.message, "error");
                }
            }
        });

    });
   
   
})