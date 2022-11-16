using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using BLL;
using System.IO;
using System.Xml.Serialization;

namespace _3LAB32
{
    class Program
    {
        static void Main(string[] args)
        {

            Students john = new Students("Jhn", "Doe", "second year", "20n655", "2/5/02");

            Stream stream = File.Open("studentsData.dat", FileMode.Create);

            XmlSerializer serializer = new XmlSerializer(typeof(Students));
            using (TextWriter tw = new StreamWriter(@"C:\Users\princessntomo\C#Data\john.xml"))
            {
                serializer.Serialize(tw, john);
            }

            john = null;

            XmlSerializer deserializer = new XmlSerializer(typeof(Students));

            TextReader reader = new StreamReader(@"C:\Users\princessntomo\C#Data\john.xml");

            object obj = deserializer.Deserialize(reader);
            john = (Students)obj;
            reader.Close();

            Console.WriteLine(john.ToString());

            List<Students> thestudents = new List<Students>
            {
                new Students ("blessing", "esor", "second year", "f4p123", "2/11/03"),
                new Students ("robbi", "jon", "second year", "m4p124", "2/12/04"),
                new Students ("kaiti", "koi", "second year", "f4p125", "2/01/03")
            };

            using (Stream fs = new FileStream(@"C:\Users\princessntomo\C#Data\john.xml", FileMode.Create, 
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer1 = new XmlSerializer(typeof(List<Students>));
                serializer1.Serialize(fs, thestudents);
            }
            thestudents = null;
            XmlSerializer serializer2 = new XmlSerializer(typeof(List<Students>));
            using (FileStream fileStream = File.OpenRead(@"C:\Users\Ntomo Princess\Desktop\students"))
            {
                thestudents = (List<Students>)serializer2.Deserialize(fileStream);
            }
            foreach (Students s in thestudents)
            {
                Console.WriteLine(s.ToString());
            }

        }

        public void Students()
        {
            char secondyrfemale;
            string Students;
            do
            {
                Console.Write("Are you a second year female(y/n)? ");
                Students = Console.ReadLine();
                secondyrfemale = char.Parse(Students);

                if (secondyrfemale != 'y')
                    Console.WriteLine(" okay byee ");
            }
            while (!(secondyrfemale == 'y'));
            {
                for (int j = 0; j<10; j++)
                {
                    Console.WriteLine(Students);
                }
            }
            Console.WriteLine();

        }
    }
}
