/**
The challenge:
https://www.hackerrank.com/challenges/ctci-array-left-rotation

A left rotation operation on an array of size  shifts each of the array's elements  unit to the left. For example, if left rotations are performed on array , then the array would become .

Given an array of  integers and a number, , perform  left rotations on the array. Then print the updated array as a single line of space-separated integers.

Input Format

The first line contains two space-separated integers denoting the respective values of  (the number of integers) and  (the number of left rotations you must perform). 
The second line contains  space-separated integers describing the respective elements of the array's initial state.

Constraints

Output Format

Print a single line of  space-separated integers denoting the final state of the array after performing  left rotations.

Sample Input

5 4
1 2 3 4 5
Sample Output

5 1 2 3 4
Explanation

When we perform  left rotations, the array undergoes the following sequence of changes:

Thus, we print the array's final state as a single line of space-separated values, which is 5 1 2 3 4.

**/



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class LeftRotate 
{

    static void Main(String[] args) 
    
    {
        int i, j, z;
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        
        int[] temparray = new int[2*n];
        
        //constraints
        if(n >= 100000 || n < 1 )
            {
            System.Environment.Exit(1);
            }
        
        if(k > n || n < 1 )
            {
            System.Environment.Exit(1);
            }  
  
        for(i = 0; i< n; i++)
        {
               if(a[i] > 1000000 || a[i] < 1 )
               {
               System.Environment.Exit(1);
               }     
         } 
  

        for(j = 0; j<n; j++) //n = 5 k = 4...... (2-4) % 5 = 2 
            {
            z = (j-k) %n; //(0-4) = 4 % 5 = 1
            
            if(z != 0)
                {
                z= (n+ z) %n; //(5+4) = 9 % 5 = 4 ..... (4+2) = 6 & 5 = 1
                }
            
            temparray[z] = a[j]; // temp[4] = a[0] temp[1] = a[1]
            }
      
        //view array
        for(i = 0; i< n; i++)
            {
        Console.Write(temparray[i] + " " );      
            }
        
            
    }
}