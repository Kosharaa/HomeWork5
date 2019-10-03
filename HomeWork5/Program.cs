using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{

    class Student
    {
        
        int iq;
        int debts;
        bool alcohol;
        string Name;
        string faculty;
        Random rand = new Random();

        public void NameFac()
        {
            Console.WriteLine("Hello my friend, what is you'r Name? :"); // БЛЯХА, И ДАЖЕ ЭТО Я МОГУ ВЫВЕСТИ В МЕТОД!!!)))
            Name = Console.ReadLine();
            Console.WriteLine("And what is you'r faculty? :");
            faculty = Console.ReadLine();
            
        }
        /*
        public void randAlco()
        {
            // Зачем-то мне нужен был этот метод но я передумал
            alcohol = rand.Next(100) < 50 ? true : false; 
        }
        */
        
        public void rnd()
        {
            iq = rand.Next(0, 224);
            debts = rand.Next(0, 6);
            alcohol = rand.Next(100) < 50? true : false; // ох и хороши тернарки... 
            
        }
        /*
        public void badStud()
        {
            // О Боги как же хорошо использовать методы
            if (alcohol && iq <= 70 || alcohol && debts > 3 || iq <= 70 && debts > 3)
            {
                Console.WriteLine("WTF Man you'r fired!");
            }
            else
            {
                alcohol = false;
                iq = iq + 10;
                Console.WriteLine("you have one more chance");
            }
        }

        */
        public void getInfo()
        {
            Console.WriteLine("iq: " + iq + "; university debts: " + debts + "; alcohol: " +
       alcohol + "; Name: " + Name + "; faculty: " + faculty);
        }
        static void Main(string[] args)
        {
            Student Stud = new Student();

            Stud.NameFac();
            // Я был против такого... ООП СИЛАААА!!!
            Stud.iq = Stud.rand.Next(0, 224);
            Stud.debts = Stud.rand.Next(0, 6);
            Stud.alcohol = Stud.rand.Next(100) < 50 ? true : false; // ох и хороши тернарки... 

            //Stud.rnd();// НУ ПОЖАЛУЙСТА! ТАК ЖЕ ЛЕГЧЕ!
            Stud.getInfo();
            //Stud.badStud();
            if (Stud.alcohol && Stud.iq <= 70 || Stud.alcohol && Stud.debts > 3 || Stud.iq <= 70 && Stud.debts > 3)
            {
                Console.WriteLine("WTF Man you'r fired!");
            }
            else
            {
                Stud.alcohol = false;
                Stud.iq = Stud.iq + 10;// мог написать тернарку, но 
                Console.WriteLine("OK, you have one more chance");//выйдет очень длинная и не красивая строка...
            }
            Stud.getInfo();

        }
    }
    /*
    class Program
        
    {

        static void Main(string[] args)
        {
            Student Stud = new Student();

            Stud.NameFac();
            Stud.rnd();
            Stud.getInfo();
            Stud.badStud();
            if (alcohol && iq <= 70 || alcohol && debts > 3 || iq <= 70 && debts > 3)
            {
                Console.WriteLine("WTF Man you'r fired!");
            }
            else
            {
                alcohol = false;
                iq = iq + 10;
                Console.WriteLine("you have one more chance");
            }
            Stud.getInfo();
        }
    }
*/
}

