using System;

namespace Studen_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student seymur = new Student("Seymur", "Manafov", "P324", 50, true);
            Console.WriteLine(seymur.getInfo());
            seymur.getInfoAll(seymur.Name, seymur.Surname, seymur.Group, seymur.Point, seymur.isGraduated);
            seymur.Point_of_graduated(seymur.Point);

        }


    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool isGraduated;

        public Student(string ad, string soyad, string qrup, int bal, bool mezundurmu)
        {
            Name = ad;
            Surname = soyad;
            Group = qrup;
            Point = bal;
            isGraduated = mezundurmu;

        }
        public string getInfo() {
            return $"NAME: { Name}, SURNAME: {Surname}";
        }
        public void getInfoAll(string ad, string soyad, string qrup, int bal, bool mezundurmu) {
            Console.WriteLine($"NAME: { ad}, SURNAME: {soyad}, GROUP: {qrup}, POINT: {bal},IS GRADUATED: {mezundurmu}");
            if (mezundurmu==true)
            {
                Console.WriteLine("This student is graduated"); 
            }
        }
        public void Point_of_graduated(int bal) {
            if (bal>80)
            {
                Console.WriteLine("This student can take the second exam");
            }
            else
            {
                Console.WriteLine("This student cannot take the second exam");
            }
        }
                


    }
}

