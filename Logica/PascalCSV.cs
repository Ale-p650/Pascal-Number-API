using System.Text;

namespace WebApplication2.Logica
{
    public class PascalCSV
    {
        public static string Generate(int numRows)
        {
            StringBuilder sb = new StringBuilder();

            int[][] pascal = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                pascal[i] = generaArr(i);
            }



            int[] generaArr(int num)
            {
                if (num == 0) return new int[] { 1 };
                if (num == 1) return new int[] { 1, 1 };
                else
                {

                    int[] arr = new int[num + 1];
                    arr[0] = 1;
                    arr[arr.Length - 1] = 1;


                    for (int j = 1; j < arr.Length - 1; j++)
                    {
                        arr[j] = pascal[num - 1][j - 1] + pascal[num - 1][j];

                    }
                    return arr;
                }
            }

            for (int i = 0; i < pascal.Length; i++)
            {
                for (int j = 0; j < pascal[i].Length; j++)
                {
                    sb.Append(pascal[i][j]);
                    sb.Append(" ");
                }
                sb.AppendLine();
            }

            return sb.ToString();

        }
    }
}
