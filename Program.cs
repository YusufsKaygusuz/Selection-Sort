using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        //İndissel mantıkla çözümleme yapıyoruz.
        static void Main(string[] args)
        {
            int[] Numbers = new int[] {12,8,27,2,6,19,10};

            for (int i = 0; i < Numbers.Length; i++)
            {
                int min = i;
                for(int j=i+1; j<Numbers.Length; j++)
                {
                    if (Numbers[j] < Numbers[min])
                        min = j;
                }
                int temp = Numbers[min];
                Numbers[min] = Numbers[i];
                Numbers[i] = temp;
            }

            foreach (var item in Numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.Read();

        }
        /*
        public void SelectionMethod(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                //En küçük elemeanı bulmamızı sağlayan döngü
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;

            }
        }
        */
    }
}
