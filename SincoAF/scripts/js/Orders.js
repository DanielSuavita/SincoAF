$(document).ready(function () {
    $("#OrdersTable").DataTable({
        "ajax": '../../Order/Select',
        columns: [
            { title: "no" },
            { title: "concept" },
            { title: "createdAt" },
            { title: "imported" },
            { title: "completed" }
        ]
    });
    let ProductsOrderTable = $("#ProductsOrderTable").DataTable();
    
    $("#AddRowBtn").on("click", function () {
        ProductsOrderTable.row.add([
            $("#productid").val(),
            $("#quantity").val()
        ]);
    });

    $("#createdat").datepicker();
    //$("#productid").selectmenu();

    var availableTags = [
      "ActionScript",
      "AppleScript",
      "Asp",
      "BASIC",
      "C",
      "C++",
      "Clojure",
      "COBOL",
      "ColdFusion",
      "Erlang",
      "Fortran",
      "Groovy",
      "Haskell",
      "Java",
      "JavaScript",
      "Lisp",
      "Perl",
      "PHP",
      "Python",
      "Ruby",
      "Scala",
      "Scheme"
    ];
    $("#productid").autocomplete({
        source: availableTags
    });
});


$( "#OrdersForm" ).on( "submit", function(e) {
 
    var dataString = $(this).serialize();
     
    // alert(dataString); return false;
 
    $( "#UsersForm" ).on( "submit", function(e) {
        var dataString = $(this).serialize();
        alert("funciona " + dataString);
 
        $.ajax({
            type: "POST",
            url: "/Order/Create",
            data: dataString,
            success: function () {
                alert("Orden Creada");
            },
            error: function () {
                alert("No Funciona");
            }
        });
 
        e.preventDefault();
    });
 
    e.preventDefault();
});
