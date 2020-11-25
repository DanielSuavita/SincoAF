$(document).ready(function () {
    $("#UsersTable").DataTable();

    $( "#UsersForm" ).on( "submit", function(e) {
        var dataString = $(this).serialize();
        alert("funciona " + dataString);
        // alert(dataString); return false;
 
        $.ajax({
            type: "POST",
            url: "/User/CreateUser",
            data: dataString,
            success: function () {
                alert("Funciona");
            },
            error: function () {
                alert("No Funciona");
            }
        });
 
        e.preventDefault();
    });
});

