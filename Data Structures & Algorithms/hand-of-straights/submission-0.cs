   public class Solution
   {
       public bool IsNStraightHand(int[] hand, int groupSize)
       {
           Array.Sort(hand);
           //int[][] arrays = new int [hand.Length/groupSize][].Select((int[] x)=>new int[groupSize]).ToArray();
           int counter = 0;
           int[] prevVal = new int[hand.Length/groupSize];
           int[] size = new int[hand.Length / groupSize];
           for (int i = 0; i < prevVal.Length; i++)
           {
               prevVal[i] = int.MinValue;
           }
           prevVal[0] = hand[0] - 1; 
          
           for (int i = 0; i < hand.Length; i++)
           {
               while (hand[i] - prevVal[counter] != 1 || size[counter]>groupSize-1)
               {
                   counter++;
                   if (counter > prevVal.Length - 1) return false;
                   if (prevVal[counter] == int.MinValue)
                   {
                       prevVal[counter] = hand[i];
                       break;
                   }
               }
               prevVal[counter] = hand[i];
               size[counter]++;
               counter = 0;
           }
           return true;
       }
   }