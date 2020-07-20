using System;
// Written by 42 Entwickler - https://www.youtube.com/c/42Entwickler
// Wan't to use this code? Ok! Please think about subscribing my youtube channel!
// This is the sourcecode used here in this video: https://www.youtube.com/watch?v=0z1qwdkNWwI 

// Disclaimer
// There is nothing better than using the buildin sorting mechanisms like LINQ or Array.Sort. Ensure there are the best algorithmn implementations there!
// Using existing framework code means less bugs and code you need to test.

namespace _04Quicksort {
    class Program {
        static void Main(string[] args) {
            //int[] data = { 14, 7, 9, 20, 16, 8, 11, 19 };
            //int[] data = { 2, 5, -1, 11, 0, 18, 22, 67, 51, 6 };
            int[] data = { 2, 5, 1, 9, 4, 5, 8, 3, 6, 7 };
            QuickSort(data);
            Console.WriteLine(String.Join(' ', data));
        }

        private static void QuickSort(Span<int> data) {
            if (data.Length <= 1)
                return;

            int i = 0;
            int j = data.Length - 1;

            int pivot = data[0];
            int temp;
            int split = 0;
            while (true) {
                while (data[i] < pivot)
                    i++;
                while (data[j] > pivot)
                    j--;

                if (i < j && data[i] != data[j]) {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    //Console.WriteLine($"SW {i},{j}: {String.Join(' ', data.ToArray())}");
                }
                else {
                    split = j;
                    break;
                }
            }
            //Console.WriteLine($"SPLIT AT {split } {String.Join(' ', data.ToArray())}");

            if (split > 1)
                QuickSort(data[..split]);
            if (split + 1 < data.Length )
                QuickSort(data[(split + 1)..]);
        }
    }
}

