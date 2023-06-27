namespace ExerciseVectors
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        override public string ToString()
        {
            return Room + ": " + Name + ", " + Email;
        }
    }
}