using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationScratchpad
{
    public class Dog
    {
        public bool IsSitting { get; private set; } = true;
        //public bool IsRunning { get; private set; }
        public string Name { get; }
        public bool IsHungry { get; private set; }

        private bool _isRunning;
        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }

            set
            {
                _isRunning = value;
                if (value)
                {
                    IsSitting = false;
                }
            }
        }


        public Dog(string name)
        {
            Name = name;
            IsHungry = true;
        }

        public void Sit()
        {
            IsSitting = true;
            IsRunning = false;
        }

        public void Stand()
        {
            IsSitting = false;
            IsRunning = false;
        }

        public void Run()
        {
            IsSitting = false;
            IsRunning = true;
        }

        public void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine("Yum");
            }
            IsHungry = false;
        }

        public void PassTime()
        {
            this.IsHungry = true;
        }
    }
}
