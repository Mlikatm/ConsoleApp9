using System;
namespace project
{
    class test1
    {
        public static void Main()
        {
            int L=Convert.ToInt32(Console.ReadLine());
            int H=Convert.ToInt32(Console.ReadLine());
            int W=Convert.ToInt32(Console.ReadLine());
            double show= Calc( L, H, W );
            Console.WriteLine( show );
        }//end Main
        private static double Calc (int num1,int num2,int num3)
        {
            double Result= num1*num2*num3;
            return Result;
        }//end  function
    }//end class

}//end namespace
