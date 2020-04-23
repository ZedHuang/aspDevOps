var globData = null;
var globFeedbck = null;
var temp = 0;
//cannot use cont fr connurl as it will use multiple times as global scope, hence treat like multiple declarations
var awsLink = "a403d13aac6e3464d9ef2e671c57b188-396402673.us-east-1.elb.amazonaws.com";
var connUrl = "http://"+awsLink+":8080";



//toggle functionality
function showEdit(){
    var dv = document.getElementById("editPlaylist");
    if(dv.style.display==="none"){
        dv.style.display = "block";
    }else{
        dv.style.display = "none";
    }
}
function showAdd(){
    var dv = document.getElementById("addPlaylist");
    if(dv.style.display==="none"){
        dv.style.display = "block";
    }else{
        dv.style.display = "none";
    }
}



/*
function sendEmail(email) {
    let str = "Respond to:\n" + email;
    var res = window.prompt(str, "");
    if (res === null || res === "") {
        alert("you cancelled send");
    } else {
        let resp = {
            "email": email,
            "response": res
        };
        $.ajax({
            type: "POST",
            url: '@Url.Action("Home", "Email")',
            contentType: "application/json; charset=utf-8",
            data: resp,
            dataType: "json",
            success: function (result) {
                alert("Email sent");
            },
            error: function () {
                alert("Internal server issue could not send email");
            }
        });
    }
}
*/


     /*
    let str = "Respond to:\n" + email;
    var res = window.prompt(str,"");
    if(res === null || res === ""){
        alert("you cancelled send");
    }else{
        let resp = {
            "email" : email,
            "response" : res
        };
        const entrypoint = connUrl + "/sendEmail";
        fetch(entrypoint, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(resp)
        })
        .then((response) => {
            if (response.ok) {
                alert("Email sent");
            }
        })
        .catch((error) => {
            alert("Internal server issue could not send email");
         });
    }
    */
