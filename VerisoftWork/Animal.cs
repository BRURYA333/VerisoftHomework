using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftWork
{
    public abstract class Animal
    {
        private bool mammals;
        private bool carnivorous;
        private int mood;
        protected const int MOOD_HAPPY=1;
        protected const int MOOD_SCARE=2;

        public Animal(bool mammals, bool carnivorous, int mood) { 
        
            this.mammals= mammals;
            this.carnivorous= carnivorous;
            this.mood=mood;
        }

        public void sayHello() 
        {
        }
        public abstract void sayHello(int mood);
        public bool isMammals()
        {
            return mammals;
        }

        public void setMammals(bool mammals)
        {
            this.mammals= mammals;
        }

        public bool isCarnivorous()
        {
            return carnivorous;
        }

        public void setCarnivorous(bool carnivorous)
        {
            this.carnivorous = carnivorous;
        }



    }
}
