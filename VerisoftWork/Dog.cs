using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftWork
{
    // מחלקת Dog היורשת מ-Animal ומיישמת את הממשק Land
    public class Dog : Animal, Land
    {
        // משתנה פרטי לשמירת מספר הרגליים של הכלב
        private int numberOfLegs;

        // קונסטרקטור של המחלקה Dog, מאתחל תכונות ירושות מהמחלקה Animal
        // ומגדיר את מספר הרגליים של הכלב כ-4
        public Dog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
            // הגדרת מספר הרגליים של הכלב
            this.numberOfLegs = 4;
        }

        // פונקציה זו מדפיסה למסך את הצליל שהכלב משמיע כדרך ברכה
        public void sayHello()
        {
            Console.WriteLine("wagging tails");
        }

        // מימוש של השיטה המופשטת מהמחלקה Animal
        // הפונקציה מקבלת את מצב הרוח של הכלב כפרמטר ומדפיסה צליל מתאים
        public override void sayHello(int mood)
        {
            // בודקים אם מצב הרוח הוא שמח, ואז הכלב נובח
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("Barking loudly");
            }
            // אחרת, אם מצב הרוח מפוחד, הכלב משמיע קול יללה
            else
            {
                Console.WriteLine("whooping");
            }
        }

        int Land.getNumberOfLegs()
        {
            throw new NotImplementedException();
        }
    }
}
