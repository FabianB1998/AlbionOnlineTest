var player;

function setup() {
  createCanvas(600, 600);

  player = new Player();

  setInterval(UpdateTick, 100);
}

function UpdateTick(){
  GetResponse("http://localhost:8080/getInfo", player.updateInfo);
}

function draw() {
  background(55);
  player.draw();
}