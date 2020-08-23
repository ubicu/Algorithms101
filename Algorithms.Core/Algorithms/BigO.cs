namespace Algorithms.Core
{
    public class BigO
    {
        // What is Big-O notation of foo? - O(2n) => O(n)
        public void foo(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                // ...
            }

            for (int i = 0; i < array.Length; i++)
            {
                // ...
            }
        }


        // What is Big-O notation of bar? - O(m*n)
        public void bar(int[] array1, int[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                // ...
                for (int j = 0; j < array2.Length; j++)
                {
                    // ...
                }
            }
        }


        // What is Big-O notation of baz? - O(n^2)
        public void baz(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                // ...
                for (int j = 0; j < array.Length; j++)
                {
                    // ...
                    if (array[i] < array[j])
                    {
                        // Launch!
                    }
                }
            }
        }


        // What is Big-O notation of beep? - O(9999999*n^2) => O(n^2)
        public void beep(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                // ...
                for (int j = 0; j < array.Length; j++)
                {
                    // ...
                    for (int k = 0; k < 9999999; k++)
                    {
                        // Jump!
                    }
                }
            }
        }

    }
}
