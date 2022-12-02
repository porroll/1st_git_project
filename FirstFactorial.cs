using System;
using System.Collections.Generic;

class MainClass {

public static int FirstFactorial(int num){
  
  int answer = factorial(num);
  
  while (num > 0)
  {
    int n = num;
    List<int> nlist;
    for(int i = n - 1; i > 0; i--)
    {
      nlist.Add(i);
      n *= i;
    }
  }
    return num;    
}

static void Main() 
{  
    // keep this function call here
    Console.WriteLine("Enter number to find the factorial of...");
    FirstFactorial(int(Console.WriteLine(FirstFactorial(Console.ReadLine()))));
    Console.WriteLine("Factorial is " + )
  } 
}