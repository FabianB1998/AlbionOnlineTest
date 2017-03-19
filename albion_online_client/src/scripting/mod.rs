extern crate rhai;

mod native_script_functions;

use std::fs;
use std::ffi::OsStr;
use std::collections::HashMap;

use self::rhai::{Engine, FnRegister};


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

    
    pub fn load_script(&mut self, name : &str, path : &str){
        self.loaded_scripts.insert(name.to_owned(), path.to_owned());
    }

    
    pub fn setup(&mut self){
        self.engine.register_fn("print", native_script_functions::print_native as fn(to_print : &mut String) -> ());
        let paths = match fs::read_dir("./scripts"){
            Ok(path) => path,
            Err(e) => {println!("Failed to open script dir: {}. Creating directory...", e);
                       match fs::create_dir("./scripts"){
                           Ok(_) => (),
                           Err(e) => {println!("Critical error while creating directory {}", e); return;}
                       };
                       return;}
        };
        for file in paths{
            let file = file.unwrap();
            if file.path().extension().unwrap()  == "rhai"{
            println!("Loading {}", file.path().file_name().unwrap().to_str().unwrap());
                //Unwraping horror, need to fix 
                self.load_script(file.path().file_stem().unwrap()
                                 .to_str().unwrap()
                                 , file.path().to_str().unwrap());
            }
        }
    }

    
    pub fn run_all(&mut self){
        for (script_name, script_path) in &self.loaded_scripts{
            match self.engine.eval_file::<()>(script_path){
                Ok(_) => (),
                Err(e) => {println!("Failed to execute script {} : {}", script_name, e)}
            }
        }
    }
}
