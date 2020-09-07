using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder{
    class ColorCoder{
        private static Color[] colorMapMajor;
        private static Color[] colorMapMinor; 
        static ColorCoder(){
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
        internal static ColorPair GetColorFromPairNumber(int pairNumber){
            int minorSize = colorMapMinor.Length;
            int majorSize = colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize){
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
            ColorPair pair = new ColorPair() { majorColor = colorMapMajor[majorIndex],
                minorColor = colorMapMinor[minorIndex] };
                return pair;
        }
        internal static int GetPairNumberFromColor(ColorPair pair){
            int majorIndex = -1;
            for (int i = 0; i < colorMapMajor.Length; i++){
                if (colorMapMajor[i] == pair.majorColor){
                    majorIndex = i;
                    break;
                }
            }
            int minorIndex = -1;
            for (int i = 0; i < colorMapMinor.Length; i++){
                if (colorMapMinor[i] == pair.minorColor){
                    minorIndex = i;
                    break;
                }
            }
            if (majorIndex == -1 || minorIndex == -1){
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
