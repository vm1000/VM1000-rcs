// check's if paswords are same
function registration(){
    var firstInput = document.getElementById("password").value;
    var secondInput = document.getElementById("password-repeat").value;
    if (firstInput != secondInput){
       document.getElementById("password-repeat").value = '';
        alert('Ievadītās paroles nesakrīt');
    } else if (firstInput.length < 8 || secondInput.length < 8){
        alert('parolei jābūt vismaz 8 simboliem!');
    }
};

// alerts the name that user inputted and deletes last char if its "s"
function hello(){
    var clientName = document.getElementById("first-name").value;
    if (clientName.substr(clientName.length - 1) == "s"){
       clientName = clientName.substr(0, clientName.length -1);
       alert("Čau, " + clientName + "!" + " spied OK lai turpinātu!");
    } else
    {
    alert("Čau, " + clientName + "!") + " spied OK lai turpinātu!";
    }
};



// Activate Carousel
$("#myCarousel").carousel(2);

// Enable Carousel Indicators
$(".item").click(function(){
    $("#myCarousel").carousel();
});

// Enable Carousel Controls
$(".left").click(function(){
    $("#myCarousel").carousel("prev");
});

//chatBot
function chatFunction() {
    if (document.getElementById("chat-name").value == ''){
        alert ('Enter your name!');
    }
    else{
    var username = document.getElementById("chat-name").value;
    var coment = document.getElementById("message").value;
    var mainBox = document.getElementById("mainBox");
    var chatter = document.createElement("chatter");
    mainBox.appendChild(chatter);
    
    var strong = document.createElement("strong");
    strong.appendChild(document.createTextNode("USERNAME: " + username));
    chatter.appendChild(strong);

    var date = new Date();
    var span = document.createElement("span");
    span.appendChild(document.createTextNode("DATE: " + date));
    strong.appendChild(span);

    var div = document.createElement("div")
    div.appendChild(document.createTextNode("MESSAGE: " + coment));
    chatter.appendChild(div);
    
    document.getElementById("chat-name").value = '';
    document.getElementById("message").value = '';

    }
  }


function play3(){
    var audio3 = document.getElementById("sound3");
    if(audio3.paused){
        audio3.play();
    } else {
        audio3.pause();
    }
    
}


function play2(){
    var audio2 = document.getElementById("sound2");
    if(audio2.paused){
        audio2.play();
    } else {
        audio2.pause();
    }
}

function play1(){
    var audio1 = document.getElementById("sound1");
    if(audio1.paused){
        audio1.play();
    } else {
        audio1.pause();
    }
}