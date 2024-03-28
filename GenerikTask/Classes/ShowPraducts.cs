namespace GenerikTask.Classes
{
    internal class ShowPraducts
    {
        public void ShowProduct()
        {
            var praduct1 = new Praduct<int, string, decimal, double>(1, "Olma", 12000, 30.5);
            var praduct2 = new Praduct<int, string, decimal, double>(2, "Anor", 15000, 70.3);
            var praduct3 = new Praduct<int, string, decimal, double>(3, "Uzum", 16000, 57);

            praduct1.Display();
            praduct2.Display();
            praduct3.Display();
        }
    }
}
