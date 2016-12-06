using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    class Dog : Animal
    {
        private string breed;

        public string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }

        public void WagTail()
        {
            Console.WriteLine("Dog wags tail");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Bark");
        }
    }
}
