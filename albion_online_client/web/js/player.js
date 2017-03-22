var mapName;
var positionX;
var positionY;

function Player() {
    this.MapName = "none";
    this.PositionX = 0;
    this.PositionY = 0;
}

Player.prototype.updateInfo = function(data) {
    mapName = data.mapName;
    positionX = data.position.x;
    positionY = data.position.y;
}

Player.prototype.draw = function() {
    this.MapName = mapName;
    this.PositionX = positionX;
    this.PositionY = positionY;

    fill(255,255,0);
    ellipse(this.PositionX, this.PositionY, 20);
};