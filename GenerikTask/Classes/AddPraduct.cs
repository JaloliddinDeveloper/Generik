namespace GenerikTask.Classes
{
    internal class AddPraduct
    {
        public void AddPraductMethod()
        {
            var praductlist = new List<Praduct<int, string, decimal, double>>();

            Console.WriteLine("How many products do you want to add?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var praduct = new Praduct<int, string, decimal, double>();
                Console.WriteLine("Product Id: ");
                praduct.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Product Name: ");
                praduct.Name = Console.ReadLine();
                Console.WriteLine("Product Cost: ");
                praduct.Cost = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Product Weight: ");
                praduct.Weight = double.Parse(Console.ReadLine());
                praductlist.Add(praduct);
            }
            var showProducts = new ShowPraducts();
            showProducts.ShowProduct(); 

            Console.WriteLine("Added Products");
            foreach (var p in praductlist)
            {
                p.Display();
            }
        }
    }
}
