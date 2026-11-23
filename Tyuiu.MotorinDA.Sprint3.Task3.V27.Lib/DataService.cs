using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MotorinDA.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            string digitsOnly = "";

            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    digitsOnly += c;
                }
            }

            return int.Parse(digitsOnly);
        }
    }
}
