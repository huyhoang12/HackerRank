using System;

namespace Day12_Inheritance
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
    class Student : Person
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here
        public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
        {
            this.testScores = scores;
        }
        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate()
        {
            double average;
            int sum = 0;
            char grade = ' ';
            char[] gradeScale = new char[6] { 'T', 'D', 'P', 'A', 'E', 'O' };
            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];
            }
            average = sum / testScores.Length;
            if (average < 40)
            {
                grade = gradeScale[0];
            }
            if (average >= 40 && average < 55)
            {
                grade = gradeScale[1];
            }
            if (average >= 55 && average < 70)
            {
                grade = gradeScale[2];
            }
            if (average >= 70 && average < 80)
            {
                grade = gradeScale[3];
            }
            if (average >= 80 && average < 90)
            {
                grade = gradeScale[4];
            }
            if (average >= 90 && average <= 100)
            {
                grade = gradeScale[5];
            }
            return grade;
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
           
            {
                string[] inputs = Console.ReadLine().Split();
                string firstName = inputs[0];
                string lastName = inputs[1];
                int id = Convert.ToInt32(inputs[2]);
                int numScores = Convert.ToInt32(Console.ReadLine());
                inputs = Console.ReadLine().Split();
                int[] scores = new int[numScores];
                for (int i = 0; i < numScores; i++)
                {
                    scores[i] = Convert.ToInt32(inputs[i]);
                }

                Student s = new Student(firstName, lastName, id, scores);
                s.printPerson();
                Console.WriteLine("Grade: " + s.Calculate() + "\n");
            }
        }
    }
}
