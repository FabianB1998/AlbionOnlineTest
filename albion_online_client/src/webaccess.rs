extern crate nickel;

use self::nickel::{Nickel, StaticFilesHandler};

static host : &'static str = "0.0.0.0:8080";


pub fn run_server(){

    let mut server = Nickel::new();

    server.utilize(StaticFilesHandler::new("web/"));

    server.listen(host);
}