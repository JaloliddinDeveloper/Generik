using GenerikTask.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Bazar");
        while (true)
        {
            Console.WriteLine("Choose Action:\n"); 
            Console.WriteLine("1.Show Praaducts");
            Console.WriteLine("2.Add Praduct");
            int n=int.Parse(Console.ReadLine());
            if (n==1)
            {
                var showProducts = new ShowPraducts();
                showProducts.ShowProduct();
            }
            if (n==2)
            {
                var addProduct = new AddPraduct();
                addProduct.AddPraductMethod();
            }
        }
    }
}