var Insertbutton = document.getElementById("Insertbutton");
var Inputuserinserttext = document.getElementById("Inputuserinserttext");
var Inputuserdeletetext = document.getElementById("InputuserDeletetext");
var Inputuserupdatetext = document.getElementById("InputuserUpdatetext");
var Inputlijstbutton = documument.getElementById("Insertbuttonlijst");
var Inputlijst = documument.getElementById("Inputlijst");


function Insertshow() {
    Inputuserinserttext.style.visibility = "visible"
    InputuserDeletetext.style.visibility = "Hidden"
    Inputuserupdatetext.style.visibility = "Hidden"
}
function Insertlist(){
    Inputlijst.style.visibility = "Visible"
}
//function Deleteshow() {
//    InputuserDeletetext.style.visibility = "visible"
//    Inputuserinserttext.style.visibility = "Hidden"
//    Inputuserupdatetext.style.visibility = "Hidden"
//}
//function Updateshow() {
//    InputuserDeletetext.style.visibility = "Hidden"
//    Inputuserinserttext.style.visibility = "Hidden"
//    Inputuserupdatetext.style.visibility = "visible"
//}