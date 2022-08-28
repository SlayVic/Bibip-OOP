#[derive(Debug)]
pub struct Triangle {
    a: f64,
    b: f64,
    c: f64,
}

trait IntoTriangle {
    fn into(self) -> Triangle;
}

impl IntoTriangle for () {
    fn into(self) -> Triangle {
        Triangle {
            a: 0.0,
            b: 0.0,
            c: 0.0,
        }
    }
}

impl IntoTriangle for (f64, f64, f64) {
    fn into(self) -> Triangle {
        Triangle {
            a: self.0,
            b: self.1,
            c: self.2,
        }
    }
}

impl From<(f64, f64, f64)> for Triangle {
    fn from((a, b, c): (f64, f64, f64)) -> Triangle {
        Triangle { a, b, c }
    }
}

impl Triangle {
    fn new<A>(args: A) -> Triangle
    where
        A: IntoTriangle,
    {
        println!("Call Triangle constructor");
        args.into()
    }

    fn get_a(&self) -> f64 {
        self.a
    }
    fn get_b(&self) -> f64 {
        self.b
    }
    fn get_c(&self) -> f64 {
        self.c
    }
    fn set_a(&mut self, a: f64) {
        self.a = a;
    }
    fn set_b(&mut self, b: f64) {
        self.b = b;
    }
    fn set_c(&mut self, c: f64) {
        self.c = c;
    }
    fn perimeter(&self) -> f64 {
        self.a + self.b + self.c
    }
    fn area(&self) -> f64 {
        let p = self.perimeter() / 2.0;
        let a = self.a;
        let b = self.b;
        let c = self.c;
        (p * (p - a) * (p - b) * (p - c)).sqrt()
    }
    fn print(&self) {
        println!(
            "a: {}; b: {}; c: {}; area: {}",
            self.a,
            self.b,
            self.c,
            self.area()
        );
    }
}

//destructor
impl Drop for Triangle {
    fn drop(&mut self) {
        println!("Dropping triangle");
    }
}

fn main() {
    let mut t = Triangle::new((3.0, 4.0, 5.0));
    t.print();

    let pointer_to_func = Triangle::set_a;
    // по факту це референс на функцію set_a, але не зовсім як у умові задачі, бо у расті немає показчиків на функції у потрібному вигляді

    let instance_pointer = &mut t as *mut Triangle;
    unsafe {
        pointer_to_func(&mut (*instance_pointer), 6.0);
        (*instance_pointer).print();
    }

    // кращім методом створення "показчика" на фукцію є closure, яким ми просто створюємо анонімну функцію, яка викликає потрібну нам функцію.
    let mut closure = |a| t.set_a(a);
    closure(7.0);
    t.print();

    drop(t);

    println!("Good bye!");
}
