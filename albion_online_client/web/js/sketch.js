var player;

function setup() {
  createCanvas(400, 400);

  player = new Player();

  setInterval(UpdateTick, 50);
}

function UpdateTick(){
  GetResponse("http://localhost:8080/getInfo", player.updateInfo);
}

function draw() {
  background(55);
  player.draw();
}