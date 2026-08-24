namespace Assignment_1_ADV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Q:  What is a generic class? Why use generics?

            /*Ans
             * What ==> generic allow you to write class with type pramaters
                        The actual type is specified when the cod is used
                       
             * Why ==> Typ Safe
                       Reusable
                       Better Performance
                       Clean Code
             */
            #endregion

            #region Q02
            //Q: : Write a generic class Container<T> with Add and Get methods.

            //Container<int> num = new Container<int>();
            //num.SetNum(1);
            //Console.WriteLine(num.GetNum());

            #endregion

            #region Q03
            ////Q: What are multiple type parameters? Write Pair<TKey, TValue>

            ///*Ans
            // * What ==> generic class can have more than one type paramater
            // */

            //EmployeePair<int, string> E1 = new EmployeePair<int, string>(10, "Marwan");
            //Console.WriteLine($"First=> {E1.First} , Secound=> {E1.Second}");

            #endregion

            #region Q04
            //Q: What is a generic method? Write Swap<T> method

            /*Ans 
             * What => generic allow you to write method with type pramaters
                        The actual type is specified when the cod is used
                        When class not generic
             */
            //int x = 10;
            //int y = 20;
            //Console.WriteLine($"Befor Swap X=> {x} , Y=> {y}");
            //Swap.SwapMethod(ref x, ref y);
            //Console.WriteLine($"After Swap X=> {x} , Y=> {y}");

            #endregion

            #region Q05
            //int[] items = { 7, 3, 19, 100 };
            //Console.WriteLine($"MaxValue ==> {FindMax.FindMaxMethod(items)}");
            #endregion

            #region Q06
            //Q:  What is a generic interface? Write IRepository<T>

            /*Ans
             * What ==> generic allow you to write interface with type pramaters
                        The actual type is specified when the cod is used 
             */
            // IRepository ==> Create Done

            #endregion

            #region Q07
            ////Q:  What is the 'struct' constraint? Write an example
            ///*Ans
            // * What ==>  the 'struct' constraint allow only value types
            // */

            ////Test1<string> t1 = new Test1<string>(); // invalid because string is Reference type
            //Test1<int> t2 = new Test1<int>(); // valid because int is Value type
            #endregion
        }
    }
}
