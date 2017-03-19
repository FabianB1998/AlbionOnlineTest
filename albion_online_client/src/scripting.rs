use std::fmt::Display;

extern crate rhai;

use self::rhai::{Engine, FnRegister};
use std::collections::HashMap;

fn print_native<T: Display>(to_print : &mut T) -> (){
    println!("{}", to_print);
}

pub struct Scripts{
    loaded_scripts : HashMap<String, String>,
    engine : Engine,
    current_script : String,
}

impl Scripts{

    pub fn new() -> Scripts{
        Scripts{
            loaded_scripts : HashMap::new(),
            engine : Engine::new(),
            current_script : "".to_string(),
        }
    }

    pub fn load_script(&mut self, name : String, path : String){
        self.loaded_scripts.insert(name, path);
    }
    
    pub fn setup(&mut self){
        self.engine.register_fn("print", print_native as fn(to_print : &mut String) -> ());
    }

    pub fn run_all(&mut self){
        for (script_name, script_path) in &self.loaded_scripts{
            match self.engine.eval_file::<()>(script_path){
                Ok(_) => (),
                Err(e) => {println!("Failed to execute {} : {}", script_name, e)}
            }
        }
    }

}
