using System.Data;

namespace Tyuiu.AntonovNs.Sprint7.Project.V0.Lib
{
    public class DataService
    {
        public int SumTen(string[] array) 
        {
            int c = 0;
            for (int i = 0;i<array.Length;i++) 
            {
                if (array[i] == "10") 
                {
                    c++;
                }
            }
            return c;
        }
        public int SumTwo(string[] array)
        {
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "20")
                {
                    c++;
                }
            }
            return c;
        }
        public int SumFre(string[] array)
        {
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "30")
                {
                    c++;
                }
            }
            return c;
        }
        public int SumFour(string[] array)
        {
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "40")
                {
                    c++;
                }
            }
            return c;
        }
        public int SumFive(string[] array)
        {
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "50")
                {
                    c++;
                }
            }
            return c;
        }
    }
}
