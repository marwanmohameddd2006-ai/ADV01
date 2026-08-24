using Assignment_1_ADV.Q014;
using Assignment_1_ADV.Q015;
using Assignment_1_ADV.Q10;
using Assignment_1_ADV.Q11;

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

            #region Q08
            //Q:  What is the 'class' constraint? Write an example
            /*Ans
             * What ==> the 'struct' constraint allow only Reference types
             */

            //Test2<int> t1 = new Test2<int>(); //// invalid because int is Value type
            //Test2<string> t2 = new Test2<string>(); //// valid because string is Reference type

            #endregion

            #region Q09
            //Q:  What is the 'new()' constraint? Write an example
            /*Ans
             * What ==> the 'new()' constraint requires the type argument to have a public parameterless constructor.
             */

            //Test3<Person> t1 = new Test3<Person>();     // invalid becase person not have parameterless constructor
            // Test3<Person2> t2 = new Test3<Person2>(); // valid becase person2  have parameterless constructor
            #endregion

            #region Q10
            // //Q:  What is the interface constraint? Write an example
            // /*Ans
            //  * What ==> the interface constraint required that type must implement a specific interface.
            //  */

            // Printer<Test4> t4 = new Printer<Test4>();// valid becase Test4  implement interface
            // t4.print2(new Test4());
            //// Printer<string> t5 = new Printer<string>(); // invalid becase string donot implement interface
            #endregion

            #region Q11
            ////Q:  What is the base class constraint? Write an example

            ///*Ans
            // * What ==>  base class constraint required T is base class or any class inherit from base calss
            // */

            //MustBase<Child1> ch1 = new MustBase<Child1>(); // vaild becaus inherit from base
            //ch1.DisPlay(new Child1());
            ////MustBase<Child2> ch2 = new MustBase<Child2>(); // invaild becaus donot inherit from base
            #endregion

            #region Q12
            ////Q: How do you apply multiple constraints? Write an example
            //MustBase<Child1> ch1 = new MustBase<Child1>();// vaild becaus inherit from base , implement interface and have parameterless constructor
            //MustBase<Child2> ch2 = new MustBase<Child2>(); // invaild becaus donot inherit from base, implement interface and have parameterless constructor
            #endregion

            #region Q13
            //Q:What does the 'default' keyword do in generics?

            /*Ans 
             * the default keyword in generics returns the default value of a type parameter T.
             */
            #endregion

            #region Q14

            //SafeList<string> list = new SafeList<string>();
            //list.Add("Ahmed");
            //list.Add("Mahmoud");
            //list.Add("Khaled");


            //Console.WriteLine($"Element at index 0:{list.GetElementAt(0)}");
            //Console.WriteLine($"Element at index 5:{list.GetElementAt(5)??"Null"}");

            #endregion

            #region Q15
            //Q: What is covariance? Explain the 'out' keyword
            /*Ans
             * What => Use the out keyword to specify that the type parameter is used only as output (return type).
                       It enables covariance. 
             */

            //CatShelter catShelter = new CatShelter();
            //Console.WriteLine( catShelter.GetAnimal().Name);
            //
            //
            //IShelter<Animal> animalShelter = catShelter;
            //Console.WriteLine(animalShelter.GetAnimal().Name);
            #endregion

            #region Q016
            //Q:  What is contravariance? Explain the 'in' keyword

            /*Ans
             * What => Use the in keyword to specify that the type parameter is used only as input (in parameter).
                       It enables contravariance.
             */

            //CatShelter catShelter2 = new CatShelter();
            //Console.WriteLine( catShelter2.GetAnimal().Name);


            //IShelter2<Cat> shelter = new AnimalShelter();

            //shelter.Treat(new Cat("C01"));
            #endregion

            #region Q17
            //Q:  What is the difference between covariance and contravariance?

            /*Ans 
             *  Keyword =>   ( covariance : out ) , ( contravariance: in )
             *  Direction => ( covariance : Derived → Base ) , ( contravariance: Base → Derived )
             */
            #endregion

            #region Q18
            //Q:  What is the difference between covariance and contravariance?

            /*Ans 
             *  Static members in generic types are shared by all objects of the same constructed type, 
             *  but each different type argument gets its own separate static member.
             */
            #endregion

        }
    }
}
