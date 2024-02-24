namespace Interfaces_IEnumerable__Displaying_Data
{
    internal class Program
    {
        //Interfaces_IEnumerable__Displaying_Data
        //Hongfei
        //2024-2-23week7

        static SchoolClass pro124 = new SchoolClass();
        static void Main(string[] args)
        {
            Preload();


            foreach (Student student in pro124)
            {
                Console.WriteLine(student);
            }


        }

        public static void Preload()
        {
            pro124.AddStudent(new Student("S1"));
            pro124.AddStudent(new Student("S2"));
            pro124.AddStudent(new Student("S3"));
            pro124.AddStudent(new Student("S4"));
            pro124.AddStudent(new Student("S5"));
            pro124.AddStudent(new Student("S6"));
            pro124.AddStudent(new Student("S7"));
            pro124.AddStudent(new Student("S8"));
            pro124.AddStudent(new Student("S9"));
            pro124.AddStudent(new Student("S10"));
            pro124.AddStudent(new Student("S11"));
            pro124.AddStudent(new Student("S12"));
            pro124.AddStudent(new Student("S13"));
            pro124.AddStudent(new Student("S14"));
            pro124.AddStudent(new Student("S15"));
            pro124.AddStudent(new Student("S16"));
            pro124.AddStudent(new Student("S17"));
            pro124.AddStudent(new Student("S18"));
            pro124.AddStudent(new Student("S19"));
            pro124.AddStudent(new Student("S20"));

        }







    }//Program
}//namespace
