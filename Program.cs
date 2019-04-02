using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1 2 3 4 5 6 7 8 11 12 13 14 15 16 17 18
/// 1 2 3 4 11 12 13 14 5 6 7 8 15 16 17 18
/// 1 2 11 12 3 4 13 14 5 6 15 16 7 8 17 18
/// 1 11 2 12 3 13 4 14 5 15 6 16 7 17 8 18
/// 1 2 3 4 11 12 13 14
/// 1 2 11 12 3 4 13 14
/// 1 11 2 12 3 13 4 14
/// 1 2 11 12 3 4 13 14
/// 1 11 2 12 3 13 4 14
/// </summary>
namespace Shuffle2Nintegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array");
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            shuffleArray(a, 0, a.Length - 1);
            foreach(int i in a)
            Console.WriteLine(i);
            Console.ReadLine();
        }
        public static void shuffleArray(int[] a,int low,int high)
        {
            if (low == high-1)
                return;
            int mid = low + (high - low) / 2;
            //int constant = ((high - low) + 1) / 2;
            if (high-low>3)
                swapElements(a, mid - ((mid-low) / 2), mid + ((mid-low) / 2)+1);
            else
                swapElements(a, mid, mid + 1);
            shuffleArray(a, low, mid);
            shuffleArray(a, mid+1, high);
                
        }
        public static void swapElements(int[] a,int low,int high)
        {
            int constant = ((high - low) + 1) / 2;
            while (low<high)
            {
                int temp = a[low];
                a[low] = a[low+constant];
                a[low+constant] = temp;
                low++;
                high--;
            }
        }
    }
}
