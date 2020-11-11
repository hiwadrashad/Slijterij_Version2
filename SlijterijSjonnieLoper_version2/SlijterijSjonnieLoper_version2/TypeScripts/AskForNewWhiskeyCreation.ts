document.getElementById("buttonid").onclick =
    function () {
        if (confirm("Will je nog een whiskey toeovoegen?")) {
            var CreateSingle = document.getElementById("buttonid2").click();
            // $.post('@Url.Action("Login", "Login")')
            // var hidden = document.getElementById("AddAnotherWhiskey");
            // hidden.value = "Ja";
            // window.location.href = ''
        }
        else {
            var CreateSingle = document.getElementById("buttonid3").click();
            //   var hidden = document.getElementById("AddAnotherWhiskey");
            //   hidden.value = "Nee";
        }
    }