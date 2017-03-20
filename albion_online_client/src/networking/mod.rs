use std::net::UdpSocket;
use logger;

struct AlbionClient{
    socket : UdpSocket,
}

impl AlbionClient{

    pub fn login(&self, user : String, password : String){
        
    }
    
    pub fn new() -> AlbionClient{

        let mut sock = match UdpSocket::bind("0.0.0.0:5055"){
            Ok(client) => client,
            Err(e) => {
                logger::log(logger::ErrorLevel::Error, "Failed to bind client");
                panic!();
            }
        };
        
        AlbionClient{
            socket : sock
        }
    }
}
