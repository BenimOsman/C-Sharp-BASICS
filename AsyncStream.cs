using System;
using System.Collections.Generic;
using System.Threading;

namespace BASIC
{
    public static class AsyncStream
    {
        public static IEnumerable<int> GetNumbers(int start, int end)
        {
            var random = new Random();

            for (int i = start; i < end; i++)
            {
                Thread.Sleep(random.Next(500, 1500));
                yield return i;
            }
        }

        public static async IAsyncEnumerable<int> GetNumbersAsync(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                await Task.Delay(400);
                yield return i;
            }
        }
    }
}
