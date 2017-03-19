mod user;
mod scripting;
mod webaccess;

//Hey fabian

fn main(){
    let mut t = scripting::Scripts::new();
    t.setup();
    t.run_all();
    //webaccess::runServer();
}
