using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silawor
{
    enum enum1
    {
        value = 1,
        value_ = 2
    }
    struct struct_ {
        public string name;
        public int age;
        public struct_(string name , int age)
        {
            this.name = name;
            this.age = age; 
        }
        public void GetInfo()
        {
            Console.WriteLine($"Value name is : {name} ,value age is {age}");
        }
    }
    public class Planet_Earth
    {
        const int num_Continent = 2;
        //public Object[] = new Object[3]{ Planet_Earth.Sea_North_America , Planet_Earth.Coutry_America , Planet_Earth.island_America };
        public int Sea_North_America_i = 0, Coutry_America_i = 0, island_America_i = 0;
        public string[] Sea_North_America = { "Карибское море", "Берингово море", "Море Бофорта", "Море Баффина", "Гуздонское море", "Чукотское море" };
        public string[] Coutry_America = { "USA", "Canada", "Mexico" };
        public string[] island_America = { "Greenland", "Victoria", "Cyba", "Gaiti" };
        public List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public string[] Sea_North_America_ 
        {
            get
            {
                return Sea_North_America;
            }
            set
            {
                Planet_Earth nw = new Planet_Earth();
                Sea_North_America[nw.Sea_North_America_i] = value.ToString();
                nw.Sea_North_America_i += 1;
                if(nw.Sea_North_America_i == 6)
                {
                    nw.Sea_North_America_i = 0;
                }
            }
        }
        public string[] Coutry_America_
        {
            get
            {
                return Coutry_America;
            }
            set
            {
                Planet_Earth nw = new Planet_Earth();
                Coutry_America[nw.Coutry_America_i] = value.ToString();
                nw.Coutry_America_i += 1;
                if (nw.Coutry_America_i == 3)
                {
                    nw.Coutry_America_i = 0;
                }
            }
        }
        public string[] island_America_
        {
            get
            {
                return island_America;
            }
            set
            {
                Planet_Earth nw = new Planet_Earth();
                island_America[nw.island_America_i] = value.ToString();
                nw.island_America_i += 1;
                if (nw.island_America_i == 3)
                {
                    nw.island_America_i = 0;
                }
            }
        }
        /////////////////////////////////////////////////////////////////
        //это нужно закинуть в другой класс,но функции объявить здесь или проще говоря сделать их абстрактными для того чтобы в другом классе их переопределить
        public virtual void Result_Sort() { }
        public virtual void Country_on_the_Continent() { }
        public virtual void number_Sea_on_the_Continent() { }
        public virtual void Del_elem() { }     
        public virtual void list_(){ }
    }
    class Control : Planet_Earth 
    {
        public override void Result_Sort()
        {
            Planet_Earth nw = new Planet_Earth();
            Console.WriteLine("Before Sort:");
            foreach (string s in nw.island_America)
                Console.Write("{0}, ", s);
            Console.WriteLine("After Sort:");
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < nw.island_America.Length - 1; ++i)
                    if (nw.island_America[i].CompareTo(nw.island_America[i + 1]) > 0)
                    {
                        string buf = nw.island_America[i];
                        nw.island_America[i] = nw.island_America[i + 1];
                        nw.island_America[i + 1] = buf;
                        flag = true;
                    }
            }
            foreach (string s in nw.island_America)
                Console.Write("{0}, ", s);
        }
        public override void Country_on_the_Continent()
        {
            Planet_Earth nw = new Planet_Earth();
            Console.WriteLine("Country on the continent: ");
            foreach (string s in nw.island_America)
                Console.Write("{0}, ", s);
        }
        public override void number_Sea_on_the_Continent()
        {
            Planet_Earth pop = new Planet_Earth();
            int number_Sea = pop.Coutry_America.Length;
            Console.WriteLine($"Number Sea: {number_Sea}");
        }
        public override void Del_elem()
        {
            Console.Write("ENTER INDEX OF THE ELEMENT TO REMOVE(max 6): ");
            int index = int.Parse(Console.ReadLine());
            if (index > 5)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.Write("ENTER INDEX OF THE ELEMENT TO REMOVE(max 2): ");
            int index1 = int.Parse(Console.ReadLine());
            if (index1 > 2)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.Write("ENTER INDEX OF THE ELEMENT TO REMOVE(max 3): ");
            int index2 = int.Parse(Console.ReadLine());
            if (index1 > 3)
            {
                Console.WriteLine("Error");
                return;
            }
            Planet_Earth nw = new Planet_Earth();
            nw.Result_Sort();
            for (int i = index; i < nw.Sea_North_America.Length; ++i)
            {
                if (i < nw.Sea_North_America.Length - 1)
                    nw.Sea_North_America[i] = nw.Sea_North_America[i + 1];
            }
            for (int i = 0; i < nw.Sea_North_America.Length; ++i)
            {
                    Console.WriteLine($"Value array Sea_North_America[{i}] { nw.Sea_North_America[i]}");
            }
            ///////////////////////////////////////////////////////////
            for (int i = index1; i < nw.Coutry_America.Length; ++i)
            {
                if (i < nw.Coutry_America.Length - 1)
                    nw.Coutry_America[i] = nw.Coutry_America[i + 1];
            }
            for (int i = 0; i < nw.Coutry_America.Length; ++i)
            {
                Console.WriteLine($"Value array Coutry_America[{i}] { nw.Coutry_America[i]}");
            }
            ///////////////////////////////////////////////////////////
            for (int i = index; i < nw.island_America.Length; ++i)
            {
                if (i < nw.island_America.Length - 1)
                    nw.island_America[i] = nw.island_America[i + 1];
            }
            for (int i = 0; i < nw.island_America.Length; ++i)
            {
                Console.WriteLine($"Value array Island_America[{i}] { nw.island_America[i]}");
            }

        }
        public override void list_()
        {
            Planet_Earth nw = new Planet_Earth();
            Console.WriteLine($"List: {nw.list}");
            foreach (int item in nw.list)
                Console.Write($"{item}, ");
        }
    }
    public partial class ratilclas {
        partial void Anything();
        public void Anything_1()
        {
            Console.WriteLine("Anything 1");
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            enum1 en;
            en = enum1.value;
            Console.WriteLine($"Value enum is : {(int)en}");
            struct_ st = new struct_("Daniil", 20);
            st.GetInfo();
            Control nw_ = new Control();
            nw_.Result_Sort();
            nw_.Country_on_the_Continent();
            nw_.number_Sea_on_the_Continent();
            nw_.Del_elem();
            nw_.list.Add(6);
            nw_.list_();
            Console.ReadKey();
        }
    }
}