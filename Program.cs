// using System;
// using System.Collections.Generic;
// using System.Collections;

// namespace MyNamespace
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             //PrintOccurence();
//             //PrintOddOccurence();
//              //PrintStringOccurence();
             
//         }
//         static void PrintOccurence()
//         {
//             int[] arr = {3, 4, 4, 2, 3, 3, 4, 3, 2};
//             Dictionary<int, int> num = new Dictionary<int, int>();
//             foreach (var item in arr)
//             {
//                 if (num.ContainsKey(item))
//                 {
//                     num[item] = num[item] + 1;
//                 }
//                 else
//                 {
//                     num.Add(item, 1);
//                 }
//             }
//             foreach (var item in num)
//             {
//                System.Console.WriteLine($"{item.Key} occurs {item.Value} times"); 
//             }
//         }
//         static void PrintOddOccurence()
//         {
//             int[] num =  {4, 2, 2, 5, 2, 3, 5, 5, 2, 3, 1, 5, 2, 6, 6, 6}; 
//             Hashtable hash = new Hashtable();
//             foreach (var elements in num)
//             {
//                 if(hash.ContainsKey(elements))
//                 {
//                     hash[elements] = (int)hash[elements] + 1;
//                 }
//                 else
//                 {
//                     hash.Add(elements, 1);
//                 }
//             }
//             foreach (DictionaryEntry item in hash)
//             {
//                 if ((int)item.Value % 2 == 0)
//                 {
//                     for(int i = 0; i < (int)item.Value; i ++)
//                     {
//                          Console.WriteLine(item.Key);
//                     }
//                 }
//             }
//         }
//         static void PrintStringOccurence()
//         {
//             List<string> texted = new List<string>(){"This", "is", "the", "TEXT", "Text", "text", "text", "THIS", "TEXT", "Is", "this", "the" ,"text"};
//             Dictionary<string, int> texts = new Dictionary<string, int>();
//             foreach(var elements in texted)
//             {
//                 string b = elements.ToLower();
//                 if(texts.ContainsKey(b))
//                 {
//                     texts[b] = texts[b] + 1;
//                 }
//                 else
//                 {
//                     texts.Add(b, 1);
//                 }
//             }
//             foreach (var item in texts)
//             {
//                 System.Console.WriteLine($"{item.Key} occurs {item.Value} times");
//             }
//         }
//     }
// }
