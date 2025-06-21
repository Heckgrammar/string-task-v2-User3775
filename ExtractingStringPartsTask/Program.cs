namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";
            // output the length of state

            // Concatenate the contents of city and landmark * don't forget to add a space

            // output the first character of country

            // output a concatenation of the first and last characters of city

            // output the substring of landmark starting at c and outputting to the end

            // output the substring of country starting at the first S and ending at the first A

            // output the position of f in California

            //************CHALLENGE****************//
            // Output how many vowels are in each of the strings in the format
            // California has n vowels




            // Show your evidence of the program running in the Readme file
            Console.WriteLine("Length of state name: " + state.Length);
            Console.WriteLine("Concatenation of city name and landmark: " + city + " " + landmark);
            Console.WriteLine("First character of country name: " + country[0]);
            Console.WriteLine("Concatenation of first and last characters of city: " + city[0] + city[city.Length - 1]);
            Console.WriteLine("Substring of landmark starting at c: " + landmark.Substring(landmark.IndexOf('c')));
            Console.WriteLine("Substring of country from first S to first A: " + country.Substring(country.IndexOf('S'), country.IndexOf('A') - country.IndexOf('S')));
            Console.WriteLine("Position of letter 'f' in state: " + (state.IndexOf('f') + 1));
           // Console.WriteLine("California has " + CountVowels(state) + " vowels");
        }
    }
}
