extern crate tiny_http;

use self::tiny_http::{Server, Response};


#[allow(unused_must_use)]
pub fn run_server(){
    let server = match tiny_http::Server::http("0.0.0.0:8080"){
        Ok(serv) => serv,
        Err(e) => { println!("error: {}", e);  panic!("Fail");}
        };
    
    loop{

        let request = match server.recv() {
        Ok(rq) => rq,
        Err(e) => { println!("error: {}", e); break }
        };

        let resp = tiny_http::Response::from_string("Hello World");

        request.respond(resp);
        
    }
}
