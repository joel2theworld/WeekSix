namespace WeekSix
{
    public class AlphabeticalStates
    {
        public static void AlphabeticalGrouping(List<string> states)
        {
            // List of 36 states in Nigeria
            states = new List<string> {
                "Abia", "Adamawa", "Akwa-Ibom", "Anambra", "Bauchi", "Bayelsa",
                "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Edo",
                "Ekiti", "Enugu", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano",
                "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa",
                "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers",
                "Sokoto", "Taraba", "Yobe", "Zamfara"
            };

            // Grouping the states by first letter
            var groupedStates = from state in states
                                group state by state[0] into g
                                orderby g.Key
                                select new { Letter = g.Key, States = g };

            // Printing the groups
            foreach (var group in groupedStates)
            {
                Console.WriteLine($"States starting with '{group.Letter}':");
                Console.WriteLine($"Count: {group.States.Count()}");
                Console.WriteLine(string.Join(", ", group.States));
                Console.WriteLine();
            }
        }
    }
}
