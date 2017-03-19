extern crate rhai;

mod native_script_functions;

use std::fs;
use std::collections::HashMap;

use logger;

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
            Err(e) => {logger::log(logger::ErrorLevel::Warning, "Failed to open script folder, trying to create it");
                       match fs::create_dir("./scripts"){
                           Ok(_) => (),
                           Err(e) => {logger::log(logger::ErrorLevel::Error, "Critical error while creating directory"); return;}
                       };
                       return;}
        };
        for file in paths{
            let file = file.unwrap();
            if file.path().extension().unwrap()  == "rhai"{
                //There is probably a nicer way 
                let mut message = "Loading ".to_owned();
                message.push_str(file.path().file_name().unwrap().to_str().unwrap());
                logger::log(logger::ErrorLevel::Info, message.as_str());

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
                Err(e) => {logger::log(logger::ErrorLevel::Warning, format!("Failed to execute script {} : {}", script_name, e).as_str())}
            }
        }
    }
}
