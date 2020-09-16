using System;
using System.Linq;

public class DigPow {
  public static long digPow(int n, int p) {
    
    //split the digits
    var digits = n.ToString().Select(x=>int.Parse(x.ToString()));
    var total = 0;
    foreach(var x in digits)
    {
      total += IntPow(x, p);
      p += 1;
    }    
    return (total % n) == 0 ? total/n : -1;
  }
  
  //alternative for Math.Pow
  public static int IntPow(int a, int b)
  {
    int result = 1;
    for (int i = 0; i < b; i++)
      result *= a;
    return result;
  }
}
