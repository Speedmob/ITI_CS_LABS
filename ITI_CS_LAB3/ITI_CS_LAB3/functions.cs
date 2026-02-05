using System;
using System.Collections.Generic;
using System.Text;

namespace ITI_CS_LAB1
{
    internal class functions
    {
        public static void shiftArrayLogic(int idx, int[] arr, int start)
        {
            if (idx == 0) return;

            int temp;
            int length = arr.Length - start;

            for (int i = start; i < arr.Length - idx; i+=idx)
            {
                for (int j = 0; j < idx; j++)
                {
                    Console.WriteLine("SWAPPING: " + arr[arr.Length - idx + j] + " AND " + arr[i + j] + " IN INDEX " + (arr.Length - idx + j) + " AND " + (i + j));
                    temp = arr[arr.Length - idx + j];
                    arr[arr.Length - idx + j] = arr[i + j];
                    arr[i + j] = temp;
                }
                Console.WriteLine("END OF SWAP, I = " + i);
            }

            int remainder = length % idx;
            Console.WriteLine(remainder + " REMAINDER HEEEERE " + "STAAART " + start + " IDX " + idx);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("CURRENT ARRAY ");
            if (remainder == 0) return;

            shiftArrayLogic(idx % remainder, arr, start + length - remainder);
        }
        public static void shiftArray(int idx, int[] arr)
        {
            if (arr == null || arr.Length == 0) return;

            idx = idx % arr.Length;

            if (idx < 0)
            {
                idx = idx + arr.Length;
            }
            shiftArrayLogic(idx, arr, 0);
        }

        // ===================== TASK 2 =====================
        public static void iterateArrayBox(int[,] arr, int start, ref int curr, int n)
        {
            int row = start, col = start, flagR = 1, flagC = 1;
            for (int i = 0; i < 2; i++)
            {
                while (col != (-1 + start) && col != (n - start))
                {
                    arr[row, col] = curr;
                    curr++;
                    col += 1 * flagC;
                }

                flagC *= -1;
                if (col == (-1 + start)) col = start;
                if (col == (n - start))  col = (n - start) - 1;

                if (flagR == 1) row++;
                if (flagR == -1) row--;

                while ((row !=  start || flagR == 1) && row != (n - start))
                {
                    arr[row, col] = curr;
                    curr++;
                    row += 1 * flagR;
                }

                flagR *= -1;
                if (row == start) row = start;
                if (row == (n - start)) row = (n - start) - 1;
                if (flagC == -1) col--;
            }
        }
        public static int[,] spiral(int n)
        {
            int[,] arr = new int[n, n];
            int curr = 1;
            for (int i = 0; i < n / 2; i++)
            {
                iterateArrayBox(arr, i, ref curr, n);
            }
            if (n % 2 == 1) arr[n / 2, n / 2] = n * n;
            return arr;
        }

        // =========================== TASK 3 ===========================

        public static int[][] pascal(int n)
        {
            int[][] arr = new int[n][];

            if (n == 0) return arr;

            arr[0] = new int[1];
            arr[0][0] = 1;
            
            for (int i = 1; i < n; i++)
            {
                arr[i] = new int[i + 1];
                arr[i][0] = 1;
                arr[i][arr[i].Length - 1] = 1;

                for (int j = 1; j < arr[i].Length - 1; j++)
                {
                    arr[i][j] = arr[i - 1][j - 1] + arr[i - 1][j];
                }
            }

            return arr;
        }

        // =========================== TASK 4 ===========================

        public static void bubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void selectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        /* Limitation 3: Cannot use as class field */
        // var field = 10; 
        int field = 10;

        /* Limitation 6: Cannot use as return type */
        // static var GetValue() { return 10; } 
        static int GetValue() { return 10; }

    }

    class BankAccount
    {
        int accountNumber = 1;
        int balance;
        string ownerName;

        public BankAccount(string ownerName, int balance)
        {
            this.balance = balance;
            this.ownerName = ownerName;
        }
        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void Withdraw(int amount)
        {
            balance -= amount;
        }
        public int getBalance() { return balance; }
        public void Transfer(BankAccount targetAcc, int amount)
        {
            balance -= amount;
            targetAcc.Deposit(amount);
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + ownerName + ", Amount: " + balance);
        }
        public static void AddBonus(BankAccount account, int bonus)
        {
            account.Deposit(bonus);
        }
    }
    public static class ArrayUtils
    {
        public static void Reverse(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        public static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static int CountOccurrences(int[] arr, int value)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    count++;
                }
            }
            return count;
        }
        public static int[] Merge(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    result[k++] = arr1[i++];
                }
                else
                {
                    result[k++] = arr2[j++];
                }
            }

            while (i < arr1.Length)
            {
                result[k++] = arr1[i++];
            }

            while (j < arr2.Length)
            {
                result[k++] = arr2[j++];
            }

            return result;
        }
    }
}
