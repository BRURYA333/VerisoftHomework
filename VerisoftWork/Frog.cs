using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftWork
{
    // מחלקת Frog היורשת מ-Animal ומיישמת את הממשק Water
    public class Frog : Animal, Water
    {
        // משתנה פרטי לאחסון מספר הרגליים של הצפרדע
        private int numberOfLegs;

        // קונסטרקטור של המחלקה Frog, מאתחל תכונות ירושות מהמחלקה Animal
        // ומגדיר את מספר הרגליים של הצפרדע כ-4
        public Frog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood)
        {
            // הגדרת מספר הרגליים של הצפרדע
            this.numberOfLegs = 4;
        }

        // מימוש של השיטה המופשטת מהמחלקה Animal
        // הפונקציה מקבלת את מצב הרוח של הצפרדע כפרמטר ומדפיסה צליל מתאים
        public override void sayHello(int mood)
        {
            // בודקים אם מצב הרוח הוא שמח, ואז הצפרדע משמיעה קולות שירה
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("quack quack quack");
            }
            // אחרת, אם מצב הרוח מפוחד, הצפרדע קופצת למים
            else
            {
                Console.WriteLine("plop into the water");
            }
        }

        // פונקציה הבודקת האם לצפרדע יש זימים
        public bool hasGills()
        {
            return false; // צפרדע אינה בעלת זימים
        }

        // פונקציה הבודקת האם הצפרדע מטילה ביצים
        public bool hasLaysEggs()
        {
            return true; // צפרדע מטילה ביצים
        }
    }
}


