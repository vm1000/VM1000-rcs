function flappyFunc() {
var cvs = document.getElementById("canvas");
var ctx = cvs.getContext("2d");

var bird = new Image();
var bg = new Image();
var fg = new Image();
var pipeUp = new Image();
var pipeBottom = new Image();

bird.src = "img/flappy_bird_bird.png";
bg.src = "img/flappy_bird_bg.png";
fg.src = "img/flappy_bird_fg.png";
pipeUp.src = "img/flappy_bird_pipeUp.png";
pipeBottom.src = "img/flappy_bird_pipeBottom.png";


// skaņa
var fly = new Audio();
var score_audio = new Audio();

fly.src = "audio/fly.mp3";
score_audio.src = "audio/score.mp3";


var gap = 90;

//nospieot kko putns uzlido
document.addEventListener("keydown", moveUp);

function moveUp() {
    //ypos -= 40;
    jump=true;
    pre_jump_pos=ypos;
    fly.play();
}


// bloku veidošana
var pipe = [];
pipe [0] = {
    x :cvs.width,
    y: 0
}


//putna pozicijas
var xpos = 10;
var ypos = 150;
var grav = 2.8;
var score = 0;
var jump = false;
var pre_jump_pos=ypos;

function draw(){
    ctx.drawImage(bg, 0, 0);

    for(var i = 0; i < pipe.length; i++) {
        ctx.drawImage(pipeUp, pipe[i].x, pipe[i].y);
        ctx.drawImage(pipeBottom, pipe[i].x, pipe[i].y + pipeUp.height + gap);

        pipe[i].x --;

        if(pipe[i].x == 100){
            pipe.push({
                x : cvs.width,
                y : Math.floor(Math.random() * pipeUp.height) - 
            pipeUp.height
            })
        }

        if(xpos + bird.width >= pipe[i].x
        && xpos <= pipe[i].x + pipeUp.width
        && (ypos <= pipe[i].y + pipeUp.width
            || ypos + bird.height >= pipe[i].y + pipeUp.height +
              gap) || ypos + bird.height >= cvs.height - fg.height)

              {
            
                alert("jūsu rezultāts: " + score);
                reload();
            }

        if(pipe[i].x == 5){
            score++;
            score_audio.play();
        }
    }

    ctx.drawImage(fg, 0, cvs.height - fg.height);
    ctx.drawImage(bird, xpos, ypos);
    console.log(pre_jump_pos-ypos)
    if(jump && pre_jump_pos-ypos<40)
    {
        ypos -= 5;
    }
    else if(jump && pre_jump_pos-ypos>40)
    {
        jump=false;
    }
    else{
        ypos += grav;
    }
   

    ctx.fillstype = "#000";
    ctx.font = "24px verdana";
    ctx.fillText ("rezultāts: " + score, 10, cvs.height - 20);
    requestAnimationFrame(draw);
}

pipeBottom.onload = draw;
}
