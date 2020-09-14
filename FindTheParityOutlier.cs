using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    var evenArr = new List<int>();
    var oddArr = new List<int>();
    foreach(int i in integers)
    {
      if(i % 2 == 0) 
      {
        evenArr.Add(i);
      }else
      {
        oddArr.Add(i);   
      }
      
    }
    return (evenArr.Count == 1 ? evenArr[0] : oddArr[0]);
  }
}
