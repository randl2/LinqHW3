namespace LinqHW3;

class Program
{
    static void Main(string[] args)
    {
        List<Film> films = new List<Film>()
        {
            new Film { Name = "The Silence of the Lambs", Director = "Jonathan Demme" },
            new Film { Name = "The World's Fastest Indian", Director = "Roger Donaldson" },
            new Film { Name = "The Recruit", Director = "Roger Donaldson" }
        };

        List<Director> directors = new List<Director>()
        {
            new Director { Name = "Jonathan Demme", Country = "USA" },
            new Director { Name = "Roger Donaldson", Country = "New Zealand" },
        };

        //Завдання 1 Join

        Console.WriteLine("Завдання 1: " + new[] { "3a", "45", "87", "DDD", "d23f#" }.Aggregate((one, two) => $"{one}, {two}"));

        //Завдання 2 Concat

        Console.WriteLine("Завдання 2: " + new[] { "3a", "45", "87", "DDD", "d23f#" }.Aggregate((one, two) => $"{one}{two}"));

        //Завдання 3

        Console.WriteLine("Завдання 3:\n" + string.Join("\n", films
                    .Select(x => $"{x.Name}: {x.Director}, {directors.FirstOrDefault(y => y.Name == x.Director)?.Country}")));

        //Завдання 4

        Console.WriteLine("\nЗавдання 4:\n" + string.Join("\n", directors
                    .Select(x => $"{x.Name}: {string.Join(", ", films.Where(y => y.Director == x.Name).Select(z => z.Name))}")));
    }
}