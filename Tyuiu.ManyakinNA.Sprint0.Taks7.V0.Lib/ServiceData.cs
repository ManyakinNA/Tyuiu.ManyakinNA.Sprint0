﻿namespace Tyuiu.ManyakinNA.Sprint0.Taks7.V0.Lib
{
    public class ServiceData
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
        int[] resultArray = new int[5];
           
            for (var i = 0; i < numOne.Length; i++)
               
                resultArray[i] = numOne[i] + numTwo[i];
           
            return resultArray;
        }    
    
      
    }
}
