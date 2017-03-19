mod user;
mod scripting;
mod webaccess;
mod logger;

use user::Serializable;

fn main(){
    let mut t = scripting::Scripts::new();
    t.setup();
    t.run_all();
    logger::log(logger::ErrorLevel::Info, "Set up script engine");
    //webaccess::runServer();
}
