namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animale> animali = new List<Animale>();

            Cane PastoreTedesco = new Cane();
            Passerotto PasseraEuropea = new Passerotto();
            Aquila AquilaBonelli = new Aquila();
            Delfino DelfinoComune = new Delfino();

            animali.Add(PastoreTedesco);
            animali.Add(PasseraEuropea);
            animali.Add(AquilaBonelli);
            animali.Add(DelfinoComune);

            foreach (Animale a in animali)
            {
                a.Dormi();
                a.Mangia();
                a.FaiVerso();

                Console.WriteLine("---");

            }

            FaiVolare(PasseraEuropea);
            FaiVolare(AquilaBonelli);
            FaiNuotare(DelfinoComune);
        }

        static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }

        static void FaiNuotare(INuotante animale)
        {
            animale.Nuota();
        }
    }
}
