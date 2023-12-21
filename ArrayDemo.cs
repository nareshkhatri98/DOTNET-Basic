using System;


namespace swscbasic
{
    class ArrayDemo
    {

        public void accessArray()
        {
            // creating array
            // direct method: of value has to be directly insert
            int[] marks = { 4, 3, 4, 5, 6, 7, 8 };
            // using new keyword
            string[] name = new string[4];
            name[0] = "a";
            name[1] = "b";
            name[2] = "c";
            name[3] = "d";
            // finding out size of array: no of elements in array
            Console.WriteLine("size of first array" + marks.Length);
            Console.WriteLine("size of second array" + name.Length);
            // printing array using loop
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("--example on Multidimensional array");

            // declearing 2D int array..
            int[,] score =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            //Declearing 2D array..
            string[,] programs =
            {
                {"bca", "bin", "csit" },
                {"bbs", "bbm", "bba" },
                {"ba","bsw","B.Ed" }

            };

            //printhing 2d array using for loop
            for (int i = 0; i < score.GetLength(0); i++)
            {
                for (int j = 0; j < score.GetLength(1); j++)
                {
                    Console.Write(score[i, j]);
                }
                Console.WriteLine();
            }
            // using foeach loop to print second array(program)
            foreach (string var in programs)
            {
                Console.WriteLine(var);
            }
            // jagged  array..
            // such array which donot have equal number of column  i.e each row can have different number of column(data).
            // eg first row can have 3 column , 2and row can have 5 column so on..
            //declaring jagged array..
            int[][] data = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[] {6,7,8},
                new int[] {12,13},
                new int[] {14,15,16}

            };

            // printing jagged array
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("row = ");


                for (int j = 0; j < data[i].GetLength(0); j++)
                {
                    Console.Write(data[i][j]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("--- find out the sum of each row---");

            for( int i = 0; i<data.Length; i++)
            {
                int Sum = 0;
                for(int j=0; j < data[i].Length; j++)
                {

                    Console.Write(data[i][j] + " ");
                   
                    Sum = Sum + data[i][j];
                }
                Console.WriteLine("the sum of row " +Sum  );
                Console.WriteLine();
            }
        }
        }
    }
    

