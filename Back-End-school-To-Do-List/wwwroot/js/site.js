var Insertbutton = document.getElementById("Insertbutton");
var Inputuserinserttext = document.getElementById("Inputuserinserttext");
var Inputuserdeletetext = document.getElementById("InputuserDeletetext");
var Inputuserupdatetext = document.getElementById("Inputuserupdatetext");

function Insertshow() {
    Inputuserinserttext.style.visibility = "visible"
    InputuserDeletetext.style.visibility = "Hidden"
}

function Deleteshow() {
    InputuserDeletetext.style.visibility = "visible"
    Inputuserinserttext.style.visibility = "Hidden"
}