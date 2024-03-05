using System.Net.Security;

namespace AbstractAnimalClass
{
    abstract class Dessert
    {
        // Property
        public abstract string Baker { get; set; }
        // Methods
        public abstract string Describe();
    }

    class Program
    {
        class Cake : Dessert
        {
            public int Calories { get; set; }
            public string Type { get; set; }
            public override string Baker { get; set; }
            public Cake()
            {
                Calories = 0;
                Type = string.Empty;
                Baker = string.Empty;
            }
            public Cake(int calories, string type, string baker)
            {
                Calories = calories;
                Type = type;
                Baker = baker;
            }
            public override string Describe()
            {
                return $"Calories: {Calories}, Type: {Type}, Baker: {Baker}";
            }
        }
        static void Main(string[] args)
        {
            Cake carrot = new Cake();
            carrot.Calories = 300;
            carrot.Type = "Carrot Cake";
            carrot.Baker = "John";

            Cake devil = new Cake(400, "Devil's cake", "Jane");

            Console.WriteLine(carrot.Describe());
            Console.WriteLine();
            Console.WriteLine(devil.Describe());
            Console.ReadLine();
        }
    }
}