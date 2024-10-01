$("#form2").submit(fun1);

function fun1(event) {

    if ($("#form2").valid() == true) {

        var temp = $("#RegisterEmail").val();

        var userdata = {
            "FirstName": $("#FirstName").val(),
            "LastName": $("#LastName").val(),
            "RegisterEmail": $("#RegisterEmail").val(),
            "Mobile": $("#Mobile").val(),
            "RegisterPassword": $("#RegisterPassword").val(),
            "DateOfBirth": $("#DateOfBirth").val(),
            "Gender": $("#Gender").val()
        };

        var address = "/api/Users";

        var t = "POST";

        $.ajax({
            url: address,
            type: t,
            data: userdata,
            success: function(response) {
                //alert(response);
                if (response == "Successfully Registered") {
                    window.location = "/Home/MainPage?Username=" + temp;
                }
            },
            error: fun3
        });
    }

    event.preventDefault();
}



function fun3(xhr) {
    alert(xhr.responseText);
}

/***** Code for login *********/

$("#form1").submit(fun4);

function fun4(event) {

    if ($("#form1").valid() == true) {

        var userdata = {
            "EmailToCheck": $("#LoginEmail").val(),
            "PasswordToCheck": $("#LoginPassword").val()
        };

        var address = "/api/Users";

        var t = "GET";

        $.ajax({
            url: address,
            type: t,
            data: userdata,
            success: fun5,
            error: fun6
        });
    }

    event.preventDefault();
}

function fun5(response) {
    //alert(response);
    if (response == "Valid login") {
        window.location = "/Home/MainPage?Username=" + $("#LoginEmail").val();
    }
    else
    {
        alert(response);
    }
}

function fun6(xhr) {
    alert(xhr.responseText);
}
