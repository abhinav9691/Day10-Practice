namespace Exceptions1
{
    internal class PersonAge
    {
        public int CheckAge(int age)
        {
            try
            {
                if (age >= 1 && age <= 14)
                {
                    Console.WriteLine("Children");
                }
                else if (age >= 15 && age <= 24)
                {
                    Console.WriteLine("Youth");
                }
                else if (age >= 25 && age <= 64)
                {
                    Console.WriteLine("Adults");
                }
                else if (age >= 65)
                {
                    Console.WriteLine("Seniors");
                }
            }
            catch (PersonAgeException ex)
            {
                throw new PersonAgeException("Invalid Age");
            }
            return age;
        }
    }
}