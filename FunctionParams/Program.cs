﻿using System;

namespace FunctionParams
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      int number = 20;

      AddFive (number);

      Console.WriteLine (number);
      //Console.ReadKey ();
    }

    // add five to param
    public static void AddFive (int number)
    {
      number += 5;
    }
  }
}
