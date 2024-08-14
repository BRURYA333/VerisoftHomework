using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftWork
{
    // מחלקת Cat היורשת מ-Animal ומיישמת את הממשק Land
    public class Cat : Animal, Land
    {
        // משתנה פרטי לאחסון מספר הרגליים של החתול
        private int numberOfLegs;

        // קונסטרקטור של המחלקה Cat, מאתחל תכונות ירושות מהמחלקה Animal
        // ומגדיר את מספר הרגליים של החתול כ-4
        public Cat(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
            // הגדרת מספר הרגליים של החתול
            this.numberOfLegs = 4;
        }

        // פונקציה זו מדפיסה למסך את הצליל שהחתול משמיע כדרך ברכה
        public void sayHello()
        {
            Console.WriteLine("meow");
        }

        // מימוש של השיטה המופשטת מהמחלקה Animal
        // הפונקציה מקבלת את מצב הרוח של החתול כפרמטר ומדפיסה צליל מתאים
        public override void sayHello(int mood)
        {
            // בודקים אם מצב הרוח הוא שמח, ואז החתול משמיע גרגור
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("purr");
            }
            // אחרת, אם מצב הרוח מפוחד, החתול משמיע נשיפה
            else
            {
                Console.WriteLine("hiss");
            }
        }

        public int getNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
