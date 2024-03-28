public class Praduct<Type1, Type2, Type3, Type4>
{
    public Type1 Id { get; set; }
    public Type2 Name { get; set; }
    public Type3 Cost { get; set; }
    public Type4 Weight { get; set; }

    public Praduct(Type1 id, Type2 name, Type3 cost, Type4 weight)
    {
        Id = id;
        Name = name;
        Cost = cost;
        Weight = weight;
    }
    public Praduct() { }

    public void Display() =>
        Console.WriteLine($"{Id}.Product Name is {Name}\n{Name}" +
            $" Cost is {Cost} Weight is {Weight} kg");

}