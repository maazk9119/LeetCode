namespace MySolutions._1833.MaximizeIceCreamBars
{
    internal class IceCreamBars
    {
        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);

            int bar = 0;
            for (int i = 0; i < costs.Length; i++)
            {
                if (coins > 0 && costs[i] <= coins)
                {
                    coins -= costs[i];
                    bar++;
                    continue;
                }

                break;
            }


            return bar;
        }
    }
}
