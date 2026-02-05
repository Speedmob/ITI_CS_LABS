// ===================== TASK 1 =====================

using ITI_CS_LAB1;

//int[] arr = { 1, 2, 3, 4, 5 , 6, 7, 8, 9, 10, 11, 12, 13};

//functions.shiftArray(8, arr);

//foreach (int i in arr)
//{
//    Console.WriteLine(i);
//}

// =========================== TASK 2 ===========================

//int[,] res = functions.spiral(11);

//for (int i = 0; i < res.GetLength(0); i++)
//{
//    for (int j = 0;  j < res.GetLength(1); j++)
//    {
//        Console.Write(res[i, j] + " ");
//    }
//    Console.WriteLine("");
//}

// =========================== TASK 3 ===========================

//int[][] res = functions.pascal(7);

//for (int i = 0; i < res.Length; i++)
//{
//    for (int j = 0; j < res[i].Length; j++)
//    {
//        Console.Write(res[i][j] + " ");
//    }
//    Console.WriteLine("");
//}

// =========================== TASK 4 ===========================

//int[] arr = { 5, 1, 3, 4, 2 };

//functions.selectionSort(arr);
//functions.bubbleSort(arr);

//foreach (int i in arr)
//{
//    Console.WriteLine(i);
//}

// =========================== TASK 5 ===========================

///* Limitation 1: Must initialize immediately */
//// var x; 
//var x = 10;

///* Limitation 2: Cannot be null */
//// var y = null; 
//string y = null;

///* Limitation 4: Cannot use in own initialization */
//// var i = i + 1; 
//int i = 0;
//i = i + 1;

///* Limitation 5: Cannot declare multiple */
//// var a = 1, b = 2; 
//var a = 1;
//var b = 2;

//Console.WriteLine(x);
//Console.WriteLine(y);
//Console.WriteLine(i);
//Console.WriteLine(a);
//Console.WriteLine(b);

// =========================== TASK 6 ===========================

//BankAccount account1 = new BankAccount("Ahmed", 5000);
//BankAccount account2 = new BankAccount("Sara", 3000);

//account1.DisplayInfo();
//account2.DisplayInfo();

//account1.Deposit(1000);
//account1.Withdraw(500);

//account1.Transfer(account2, 2000);

//account1.DisplayInfo();
//account2.DisplayInfo();

//BankAccount.AddBonus(account1, 500);

//account1.DisplayInfo();

// =========================== TASK 7 ===========================

//int[] arr = { 5, 2, 8, 1, 9, 2 };

//Console.WriteLine("Max: " + ArrayUtils.FindMax(arr));
//Console.WriteLine("Min: " + ArrayUtils.FindMin(arr));
//Console.WriteLine("isSorted: " + ArrayUtils.IsSorted(arr));
//Console.WriteLine("Count of 2: " + ArrayUtils.CountOccurrences(arr, 2));

//ArrayUtils.Reverse(arr);
//Console.WriteLine("Reversed first element: " + arr[0]);

//int[] sorted1 = { 1, 3, 5 };
//int[] sorted2 = { 2, 4, 6 };
//int[] merged = ArrayUtils.Merge(sorted1, sorted2);

//Console.Write("Merged: ");
//foreach (int n in merged) Console.Write(n + " ");

// =========================== TASK 8 ===========================

//Console.WriteLine("Enter a sentence:");
//string input = Console.ReadLine();

//if (string.IsNullOrEmpty(input)) return;

//string lowerInput = input.ToLower();
//string[] tokens = lowerInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//string[] uniqueWords = new string[tokens.Length];
//int[] counts = new int[tokens.Length];
//int uniqCount = 0;

//for (int i = 0; i < tokens.Length; i++)
//{
//    string currWord = tokens[i];
//    bool found = false;

//    for (int j = 0; j < uniqCount; j++)
//    {
//        if (string.Compare(uniqueWords[j], currWord) == 0)
//        {
//            counts[j]++;
//            found = true;
//            break;
//        }
//    }

//    if (!found)
//    {
//        uniqueWords[uniqCount] = currWord;
//        counts[uniqCount] = 1;
//        uniqCount++;
//    }
//}

//for (int i = 0; i < uniqCount - 1; i++)
//{
//    for (int j = 0; j < uniqCount - i - 1; j++)
//    {
//        if (counts[j] < counts[j + 1])
//        {
//            int tempCount = counts[j];
//            counts[j] = counts[j + 1];
//            counts[j + 1] = tempCount;

//            string tempWord = uniqueWords[j];
//            uniqueWords[j] = uniqueWords[j + 1];
//            uniqueWords[j + 1] = tempWord;
//        }
//    }
//}

//for (int i = 0; i < uniqCount; i++)
//{
//    string output = string.Concat(uniqueWords[i], " - ", counts[i]);
//    Console.WriteLine(output);
//}