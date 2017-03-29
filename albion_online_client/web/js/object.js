var positionX;
var positionY;

function Object(name) {
    this.Name = name;
    this.PositionX = 0;
    this.PositionY = 0;
}

Object.prototype.updateInfo = function(data) {
    positionX = data.position.x;
    positionY = data.position.y;
};

Object.prototype.draw = function() {
    this.PositionX = positionX;
    this.PositionY = positionY;

    fill(255,255,0);
    ellipse(this.PositionX, this.PositionY, 20);
};