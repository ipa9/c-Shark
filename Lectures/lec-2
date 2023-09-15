var cat = new Cat("Cat1");
cat.Shout();
var dog = new Dog("Dog2");
dog.Shout();


public abstract class Animal
{
    private string name;

    public Animal(string name)
    {
        Name = name;
    }

    public string Name
    {
        get => name; 
        set {
            if (value.Length < 3) throw new Exception("Length of the name must be more than 3 letters!");
            name = value;
        }
    }

    public virtual void Shout ()
    {
        Console.WriteLine("I'm Animal");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void Shout ()
    {
        Console.WriteLine("I'm a Cat");
    }
}
class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
    public override void Shout()
    {
        Console.WriteLine("I'm a Dog");
    }
}
