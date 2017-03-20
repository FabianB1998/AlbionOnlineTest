extern crate tiny_http;

use std::fs::File;

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
	
	println!("{}", request.url());

        let resp = tiny_http::Response::from_file(File::open("index.html").unwrap());
        
        if request.url() != "/" {
            let resp = tiny_http::Response::from_file(File::open(request.url()).unwrap());
            
        }
        
        
        request.respond(resp);
        
    }
}
