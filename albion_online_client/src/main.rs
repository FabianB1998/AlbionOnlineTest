mod user;
mod scripting;
mod webaccess;
mod logger;
mod networking;

#[macro_use] extern crate nickel;
extern crate rustc_serialize;

use user::Serializable;

fn main(){
    let mut t = scripting::Scripts::new();
    let usr = user::User{
        password : "t".to_string(),
        selected_character : "t".to_string(),
        username : "t".to_string(),
    };
    usr.read_from_file("test".to_string());
    t.setup();
    t.run_all();
    logger::log(logger::ErrorLevel::Info, "Set up script engine");
    webaccess::run_server();
}
