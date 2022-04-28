
namespace C_Sharp_Lesson_3_Homework
{
    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            //your code here

            if ((matrixOfIntegers.GetLength(0) % 2 != 0) && (matrixOfIntegers.GetLength(1) % 2 != 0))
            {
                int tempLengthCol = matrixOfIntegers.GetLength(0) / 2;
                int tempLengthRows = matrixOfIntegers.GetLength(1) / 2;
                Console.WriteLine("The central element is " + matrixOfIntegers[tempLengthCol, tempLengthRows]);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a central element");
            }

        }
        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            //your code here
            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                int temp1 = 0;
                int temp2 = 0;
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++ )
                {
                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if (i == j) { temp1 += matrixOfIntegers[i, j]; }
                    }
                }
                //на самом деле не важно гет ленгтх 1 или 0 ибо для наличия диагонали строки и столбцы должны сопадать :)
                 for (int i = matrixOfIntegers.GetLength(0)-1; i >= 0; i-- )
                {
                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if ((i + j) == (matrixOfIntegers.GetLength(0)-1))
                        {

                            temp2 += matrixOfIntegers[i, j];
                           /* Console.WriteLine("temp2:"+ temp2 + " i:" + i + " j:" + j);*/
                        }
                    }
                }
                
                Console.WriteLine("First diagonal: "  + temp1);
                Console.WriteLine("Second diagonal: " + temp2);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have diogonals");
            }


        }
        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            //your code here

 


            for (int i = 1; i <= triangleHight; i++)   
            {
                for (int j = 1; j <= (triangleHight - i); j++)
                    Console.Write(" ");

                for (int j = 1; j <= i; j++)   
                    Console.Write("*");

                for (int j = (i - 1); j >= 1; j--)
                    Console.Write("*");

                Console.WriteLine();
            }

        }
        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            //your code here
 
            List<int> realListofNumbers = new List<int>(listOfNumbers);
            realListofNumbers.Sort();
            foreach ( int digit in realListofNumbers)
            {
                Console.WriteLine(digit);
            }
        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(5);
            homework.SortList(list);
        }

    }
}