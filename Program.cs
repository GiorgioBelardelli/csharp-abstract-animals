namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animale> animali = new List<Animale>();

            animali.Add(new Cane());
            animali.Add(new Passerotto());
            animali.Add(new Aquila());
            animali.Add(new Delfino());

            foreach (Animale a in animali) 
            {
                a.Dormi();
                a.Mangia();
                a.FaiVerso();
                Console.WriteLine("---");
            }





        }
    }
}
