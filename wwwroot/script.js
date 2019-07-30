$(document).ready(function() {
    console.log('jquery initialized');
    documentReady();
})

function documentReady(){
    formSubmit();
}

function formSubmit(){
    $("#versionButton").on("click",function (e) {
        e.preventDefault();    
        console.log('event', e);
        console.log('version input value', $("#versionInput").val());
        alert("doing something");
    });
}

function submitVersion(event){
    event.preventDefault();
    console.log('ya done submitted');
}