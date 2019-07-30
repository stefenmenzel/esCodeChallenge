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
        let versionInput = $("#versionInput").val();
        console.log('event', e);
        console.log('version input value', versionInput);
        let splitString = versionInput.split(".", 3);
        console.log("split up string is:", splitString);
        
        if($("#versionInput").val() === ''){
            $.ajax({
                url: `/api/version`,
                method: "Get",
                contentType: "application/json",
                accepts: "application/json",
                success: function(data){
                    listVersions(data);
                }
            });
        }
        else{
            $.ajax({
                url: `/api/version/${$("#versionInput").val()}`,
                method: "Get",
                contentType: "application/json",
                accepts: "application/json",
                success: function(data){
                    listVersions(data);
                }
            });
        }
        
    });
}

function submitVersion(event){
    event.preventDefault();
    console.log('ya done submitted');
}

function listVersions(data){
    console.log("all stuff retrieved:", data);
    $("#versionList").empty();

    $.each(data, function(key, item){
        const li = $("<li></li>")
            .append(`Software Name: ${item.name} Version: ${item.version}`);

        li.appendTo($("#versionList"));
    });
}