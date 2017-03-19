mod user;
mod scripting;
mod webaccess;

fn main(){
    let mut t = scripting::Scripts::new();
    t.setup();
    t.run_all();
    //webaccess::runServer();
}
