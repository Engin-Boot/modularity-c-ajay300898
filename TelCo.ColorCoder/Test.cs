using System;
using System.Diagnostics;
using System.Drawing;


namespace TelCo.ColorCoder{
  class Test{
    public void test(){
      int pairNumber = 4;
      ColorPair testPair1 = Program.GetColorFromPairNumber(pairNumber);
      Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
      Debug.Assert(testPair1.majorColor == Color.White);
      Debug.Assert(testPair1.minorColor == Color.Brown);

      pairNumber = 5;
      testPair1 = Program.GetColorFromPairNumber(pairNumber);
      Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
      Debug.Assert(testPair1.majorColor == Color.White);
      Debug.Assert(testPair1.minorColor == Color.SlateGray);

      pairNumber = 23;
      testPair1 = Program.GetColorFromPairNumber(pairNumber);
      Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
      Debug.Assert(testPair1.majorColor == Color.Violet);
      Debug.Assert(testPair1.minorColor == Color.Green);

      ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
      pairNumber = Program.GetPairNumberFromColor(testPair2);
      Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
      Debug.Assert(pairNumber == 18);

      testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
      pairNumber = Program.GetPairNumberFromColor(testPair2);
      Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
      Debug.Assert(pairNumber == 6);
    }
  }
}
