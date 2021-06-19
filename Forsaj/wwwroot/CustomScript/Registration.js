$(document).ready(function () {

   
    $(".registration").click(function () {
        var formData = new FormData();
        var username = $(".username").val();
        var email = $(".email").val();
        var password = $(".password").val();
        var phoneNumber = $(".phoneNumber").val();
        var rules = $(".rules").prop("checked");

        
        if (rules) {

            formData.append('Username', username);
            formData.append("Password", password);
            formData.append("Email", email);
            formData.append("PhoneNumber", phoneNumber);


            $.ajax({
                type: 'POST',
                url: '/Account/Registration',
                data: formData,
                processData: false,
                contentType: false,
                success: function (response) {
                    if (response.status === "success") {

                         
                        swal("Əla!", response.message, "success");
                        setInterval(function () {
                            window.location.href = document.referrer;;
                        }, 1000);
                    }
                    else {
                        
                        swal("Xəta!", response.message, "error");
                    }
                }
            });


        } else {
            swal("Xəta!", response.message, "error");
        }
    })

    $(".login").click(function () {
        var formData = new FormData();
        var email = $(".email").val();
        var password = $(".password").val();

        formData.append("Password", password);
        formData.append("Email", email);
        $.ajax({
            type: 'POST',
            url: '/Account/Login',
            data: formData,
            processData: false,
            contentType: false,
            success: function (response) {
                if (response.status === "success") {
                    setInterval(function () {
                        window.location.href = document.referrer;;
                    }, 1000);
                }
                else {
                    alert(response.status)
                }
            }
        });
    })
})