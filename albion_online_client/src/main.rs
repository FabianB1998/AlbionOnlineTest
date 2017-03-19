mod user;
mod scripting;
mod webaccess;

fn main(){
    let mut t = scripting::Scripts::new();
    t.load_script("test", "test.rhai");
    t.setup();
    t.run_all();
    //webaccess::runServer();
}
