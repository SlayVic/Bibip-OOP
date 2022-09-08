#include <iostream>
#define _USE_MATH_DEFINES
#include <math.h>

class Cone
{
private:
  float radius;
  float height;

public:
  Cone(float r, float h)
  {
    r = r > 0 ? r : 0;
    h = h > 0 ? h : 0;
    radius = r;
    height = h;
  }

  Cone()
  {
    radius = 0;
    height = 0;
  }

  auto getVolume() -> float
  {
    return M_1_PI * radius * radius * height / 3;
  }

  auto getRadius() -> float
  {
    return radius;
  }

  auto getHeight() -> float
  {
    return height;
  }

  void setRadius(float r)
  {
    r = r > 0 ? r : 0;
    radius = r;
  }

  void setHeight(float h)
  {
    h = h > 0 ? h : 0;
    height = h;
  }

  void print()
  {
    std::cout << "Radius: " << getRadius() << ";  Height: " << getHeight() << ";  Volume: " << getVolume() << std::endl;
  }

  Cone operator+(Cone &other)
  {
    Cone result(radius + other.getRadius(), height + other.getHeight());
    return result;
  }

  Cone operator-(Cone &other)
  {
    Cone result(radius - other.getRadius(), height - other.getHeight());
    return result;
  }

  Cone operator++()
  {
    radius++;
    height++;
    return *this;
  }

  Cone operator++(int notused)
  {
    Cone t = *this;
    radius++;
    height++;
    return t;
  }

  Cone operator--()
  {
    radius--;
    height--;
    return *this;
  }

  Cone operator--(int notused)
  {
    Cone t = *this;
    radius--;
    height--;
    return t;
  }
  friend std::ostream &operator<<(std::ostream &t, Cone &obj);
};

std::ostream &operator<<(std::ostream &t, Cone &obj)
{
  t << "Radius: " << obj.getRadius() << ";  Height: " << obj.getHeight() << ";  Volume: " << obj.getVolume();
  return t;
}

int main()
{
  Cone c1(5, 8);
  Cone c2(3, 4);
  Cone c3 = c1 + c2;
  Cone c4 = c1 - c2;
  Cone c5 = ++c1;
  Cone c6 = --c1;
  std::cout << "     c1: " << c1 << std::endl;
  std::cout << "     c2: " << c2 << std::endl;
  std::cout << "c1 + c2: " << c3 << std::endl;
  std::cout << "c1 - c2: " << c4 << std::endl;
  std::cout << "   ++c1: " << c5 << std::endl;
  std::cout << "   --c1: " << c6 << std::endl;
  return 0;

  int main()
  {
    float value;
    cout << "\nSet the radius value: ";
    cin >> value;

    Sphere sp1 = Sphere();

    Sphere sp2(value);
    sp1.printValues();
    sp2.printValues();

    Sphere *sp1_ptr = &sp1;                // создаём указатель на екземпляр класса Sphere
    void (Sphere::*set_radius_ptr)(float); // создаём указатель на метод setRadius
    set_radius_ptr = &Sphere::setRadius;   // присваиваем ему адрес метода setRadius
    (sp1_ptr->*set_radius_ptr)(50);        // вызываем метод setRadius через указатели с параметром 50
    sp1_ptr->printValues();                // вызываем метод printValues через указатель на екземпляр класса Sphere
    cout << "sp1.getRadius(): " << sp1.getRadius() << "\n";
  }
}