var amountoftimesclicked = 0;
document.getElementById("buttonid").onclick =
    function () {
        amountoftimesclicked = amountoftimesclicked + 1;
        if (amountoftimesclicked <= 5) {
            var values = ["test1", "test2", "test3"];
            //replace above with code below inside script tag
            //var values = [];
            //@foreach(var item in Model.GenerateDropDownDataFromWhiskeyForJavascript)
            //{
            //    @: values.push("@item");
            //}
            var firstdiv = document.createElement("div");
            var seconddiv = document.createElement("div");
            var textboxvalue = document.createElement("input");
            textboxvalue.name = "amountofbottles" + amountoftimesclicked.toString();
            var select = document.createElement("select");
            select.name = "whiskey" + amountoftimesclicked.toString();
            for (var _i = 0, values_1 = values; _i < values_1.length; _i++) {
                var val = values_1[_i];
                var option = document.createElement("option");
                option.value = val;
                option.text = val.charAt(0).toUpperCase() + val.slice(1);
                select.appendChild(option);
            }
            var label = document.createElement("label");
            var labelinput = document.createElement("label");
            label.innerHTML = "Whiskey ";
            labelinput.innerHTML = "Amount of bottles ";
            seconddiv.appendChild(labelinput).appendChild(textboxvalue);
            seconddiv.classList.add("form-group");
            firstdiv.appendChild(label).appendChild(select);
            firstdiv.classList.add("form-group");
            document.getElementById("appendtothis").prepend(seconddiv);
            document.getElementById("appendtothis").prepend(firstdiv);
            // firstdiv.id = "divid"
            //seconddiv.appendChild(firstdiv);
            //seconddiv.classList.add("col-md-offset-2", "col-md-10");
            //var appenditem = document.getElementById("appendtothis").cloneNode;
            //var basediv = document.createElement("div")
            //var inputelement = document.createElement("input");
            //basediv.appendChild(inputelement);
            //appenditem.appendChild(basediv);
        }
        else {
            alert("Maximum allowed whiskey's per person is 5");
        }
    };
//# sourceMappingURL=AddViewModelWhiskey.js.map