//    public class Solution
//    {
//        public bool IsNStraightHand(int[] hand, int groupSize)
//        {
//            Array.Sort(hand);
//            //int[][] arrays = new int [hand.Length/groupSize][].Select((int[] x)=>new int[groupSize]).ToArray();
//            int counter = 0;
//            int[] prevVal = new int[hand.Length/groupSize];
//            int[] size = new int[hand.Length / groupSize];
//            for (int i = 0; i < prevVal.Length; i++)
//            {
//                prevVal[i] = int.MinValue;
//            }
//            prevVal[0] = hand[0] - 1; 
          
//            for (int i = 0; i < hand.Length; i++)
//            {
//                while (hand[i] - prevVal[counter] != 1 || size[counter]>groupSize-1)
//                {
//                    counter++;
//                    if (counter > prevVal.Length - 1) return false;
//                    if (prevVal[counter] == int.MinValue)
//                    {
//                        prevVal[counter] = hand[i];
//                        break;
//                    }
//                }
//                prevVal[counter] = hand[i];
//                size[counter]++;
//                counter = 0;
//            }
//            return true;
//        }
//    }


    public class Solution
    {
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            Dictionary<int, int> map= new();
            PriorityQueue<int, int> que = new();
            for (int i = 0; i < hand.Length; i++)
            {
                if (map.ContainsKey(hand[i]))
                {
                    map[hand[i]]++;
                }
                else
                {
                    map[hand[i]] = 1;
                    que.Enqueue(hand[i], hand[i]);
                }
            }

            while (que.Count > 0)
            {
                int currentHead = que.Peek();
                map[currentHead]--;
                if (map[currentHead] == 0) que.Dequeue(); 
                for (int i = currentHead+1; i <= currentHead + groupSize-1; i++)
                {
                    if (map.ContainsKey(i) && map[i] > 0)
                    {
                        map[i]--;
                        if (map[i] == 0)
                        {
                            if (que.Peek() == i) que.Dequeue();
                            else return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;

        }
    }