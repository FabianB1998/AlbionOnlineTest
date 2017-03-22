use nickel::{Nickel, HttpRouter, StaticFilesHandler};
use rustc_serialize::json;

static host : &'static str = "0.0.0.0:8080";

#[derive(RustcEncodable, RustcDecodable)]
struct Info {
    mapName: String,
    position: Vector,
}

#[derive(RustcEncodable, RustcDecodable)]
struct Vector {
    x: u16,
    y: u16,
}

pub fn run_server(){

    let mut server = Nickel::new();

    //Hosting the static files of the website
    server.utilize(StaticFilesHandler::new("web/"));

    //Rest API Stuff
    server.get("/test", middleware!("This is a test"));

    server.get("/hey/:name", middleware! { |request|
        format!("Hey! {:?}, how are you ??", request.param("name"))
    });

    //API test

    server.get("/getInfo", middleware! { |request|
       getInfo().to_string()
    });

    server.listen(host);
}

fn getInfo() -> String {
    let mut myInfo = Info{
        mapName:"Test".to_string(),
        position:Vector{x:200 ,y:200},
    };

    let mut result = json::encode(&myInfo).unwrap();

   result
}