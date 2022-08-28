use std::ops::{Index, IndexMut};

#[derive(Debug)]
pub struct Arr {
    arr: Vec<i32>,
}

impl Arr {
    fn new(len: usize, fill_fn: fn(usize) -> i32) -> Arr {
        Arr {
            arr: {
                let mut vec: Vec<i32> = Vec::new();
                for i in 0..len {
                    vec.push(fill_fn(i));
                }
                vec
            },
        }
    }

    fn get_item(&self, index: usize) -> i32 {
        self.arr[index]
    }

    fn set_item(&mut self, index: usize, value: i32) {
        self.arr[index] = value;
    }

    fn get_len(&self) -> usize {
        self.arr.len()
    }

    fn get_arr(&self) -> &Vec<i32> {
        &self.arr
    }
}

impl Index<usize> for Arr {
    type Output = i32;
    fn index<'a>(&'a self, i: usize) -> &'a i32 {
        &self.arr[i]
    }
}

impl IndexMut<usize> for Arr {
    fn index_mut(&mut self, index: usize) -> &mut i32 {
        &mut self.arr[index]
    }
}

impl Drop for Arr {
    fn drop(&mut self) {
        drop(&self.arr);
        println!("Drop Arr");
    }
}

fn get_number_of_odds(arr: &Arr) -> i32 {
    let mut sum = 0;
    for item in arr.get_arr() {
        if item.abs() % 2 == 1 {
            sum += 1;
        }
    }
    sum
}

fn main() {
    let mut a = Arr::new(8, |i| {
        if i % 2 == 0 {
            (i as i32) + 5
        } else {
            (i as i32) - 2
        }
    });
    a.set_item(5, 10);
    print!("{:?};  ", &a);
    print!("len: {};  ", a.get_len());
    println!("Odds = {};", get_number_of_odds(&a));
    println!("Item 5 = {}", a.get_item(5));
    a[5] = 20;
    println!("Item 5 = {}", a[5]);
}
