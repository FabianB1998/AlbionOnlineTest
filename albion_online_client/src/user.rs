extern crate ini;


pub struct User {
    pub password : String,
    pub username : String,
    pub selected_character : String,
}

pub trait Serializable{
    fn save_to_file(&self, filename : String);
    fn read_from_file(&self, filename : String);
}

impl Serializable for User{
    fn save_to_file(&self, filename : String){
        let mut conf = ini::Ini::new();
        conf.with_section(Some("User".to_owned()))
            .set("username", self.username.to_owned())
            .set("password", self.password.to_owned())
            .set("character", self.selected_character.to_owned());
        match conf.write_to_file(filename){
            Ok(_) => (),
            Err(er) => println!("{}", er)
        }
    }

    fn read_from_file(&self, filename : String){
        
    }
}
