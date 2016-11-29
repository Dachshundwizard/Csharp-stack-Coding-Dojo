using System;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //# 1 Print 1-255
            // for (int i = 1; i <= 255; i++)
            // {
            //     Console.WriteLine(i);
            // }

            //#2 Print odd numbers between 1-255

            // for(int i = 1; i<=255; i++){
            //     if(i % 2 == 1){
            //         Console.WriteLine(i);
            //     }
            // }

            //#3 Print Sum
            // int sum = 0;
            // for(int i = 0; i <=255; i++ ){
            //     sum += i;
            //     Console.WriteLine(i + " " + sum);
            // }

            //#4 Iterating through an Array
            // int[] x = {1, 2, 3, 4, 5};
            // for(int i = 0; i < x.Length; i++){
            //     Console.WriteLine(x[i]);
            // }
            
            //#5 Find Max
            // int[] Arr; 
            // Arr = new int[] {-3,-5,-7};
            // int max = Arr[0];
            // for(int i = 0; i < Arr.Length; i++){
            //     if(Arr[i] > max) {
            //         max = Arr[i];
            //     }
            // }
            // Console.WriteLine(max);
            
            //#6 Get Average
            // int [] Arr;
            // Arr = new int[] {2,10,3};
            // int sum = 0;
            // for(int i = 0; i < Arr.Length; i++){
            //     sum += Arr[i];
            // }
            // int avg = sum/Arr.Length;
            // Console.WriteLine(avg);
        
        //#7 Array with odd numbers
    //   var oddArray = new int[128];

    //        for (int i = 0, odd = 1; i < oddArray.Length; i++, odd += 2)
    //        {
    //            oddArray[i] = odd;
    //            Console.WriteLine(oddArray[i]);
    //        }

    //#8: Print Integers Greater Than Y
        //    int[] array;
        //    array = new int[] {1,3,5,7,9,13};
        //    int y = 6;
        //    int count = 0;
        //    for(int i = 0; i < array.Length; i++) {
        //        if(array[i] > y) {
        //            count ++;
        //        }
        //    }
        //    Console.WriteLine(count);

        // #9: Square Integers of Array
        //    int[] array;
        //    array = new int[] {1,3,5,7,9,13};
        //    for(int i = 0; i < array.Length; i++) {
        //        array[i] = array[i] * array[i];
        //        Console.WriteLine(array[i]);
        //    }
    // #10: Eliminate Negative Numbers in Array
        //    int[] array;
        //    array = new int[] {1,-3,5,-7,9,-13};
        //    for(int i = 0; i < array.Length; i++) {
        //        if(array[i] < 0){
        //            array[i] = 0;
        //            Console.WriteLine(array[i]);
        //        }else{
        //            Console.WriteLine(array[i]);
        //        }
        //    }
           // #11: Min, Max, Average of Array
        //    int[] array;
        //    array = new int[] {1,-3,5,-7,9,-13};
        //    int min = array[0];
        //    int max = array[0];
        //    int sum = 0;
        //    for(int i = 1; i < array.Length; i++) {
        //        if(min > array[i]) {
        //            min = array[i];
        //        }
        //        if(max < array[i]) {
        //            max = array[i];
        //        }
        //        sum = sum + i;
        //    }
        //    int avg = sum / array.Length;
        //    Console.WriteLine("Average: " + avg);
        //    Console.WriteLine("Min: " + min);
        //    Console.WriteLine("Max: " + max);
            
            // #12 Shifting Values in Array
        //    int[] array;
        //    array = new int[] {1,-3,5,-7,9,-13};
        //    for(int i = 0; i < array.Length; i++) {
        //        array[i] = array[i + 1];
        //        Console.WriteLine(array[i]);
        //    }
           // #13 Number To String 
        //    int[] array2;
        //    array2 = new int[] {1,-3,5,-7,9,-13};
        //    for(int i = 0; i < array2.Length; i++) {
        //        if(array2[i] < 0){
        //            string myString = array2[i].ToString();
        //            myString = "Dojo";
        //            Console.WriteLine(myString);
        //        }else{
        //            Console.WriteLine(array2[i]);
        //        }
        //    }
        }
    }
}