var Insertbutton = document.getElementById("Insertbutton");
var Inputuserinserttext = document.getElementById("Inputuserinserttext");
var Inputlijstbutton = documument.getElementById("Insertbuttonlijst");
var Inputlijst = documument.getElementById("Inputlijst");
var Inputupdatetduur = getElementById("Inputupdatetduur");
var Inputupdatetstatus = getElementById("Inputupdatetstatus");
var Inputupdatetsnaam = getElementById("Inputupdatetnaam");
var Inputupdatetbesch = getElementById("Inputupdatetbesch");


function Insertshow() {
    Inputuserinserttext.style.visibility = "visible"

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
        Id = Id, Naam = Naam, Status = Status, Duur = Duur, Besch = Besch

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