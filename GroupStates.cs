using System;

namespace WeekSix
{
    public class GroupStates
    {
        public static void Grouping(List<string> states, int n)
        {
            states = new List<string> {
                "Abia", "Adamawa", "Akwa-Ibom", "Anambra", "Bauchi", "Bayelsa",
                "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Edo",
                "Ekiti", "Enugu", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano",
                "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa",
                "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers",
                "Sokoto", "Taraba", "Yobe", "Zamfara"
            };

            // Number of groups
            Console.WriteLine("Enter desired number of groups: ");
            n = int.Parse(Console.ReadLine()); // Change this to desired number of groups

            // Calculate number of states in each group
            int statesPerGroup = states.Count / n;
            int remainder = states.Count % n;

            // Grouping the states
            var groupedStates = states.Select((value, index) => new { value, index })
                .GroupBy(x => x.index / statesPerGroup + (x.index % statesPerGroup < remainder ? 0 : 1))
                .Select(g => g.Select(x => x.value).ToList())
                .ToList();

            // Displaying the groupsj
            int groupCount = 1;
            foreach (var group in groupedStates)
            {
                Console.WriteLine($"Group {groupCount++} of states in set of {statesPerGroup + (groupCount <= remainder ? 1 : 0)}:");
                Console.WriteLine("============================");
                Console.WriteLine(string.Join(", ", group));
                Console.WriteLine("-------------------------------------------------------------------");
            }
        }
    }
}
