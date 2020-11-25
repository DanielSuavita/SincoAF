$(document).ready(function () {
    $("#OrdersTable").DataTable();
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


$( "form" ).on( "submit", function(e) {
 
    var dataString = $(this).serialize();
     
    // alert(dataString); return false;
 
    $.ajax({
        type: "POST",
        url: "bin/process.php",
        data: dataString,
        success: function () {
            $("#contact_form").html("<div id='message'></div>");
            $("#message")
              .html("<h2>Contact Form Submitted!</h2>")
              .append("<p>We will be in touch soon.</p>")
              .hide()
              .fadeIn(1500, function () {
                  $("#message").append(
                    "<img id='checkmark' src='images/check.png' />"
                  );
              });
        }
    });
 
    e.preventDefault();
});
});