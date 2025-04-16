# 🧮 Triangle Shape Calculator

A C# console-based project that demonstrates core Object-Oriented Programming (OOP) concepts such as **abstraction**, **inheritance**, and **interfaces**, by modeling a triangle and calculating its **area** and **circumference**.

---

## 📌 Features

- Asks the user to input triangle side lengths and base/height.
- Calculates:
  - Triangle **area**
  - Triangle **circumference**
- Uses both:
  - `abstract class` for shared shape behavior.
  - `interface` for enforcing implementation.

---

## 🧠 Key OOP Concepts Demonstrated

| Concept        | How it's applied                                   |
|----------------|----------------------------------------------------|
| Abstraction    | `AShape` is an abstract class with abstract methods |
| Inheritance    | `Triangle` inherits from `AShape`                  |
| Interface      | `Shape` is implemented by `Triangle`               |
| Polymorphism   | Methods like `area()` and `Cir()` overridden       |
| Encapsulation  | Private fields with public getters/setters         |

---

## 📂 Project Structure

test_shapes_program/ ├── AShape.cs # Abstract base class ├── Shape.cs # Interface for general shape ├── Triangle.cs # Concrete implementation for Triangle ├── Program.cs # Main execution file


## ▶️ Sample Output

Enter L1
3
Enter L2
4
Enter L3
5
Enter The base length and the heigh :
5
2
The Cir Of Triangle Is 12
The Area Of Triangle Is 5
