var formData = new FormData();
 
var modelId    ;
var markaId   ;

var currency  ;
var fuelType  ;
var banType  ;
var transmissions   ;
var speedTypeId  ;
var probeg  ;
var hpower  ;
var username ;
var email  ;
var telefonNumber  ;
var city  ;
var colorCar ;
var year  ;
var price  ;
var power ;
var note  ;
$(document).ready(function () {
     
    $(".checkNumber").click(function () {

    var phone = $("#phone").val();
        if (phone.length == 15) {
            $(".checkTelefon").hide("slow" );
            $(".createPost").css("visibility","visible")
        }
    $(".telefonNumber").val(phone)

    })
   
    

    $(".btnCreate").click(function () {
          formData = new FormData();
        var postType = 'false';
        GetValue();
        formData.append('postType', postType);
        Create();
        
    });
    $(".btnCreateVPN").click(function () {
        formData = new FormData();
        var postType = 'true';
        GetValue();
        formData.append('postType', postType);
        Create();
        
    });

})
function GetValue() {
    formData = new FormData();
    var  attachList = [];
      modelId = $(".modelMarka option:selected").val();
      markaId = $("#Marka option:selected").val();

      currency = $(".currency option:selected").val();
      fuelType = $(".fuelType option:selected").val();
      banType = $(".banType option:selected").val();
      transmissions = $(".transmissions option:selected").val();
      speedTypeId = $(".speedType option:selected").val();
      probeg = $(".probeg").val();
      hpower = $(".hPower").val();
      username = $(".username").val();
      email = $(".email").val();
      telefonNumber = $(".telefonNumber").val();
      city = $(".city option:selected").val();
      colorCar = $(".colorCar option:selected").val();
        year = $(".year option:selected").val();
      price = $(".price").val();
      power = $(".power option:selected").val();
      note = $(".note").val();
    var kredit = $(".kredit").is(":checked");
    var barter = $(".barter").is(":checked");

    var abs = $(".abs").is(":checked");
    var disk = $(".disk").is(":checked");
    var salon = $(".salon").is(":checked");
    var centralSistem = $(".centralSistem").is(":checked");
    var parkRadar = $(".parkRadar").is(":checked");
    var ksenon = $(".ksenon").is(":checked");
    var conditioner = $(".conditioner").is(":checked");
    var lyuk = $(".lyuk").is(":checked");
    
    $.each($('.fileImages')[0].files, function (i, file) {
        attachList.push(file.name)
        formData.append('file', file);
    });
    formData.append('modelId', modelId);
    formData.append('currencyId', currency);
    formData.append('fuelTypeId', fuelType);
    formData.append('banTypeId', banType);
    formData.append('transmissionsId', transmissions);
    formData.append('colorCarId', colorCar);
    formData.append('yearId', year);
    formData.append('price', price);
    formData.append('powerId', power);
    formData.append('note', note);
    formData.append('abs', abs);
    formData.append('disk', disk);
    formData.append('salon', salon);
    formData.append('centralSistem', centralSistem);
    formData.append('parkRadar', parkRadar);
    formData.append('ksenon', ksenon);
    formData.append('conditioner', conditioner);
    formData.append('lyuk', lyuk);
    formData.append('username', username);
    formData.append('cityId', city);
    formData.append('hpower', hpower);

    formData.append('email', email);
    formData.append('probeg', probeg);
    formData.append('kredit', kredit);
    formData.append('barter', barter);
    formData.append('speedTypeId', speedTypeId);



    formData.append('telefonNumber', telefonNumber);





}
function Create() {
    $message = ["Marka", "Model", "Valyuta", "Ban növü", "Rəng", "Yanacaq növü", "Ötürücü", "Sürətlər qutusu", "Buraxılış ili", "Mühərrikin həcmi"];
    $inputs = [markaId, modelId, currency, banType, colorCar, fuelType, transmissions, speedTypeId, year, power];
    $count = 0;
    $messageUser = ["Yürüş", "Qiymət", "Mühərrikin gücü", "Ətraflı", "Adınız", "E-mail", "Nömrə"]
    $inputUser = [probeg, price, note, hpower, username, email, telefonNumber]
    for (var i = 0; i < $inputs.length; i++) {

        if ($inputs[i] == 0) {
            $count = 1
            swal("Xeta!", `${$message[i]} xanası seçilməyib.`, "error");
            break;
        }

    }
    if ($count == 0) {
        for (var i = 0; i < $inputUser.length; i++) {
            if ($inputUser[i].toString().trim() == "") {
                $count = 1
                swal("Xeta!", `${$messageUser[i]} xanası boş ola bilməz!`, "error");
                break;
            }

        }
    }


    if ($count == 0) {
        $.ajax({
            type: 'POST',
            url: '/Form/Create',
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
                    swal("Xeta!", response.message, "error");
                }
            }
        });
    }
}