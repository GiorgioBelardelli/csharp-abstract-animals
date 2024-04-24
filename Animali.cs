using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{

        //INTERFACCIA PER ESERCIZIO 2
        public interface IVolante
        {
            public void Vola();
        }

        public interface INuotante
        {
            public void Nuota();
        }
        

        //ESERCIZIO 1
        public abstract class Animale
        {
            public abstract void Mangia();
            public abstract void FaiVerso();
            public void Dormi()
            {
                Console.WriteLine("Zzzzzz");
            }
        }

        public class Cane : Animale
        {
            public override void Mangia()
            {
                Console.WriteLine("Carnivoro");
            }
            public override void FaiVerso()
            {
                Console.WriteLine("Woof! Woof!");
            }
        }
        public class Passerotto : Animale, IVolante
        {
            public override void Mangia()
            {
                Console.WriteLine("Granivoro");
            }
            public override void FaiVerso()
            {
                Console.WriteLine("Chip! Chip!");
            }
            public void Vola() 
            {
                Console.WriteLine("Sto volando!!!");
            }
        }
        public class Aquila : Animale, IVolante
        {
            public override void Mangia()
            {
                Console.WriteLine("Carnivoro");
        }
            public override void FaiVerso()
            {
                Console.WriteLine("Screech! Screech!");
            }
            public void Vola()
            {
                Console.WriteLine("Sto volando!!!");
            }
        }
        public class Delfino : Animale, INuotante
        {
            public override void Mangia()
            {
                Console.WriteLine("Pescivoro");
            }
            public override void FaiVerso()
            {
                Console.WriteLine("eEeEeEeEeE!!");
            }
            public void Nuota()
            {
                Console.WriteLine("Sto nuotando!!!");
            }
        }

}
