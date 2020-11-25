$(document).ready(function () {
    $("#UsersTable").DataTable({
        "ajax": '../../Users/Select',
        columns: [
            { title: "no" },
            { title: "name" },
            { title: "userName" },
            { title: "email" }
        ]
    });

    $( "#UsersForm" ).on( "submit", function(e) {
        var dataString = $(this).serialize();
        alert("funciona " + dataString);
 
        $.ajax({
            type: "POST",
            url: "/User/Create",
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

