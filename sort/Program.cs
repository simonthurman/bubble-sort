using System;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int temp1;

            int[] list1= new int[9];
            list1[0]= 8;
            list1[1]= 3;
            list1[2] = 4;
            list1[3] = 5;
            list1[4] = 7;
            list1[5] = 6;
            list1[6] = 2;
            list1[7] = 1;
            list1[8] = 9;
  
            for (int i = 0; i < list1.Length-1; i++)
            {
                    for (int j = 0; j < list1.Length-1; j++)
                    {
                        if (list1[j] > list1[j+1])
                        {
                            temp1 = list1[j];
                            list1[j] = list1[j + 1];
                            list1[j+1] = temp1;
                            i = 0;
                        }
                    }
            }

            for (int k = 0; k < list1.Length; k++)
            {
                Console.WriteLine(list1[k]);
            }

            Console.ReadKey();
        }
    }
}
