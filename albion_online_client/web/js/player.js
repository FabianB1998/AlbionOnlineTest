function Player() {
    this.MapName = "none";
    this.PositionX = 0;
    this.PositionY = 0;
}

Player.prototype.updateInfo = function(data) {
    this.MapName = data.mapName;
    this.PositionX = data.position.x;
    this.PositionY = data.position.y;
};

Player.prototype.draw = function() {
    
    ellipse(this.PositionX, this.PositionY, 50);
};