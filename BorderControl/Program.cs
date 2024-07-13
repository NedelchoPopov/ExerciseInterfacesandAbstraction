/*
Peter 22 9010101122
MK-13 558833251
MK-12 33283122
End
122
*/
namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            var entities = new List<IIdentifiable>();

            string input;
            while ((input = Console.ReadLine()) != "End") 
            {
                var data = input.Split();

                if (data.Length == 2)
                {
                    var robot = new Robot(data[0], data[1]);
                    entities.Add(robot);
                }
                else if (data.Length == 3)
                {
                    var citizen = new Citizen(data[0], int.Parse(data[1]), data[2]);
                    entities.Add(citizen);
                }

                
            }

            var suffix = Console.ReadLine();

            var detained = entities.Where(e => e.Id.EndsWith(suffix)).ToArray();
            foreach (var entity in detained)
                Console.WriteLine(entity.Id);
        }
    }
}
