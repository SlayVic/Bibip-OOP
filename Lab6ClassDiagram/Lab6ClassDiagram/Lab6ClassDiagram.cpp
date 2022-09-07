#include <iostream>

class Person
{
private:
    std::string name;
    int age;

public:
    Person(std::string n, int a)
    {
        name = n;
        age = a;
    }

    Person()
    {
        name = "";
        age = 0;
    }

    auto getName() -> std::string
    {
        return name;
    }

    void setName(std::string n)
    {
        name = n;
    }

    auto getAge() -> int
    {
        return age;
    }

    void setAge(int a)
    {
        age = a;
    }

    ~Person()
    {
        std::cout << "Some destructor was called, Idk why you need it ¯\\_(ツ)_/¯" << std::endl;
    }
};

class Servant : public Person
{
private:
    std::string rank;

public:
    Servant(std::string n, int a, std::string r) : Person(n, a)
    {
        rank = r;
    }

    Servant() : Person()
    {
        rank = "";
    }

    auto getRank() -> std::string
    {
        return rank;
    }

    void setRank(std::string r)
    {
        rank = r;
    }

    void print()
    {
        std::cout << "Name: " << getName() << ";  Age: " << getAge() << ";  Rank: " << getRank() << std::endl;
    }
};

class Employee : public Person
{
private:
    std::string position;

public:
    Employee(std::string n, int a, std::string p) : Person(n, a)
    {
        position = p;
    }

    Employee() : Person()
    {
        position = "";
    }

    auto getPosition() -> std::string
    {
        return position;
    }

    void setPosition(std::string p)
    {
        position = p;
    }

    void print()
    {
        std::cout << "Name: " << getName() << ";  Age: " << getAge() << ";  Position: " << getPosition() << std::endl;
    }
};

class Engineer : public Employee
{
private:
    std::string specialty;

public:
    Engineer(std::string n, int a, std::string p, std::string s) : Employee(n, a, p)
    {
        specialty = s;
    }

    Engineer() : Employee()
    {
        specialty = "";
    }

    auto getSpecialty() -> std::string
    {
        return specialty;
    }

    void setSpecialty(std::string s)
    {
        specialty = s;
    }

    void print()
    {
        std::cout << "Name: " << getName() << ";  Age: " << getAge() << ";  Position: " << getPosition() << ";  Specialty: " << getSpecialty() << std::endl;
    }
};

int main()
{
    Servant s("John", 25, "Captain");
    s.print();
    Engineer e("Mary", 30, "Head Engineer", "Computer Science");
    e.print();
}