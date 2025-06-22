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
            int countryVowels = 0;
            int stateVowels = 0;
            int cityVowels = 0;
            int landmarkVowels = 0;
            Console.WriteLine("length of state name is " + state.Length);
            Console.WriteLine("concatenation of city name and landmark is " + city + " " + landmark);
            Console.WriteLine("first character of country name is " + country[0]);
            Console.WriteLine("concatenation of first and last characters of city is " + city[0] + city[city.Length - 1]);
            Console.WriteLine("substring of landmark starting at c is " + landmark.Substring(landmark.IndexOf('c')));
            Console.WriteLine("substring of country from first S to first A is " + country.Substring(country.IndexOf('S'), country.IndexOf('A') - (country.IndexOf('S') - 1)));
            Console.WriteLine("position of letter 'f' in state is " + (state.IndexOf('f') + 1) + " out of " + state.Length);
           
            for(int i = 0; i < country.Length; i++)
            {
                if ("aeiouAEIOU".Contains(country[i]))
                {
                    countryVowels++;
                }
            }
            for (int i = 0; i < state.Length; i++)
            {
                if ("aeiouAEIOU".Contains(state[i]))
                {
                    stateVowels++;
                }
            }
            for (int i = 0; i < city.Length; i++)
            {
                if ("aeiouAEIOU".Contains(city[i]))
                {
                    cityVowels++;
                }
            }
            for (int i = 0; i < landmark.Length; i++)
            {
                if ("aeiouAEIOU".Contains(landmark[i]))
                {
                    landmarkVowels++;
                }
            }

            Console.WriteLine("United States of America has " + countryVowels + " vowels");
            Console.WriteLine("California has " + stateVowels + " vowels");
            Console.WriteLine("San Fransicso has " + cityVowels + " vowels");
            Console.WriteLine("Alcatraz Island has " + landmarkVowels + " vowels");
        }
    }
}
