using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
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
        public class Passerotto : Animale
        {
            public override void Mangia()
            {
                Console.WriteLine("Granivoro");
            }
            public override void FaiVerso()
            {
                Console.WriteLine("Chip! Chip!");
            }
        }
        public class Aquila : Animale
        {
            public override void Mangia()
            {
                Console.WriteLine("Carnivoro");
            }
            public override void FaiVerso()
            {
                Console.WriteLine("Screech! Screech!");
            }
        }
        public class Delfino : Animale
        {
            public override void Mangia()
            {
                Console.WriteLine("Pescivoro");
            }
            public override void FaiVerso()
            {
                Console.WriteLine("eEeEeEeEeE!!");
            }
        }

}
