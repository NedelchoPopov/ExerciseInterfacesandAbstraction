/*
Citizen Peter 22 9010101122 10/10/1990
Pet Sharo 13/11/2005
Robot MK-13 558833251
End
1990

Citizen Stam 16 0041018380 01/01/2000
Robot MK-10 12345678
Robot PP-09 00000001
Pet Topcho 24/12/2000
Pet Rex 12/06/2002
End
2000

Robot VV-XYZ 11213141
Citizen Corso 35 7903210713 21/03/1979
Citizen Kane 40 7409073566 07/09/1974
End
1975
*/
namespace BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            var identifiableEntities = new List<IIdentifiable>();
            var entitiesWithBirthdate = new List<IWithBirthdate>();

            var input = Console.ReadLine();
            while (input != "End")
            {
                var data = input.Split();

                if (data[0] == "Citizen")
                {
                    var citizen = new Citizen(data[1], int.Parse(data[2]), data[3], data[4]);
                    identifiableEntities.Add(citizen);
                    entitiesWithBirthdate.Add(citizen);
                }
                else if (data[0] == "Pet")
                {
                    var pet = new Pet(data[1], data[2]);
                    entitiesWithBirthdate.Add(pet);
                }
                else if (data[0] == "Robot")
                {
                    var robot = new Robot(data[1], data[2]);
                    identifiableEntities.Add(robot);
                }

                input = Console.ReadLine();
            }

            var suffix = Console.ReadLine();

            var result = entitiesWithBirthdate.Where(e => e.Birthdate.EndsWith(suffix)).ToArray();
            foreach (var entity in result)
                Console.WriteLine(entity.Birthdate);
        }
    
    }
}
