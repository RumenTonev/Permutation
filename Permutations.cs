using System;
using System.Collections.Generic;

    class Permutations
    {
        static void permutate(List<int> intList,int permutationNumber)//method to calculate current member of any permutation, and on
        {                                               //the bottom of recursion prints current permutation
            bool isNotIn=true;// boolean variable holding value either given value of 1 to N sequence is presented in the array list at the moment
            if(intList.Count==permutationNumber)//boottom of recursion
            {
                for (int index = 0; index <= permutationNumber-1; index++)
                { 
                    Console.Write(intList[index] + " ");
                }
                Console.WriteLine();
            return;
            }
            for(int currentNumber=1;currentNumber<=permutationNumber;currentNumber++)
            {
                isNotIn = true;
                List<int> newList = new List<int>(intList);//keep values
                for(int currentListNumber=0;currentListNumber<=intList.Count-1;currentListNumber++)
                {
                    if(currentNumber==intList[currentListNumber])
                    {
                        isNotIn=false;break;
                    }
                }
                if (isNotIn)//if current i is not in the intList,add it to intList,and make next reccursion step
                { intList.Add(currentNumber);
                    permutate(intList, permutationNumber); 
                    intList = new List<int>(newList);
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("That program takes number N and generates and prints all the permutations of the numbers [1 … N ]");
            int permutationNumber = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();//array to hold current permutation
            List<int> newList = new List<int>(intList);// copy of current array,used after one steup up of reccursion
            for (int i = 1; i <= permutationNumber; i++)
            {
                intList.Add(i);//add first element of nay permutation
                permutate(intList, permutationNumber);//method for calucalating and printing permutations
                intList = new List<int>(newList);//assign intList with its valkues before entering reccursion
            }
        }
    }

