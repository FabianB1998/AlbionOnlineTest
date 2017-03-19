use std::fmt::Display;

pub fn print_native<T: Display>(to_print : &mut T) -> (){
    println!("{}", to_print);
}
