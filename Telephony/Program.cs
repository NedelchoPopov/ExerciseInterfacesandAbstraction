/*
0882134215 0882134333 0899213421 0558123 3333123
http://softuni.bg http://youtube.com http://www.g00gle.com
*/
namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            var smartPhone = new SmartPhone();
            var stationaryPhone = new StationaryPhone();

            foreach (var phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Any(x => !char.IsDigit(x))) Console.WriteLine("Invalid number!");
                else if (phoneNumber.Length == 10) Console.WriteLine(smartPhone.Call(phoneNumber));
                else if (phoneNumber.Length == 7) Console.WriteLine(stationaryPhone.Call(phoneNumber));
            }

            foreach (var website in websites)
            {
                if (website.Any(char.IsDigit)) Console.WriteLine("Invalid URL!");
                else Console.WriteLine(smartPhone.Browse(website));
            }

        }
    }
}
