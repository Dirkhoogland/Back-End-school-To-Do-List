var Insertbutton = document.getElementById("Insertbutton");
var Inputuserinserttext = document.getElementById("Inputuserinserttext");
var Inputlijst = document.getElementById("Inputlijst");
var Inputupdatetduur = document.getElementById("Inputupdatetduur");
var Inputupdatetstatus = document.getElementById("Inputupdatetstatus");
var Inputupdatetsnaam = document.getElementById("Inputupdatetnaam");
var Inputupdatetbesch = document.getElementById("Inputupdatetbesch");


function Insertshow() {
    Inputuserinserttext.style.visibility = "visible"
    Inputlijst.style.visibilisty = 'Visible'

}
function Insertlist(){
    Inputlijst.style.visibility = "Visible"
}


function updatestart() {
    Inputupdatetduur.style.visibility = "Visible"
    Inputupdatetstatus.style.visibility = "Visible"
    Inputupdatetsnaam.style.visibilisty = "Visible"
    Inputupdatetbesch.style.visibility = "Visible"
}
function confirmUpdate(Id, Naam, Status, Duur, Besch)
{
    var tasklist =
    {
        'Id': Id,
        'Naam': Naam,
        'Status': Status,
        ' Duur' : Duur,
         'Besch' : Besch
    }
    $.ajax({
        type: "Post",
        dataType: "Json",
        url: 'Updatetask',
        data: JSON.stringify(tasklist),
        contentType: "application/json",
        success: function () { console.log(Id); },
        Error: function (a, b, c) { console.log(a); console.log(b); console.log(c); }
    });
}

function startDelete(Id)
{
    $.ajax({
        type: "Post",
        dataType: "Json",
        url: 'Deletetask',
        data: JSON.stringify(Id),
        contentType: "application/json",
        success: function () { console.log(Id); },
        Error: function (a, b, c) { console.log(a); console.log(b); console.log(c); }
    });
}

function updatestart() {
    Inputupdatetnaam.style.visibility = "visible"
    Inputupdatetbesch.style.visibility = "visible"
    Inputupdatetstatus.style.visibility = "visible"
    Inputupdatetduur.style.visibility = "visible"
}