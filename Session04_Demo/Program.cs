using System.Text;

namespace Session04_Demo
{
    class Employee
    {
        public string fName { get; set; }
        public string? lName { get; set; }
    }
    internal class Program
    {
        public static void Print(int count, string Pattern)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Pattern);
            }
        }
        public static void PrintPattern(int count = 10, string Pattern = "$_$")
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Pattern);
            }
        }
        //public static void Swap(int x, int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}
        public static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        //public static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    if (Arr != null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            Sum += Arr[i];
        //        }
        //    }
        //    return Sum;
        //}
        //public static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    if (Arr != null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            Sum += Arr[i];
        //        }
        //    }
        //    return Sum;
        //}
        //public static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;
        //    //Arr[0] = 100;
        //    Arr = new int[] { 4, 5, 6 };

        //    if (Arr != null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            Sum += Arr[i];
        //        }
        //    }
        //    return Sum;
        //}
        public static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            //Arr[0] = 100;
            Arr = new int[] { 4, 5, 6 };

            if (Arr != null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    Sum += Arr[i];
                }
            }
            return Sum;
        }
        public static void SumMul(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;

        }
        public static int SumArrayParams(params int[] Arr)
        {
            int Sum = 0;
            if (Arr != null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    Sum += Arr[i];
                }

            }
            return Sum;
        }
        public static void DoSomeCode()
        {
            try
            {
                int x, y, z;
                Console.WriteLine("Enter x");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter y");
                y = int.Parse(Console.ReadLine());
                z = x / y;
                int[] arr = { 1, 2, 3 };
                arr[100] = 22;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public static void DoSomeProtectiveCode()
        {
            int x, y, z;
            //bool flag;
            do
            {
                Console.WriteLine("Enter x");
                //flag = int.TryParse(Console.ReadLine(), out x);
            }while(!int.TryParse(Console.ReadLine(), out x));
            do
            {
                Console.WriteLine("Enter y");
                //flag = int.TryParse(Console.ReadLine(), out x);
            } while (!int.TryParse(Console.ReadLine(), out y) && y ==0);
            z = x / y;

            int[] arr = { 1, 2, 3 };
            if (arr?.Length > 100)
            {
                arr[100] = 22;
            }
            else
            {
                Console.WriteLine("Out of Range");
            }
        }
        static void Main(string[] args)
        {
            #region String vs. StringBuilder
            //string Name01;
            //Name01 = new string("Rana");
            //string Name02 = "Heba";
            //Name02 = Name01;
            //Name01 = "Omar";
            //Console.WriteLine(Name01);
            //Console.WriteLine(Name02);
            //String is imutable and can not be changed

            //string Msg = "Hello,";
            //Console.WriteLine(Msg);
            //Console.WriteLine(Msg.GetHashCode());
            //Msg += " Route"; //Create new object with new identity
            //Console.WriteLine(Msg);
            //Console.WriteLine(Msg.GetHashCode());
            //------------------------------------------//

            //StringBuilder
            //StringBuilder SB = new StringBuilder();
            //SB.Append("Hello");
            //Console.WriteLine(SB);
            //Console.WriteLine(SB.GetHashCode());
            //SB.Append(" Route");
            //Console.WriteLine(SB);
            //Console.WriteLine(SB.GetHashCode());
            // StringBuilder is Reference Type and work as reference type

            #endregion
            #region Arrays
            #region 1D Arrays
            //int[] Numbers;
            //// Refering to the default value of reference type (Null)
            //// Declare reference of type array
            //// CLR will allocate bytes at the stack for the reference (4 bytes)
            //// CLR will allocate 0 bytes at heap
            //Numbers = new int[3]; //Allocate 12 bytes at heap
            //// Initialization with default value of 0
            //Console.WriteLine(Numbers[0]);
            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;
            //Console.WriteLine(Numbers[0]);
            //int[] Numbers2 = new int[3] { 1, 2, 3 };
            //Console.WriteLine(Numbers2[1]);
            //int[] Numbers3 = new int[] { 1, 2 };
            //int[] Numbers4 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Size of array is: {Numbers4.Length}, Number of Dimension is: {Numbers4.Rank}");
            //for ( int i = 0; i < Numbers4.Length; i++ )
            //{
            //    Console.WriteLine(Numbers4[i]);
            //}
            #endregion
            #region 2D Arrays
            //int[,] Marks = new int[3, 5] { { 55, 66, 77, 88, 99 }, { 55, 66, 77, 88, 99 }, { 55, 66, 77, 88, 99 } };
            //// new => Allocate required bytes at heap  15 * 4  = 60 Byte
            //Console.WriteLine($"Size of Array = {Marks.Length}, Dimension = {Marks.Rank}");

            //int[,] Marks = new int[2, 4];
            //Console.WriteLine(Marks.GetLength(0));
            //Console.WriteLine(Marks.GetLength(1));
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Marks of Student {i+1}");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter Sub Num {j+1}");
            //        Marks[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Grades of Student {i+1}:");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Grade of Subject {j+1}: ");
            //        Console.WriteLine(Marks[i,j]);
            //    }
            //}
            #endregion
            #region Judged Arrays
            // Is a one D array of arrays with different sizes
            //int[][] Numbers = new int[3][];
            //Numbers[0] = new int[] { 1, 2, 3 };
            //Numbers[1] = new int[] { 4, 5 };
            //Numbers[2] = new int[] { 6 };
            ////Print
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    for (int j = 0; j < Numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(Numbers[i][j]);
            //    }
            //}


            #endregion
            #region Arrays Methods
            //int[] Nums = { 5, 1, 5, 4, 3, 10, 7 };
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[5];
            #region Class Member Methods [Statics Methods]
            //Array.Sort(Nums);
            //Array.Copy(Arr01, Arr02, 2);
            //foreach (int i in Arr02)
            //{
            //    Console.WriteLine(i);
            //}
            //Array.Clear(Nums);
            //Array.ConstrainedCopy(Arr01, 1, Arr02, 1, 2);
            //int[] Arr03 = (int[])Array.CreateInstance(typeof(int), 10); // new int[10] 
            //int[,,] Arr04 = (int[,,])Array.CreateInstance(typeof(int), 2,4,3);
            #endregion
            #region Object Member Method
            //Arr01.CopyTo(Arr02, 1);
            //foreach (int i in Arr02)
            //{
            //    Console.WriteLine(i);
            //}
            //Arr01.SetValue(100, 1);
            //Console.WriteLine(Arr01[1]);

            #endregion
            #endregion
            #endregion
            #region Functions
            #region Prototype and Calling
            ///*Program.*/Print(5, "@_@");
            //PrintPattern(6);
            //PrintPattern(Pattern: "):", count: 6);
            #endregion
            #region Passing By Value
            //int a = 3, b = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            #region Passing By Reference
            //int a = 3, b = 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            #region Passing By Value Ex01 (Passing Reference Type)
            //int[] Numbers = { 1, 2, 3 };
            //int Resault = SumArray(Numbers);
            //Console.WriteLine(Resault);
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Passing By Reference Ex01 (Passing Reference Type)
            //int[] Numbers = { 1, 2, 3 };
            //int Resault = SumArray(ref Numbers);
            //Console.WriteLine(Resault);
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Passing By Value Ex02 (Passing Reference Type)
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers[0]);
            //int Resault = SumArray(Numbers);
            //Console.WriteLine(Resault);
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Passing By Reference Ex02 (Passing Reference Type)
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers[0]);
            //int Resault = SumArray(ref Numbers);
            //Console.WriteLine(Resault);
            //Console.WriteLine(Numbers[0]);
            #endregion
            #region Passing By out
            //int a = 10, b = 5;
            //int sum, mul;
            //SumMul(a, b, out sum, out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);
            #endregion
            #region params
            //int sum = SumArrayParams(1,2,3,4,5,6,7,8,9);
            //Console.WriteLine(sum);
            #endregion
            #endregion
            #region Boxing vs. Unboxing
            // Boxing: Casting from datatype (value type) to datatype (reference type)
            // Unboxing Casting from datatype (reference type) to datatype (value type)
            #region Ex01
            //object obj;
            //obj = new object();
            //obj = new string("Rana");
            //obj = 'A'; // casting from char (value type) to object (reference type) implicitly (boxing)
            //obj = 3;
            //obj = true;
            //bool flag = (bool)obj; //unboxing Explicit casting unsafe
            #endregion
            #region Ex02
            //int x = 5;
            //object o1 = x;
            // Parent = child
            // animal = dog
            // boxing
            //Console.WriteLine(o1);

            //object o2 = 10;
            //o2 = "Ahmed";
            //int y = (int)o2;
            // Unboxing
            // Explicit
            // unsafe casting
            // child = parent
            // dog = animal
            #endregion
            #endregion
            #region Nullable Value Type
            // null is valid for reference values only
            //int? age = 10; // allows null for int (syntax sugar)
            //age = null;
            //Nullable<int> age = 10;
            //age = null;
            //double? sal = 22.5;
            //sal = null;
            #endregion
            #region Nullable Reference Type
            //string msg = "hi";
            //msg = null;
            //string? message = null;

            //string NotNull = "Hello";
            //string? Nullable = default;
            //NotNull = Nullable!; //Null forgivness
            #endregion
            #region How to work with nullable value type
            //int x = 5;
            //int? y;
            //y = x; //implicit casting
            ////--------------------------
            //int? k = 10;
            //k = null;
            //int l = 20;
            //// protective code
            ////if (k != null)
            ////{
            ////    l = (int)k; // unsafe casting Explicit
            ////}
            ////else
            ////{
            ////    l = 0;
            ////}
            //l = k.HasValue ? k.Value : l;
            ////coleasing operator
            //l = k ?? 0; // syntax sugar for l = k.HasValue ? k.Value : l;
            #endregion
            #region Null Propagation Operator
            //double x = default;
            //int[]? Numbers = default;
            //for (int i = 0; Numbers != null && i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //if (Numbers != null)
            //{
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}
            //for (int i = 0; i < Numbers?.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //int? len = Numbers?.Length;
            //Numbers != null ? Numbers.Length : null;
            //int len = Numbers?.Length ?? 0;
            #endregion
            #region Exception Handling and Protective Code
            //DoSomeCode();
            DoSomeProtectiveCode();
            #endregion
        }
    }
}
