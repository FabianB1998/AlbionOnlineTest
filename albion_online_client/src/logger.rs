use std::fs::OpenOptions;
use std::fs::File;
use std::io::Write;

pub enum ErrorLevel{
    Info,
    Warning,
    Error,
}

#[allow(unused_must_use)]
pub fn log(level : ErrorLevel, message : &str){
    let mut file = OpenOptions::new().append(true).create(true).open("log.txt").unwrap();
    match level{
        ErrorLevel::Info => {
            file.write_all(b"[Info] ");
            file.write_all(message.as_bytes());
            file.sync_data();
        },
        ErrorLevel::Warning => {
            file.write_all(b"[Warning] ");
            file.write_all(message.as_bytes());
            file.sync_data();
        },
        ErrorLevel::Error => {
            file.write_all(b"[Error] ");
            file.write_all(message.as_bytes());
            file.sync_data();
        }
    }
    file.write_all(b"\n");
    file.sync_data();
}
