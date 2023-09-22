var chicken = new Chicken();
var cow = new Cow();

var cowAnimal = (Animal)cow;
var chickenAnimal = (Animal)chicken;

cowAnimal.Eat("Sandwich");
chickenAnimal.Eat("Sandwich");

var array = new Animal[] { cowAnimal, chickenAnimal };

var animalhouse = new AnimalHouse();

foreach (var animal in array)
{
    animal.Eat("Sandwich");
    animalhouse.Grow(animal);
}
Console.WriteLine(cowAnimal.Age);
public abstract class Animal
{
    public int Age {  get; set; } = 0;
    public void IncreaseAge(int age)
    {
        Age += age;
    }
    public virtual void Eat(string food)
    {
        Console.WriteLine($"Food is eaten {food}");
    }
    public virtual void GetEaten(string owner)
    {
        Console.WriteLine($"Owner eat this animal {owner}");
    }
}
public class Chicken : Animal
{
    public override void Eat(string food) 
    {  
        Console.WriteLine("Chicken is acting"); 
        base.Eat(food);
    }
    public override void GetEaten(string owner)
    {
        Console.WriteLine("Loading...");
        base.GetEaten(owner);
    }
}
public class Cow : Animal
{
    public override void Eat(string food)
    {
        Console.WriteLine("Cow is acting");
        base.Eat(food);
    }
    public override void GetEaten(string owner)
    {
        Console.WriteLine("Loading...");
        base.GetEaten(owner);
    }
}
class AnimalHouse
{
    public void Grow(Animal animal)
    {
        animal.IncreaseAge(1);
    }
}
