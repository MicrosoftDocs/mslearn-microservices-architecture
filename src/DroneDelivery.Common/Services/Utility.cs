namespace DroneDelivery.Common.Services
{
    public class Utility
    {
        public static long DoWork(int permutations)
        {
            long count = 0;

            for (int i = 0; i < permutations; i++)
            {
                for (int j = 0; j < permutations; j++)
                {
                    for (int k = 0; k < permutations; k++)
                    {
                        for (int l = 0; l < permutations; l++)
                        {

                        }
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
