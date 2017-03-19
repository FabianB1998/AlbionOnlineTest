mod user;
mod scripting;

fn main(){
    let mut t = scripting::Scripts::new();
    t.load_script("test".to_string(), "test.rhai".to_string());
    t.setup();
    t.run_all();
}
