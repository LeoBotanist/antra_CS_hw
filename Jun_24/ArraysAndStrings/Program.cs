// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.RegularExpressions;

internal class ArraysAndStrings
{
    // Practise Arrays
    // 1
    public static void CopyArray()
    {
        int[] arr;
        arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }

        int[] arr2 = new int[arr.Length];
        
        for (int i = 0; i < arr.Length; i++)
        {
            arr2[i] = arr[i];
        }
    }

    // 2
    public static void GroceryList()
    {
        List<string> list = new List<string>();
        while (true)
        {
            Console.WriteLine("Please type in your command, q for quit.");
            string? command = Console.ReadLine();
            if (command == null)
            {
                Console.WriteLine("Please input!");
            } else if (command == "q")
            {
                return;
            } else if (command.StartsWith("+"))
            {
                string itemToAdd = command.Substring(2);
                list.Add(itemToAdd);
                Console.WriteLine($"{itemToAdd} is added!");
            } else if (command.StartsWith("-"))
            {
                string itemToRemove = command.Substring(2);
                if (list.Remove(itemToRemove))
                {
                    Console.WriteLine($"{itemToRemove} is removed!");
                }
                else
                {
                    Console.WriteLine($"{itemToRemove} is not found!");
                }
            } else if (command == "--")
            {
                list.Clear();
                Console.WriteLine("List is cleared!");
            }
            else
            {
                Console.WriteLine("Please type in valid command!");
            }
        }
    }

    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return true;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
    
    // 3
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> result = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }

    // 4
    public static int[] RotateArray()
    {
        Console.WriteLine("Please type in the input array");
        string[] inputStr = Console.ReadLine().Split();
        int length = inputStr.Length - 1;
        int[] input = new int[length];
        int[] result = new int[length];
        int k = 0;
        for (int i = 0; i < length + 1; i++)
        {
            if (i == length)
            {
                k = int.Parse(inputStr[i]);
            }
            else
            {
                input[i] = int.Parse(inputStr[i]);
            }
        }

        for (int i = 1; i <= k; i++)
        {
            int[] rotatedArr = new int[length];

            for (int j = 0; j < length; j++)
            {
                rotatedArr[(j + i) % length] = input[j];
            }

            for (int j = 0; j < length; j++)
            {
                result[j] += rotatedArr[j];
            }
        }

        for (int i = 0; i < length; i++)
        {
            Console.Write(result[i]);
        }
        return result;

    }
    
    // 5
    public static int[] FindLongestSquence(int[] inputArr)
    {
        if (inputArr.Length == 0)
        {
            return Array.Empty<int>();
        }

        int maxLength = 1;
        int currentLength = 1;
        int longestElement = inputArr[0];
        int currentElement = inputArr[0];

        for (int i = 1; i < inputArr.Length; i++)
        {
            if (inputArr[i] == currentElement)
            {
                currentLength += 1;
            }
            else
            {
                currentElement = inputArr[i];
                currentLength = 1;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                longestElement = currentElement;
            }
        }
        int[] result = new int[maxLength];
        for (int i = 0; i < maxLength; i++)
        {
            result[i] = longestElement;
        }

        return result;
    }
    
    // 7
    public static int FindMostFrequentNumber(int[] inputArr)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        for (int i = 0; i < inputArr.Length; i++)
        {
            if (freq.ContainsKey(inputArr[i]))
            {
                freq[inputArr[i]]++;
            }
            else
            {
                freq[inputArr[i]] = 1;
            }
        }

        int mostFrequentNumber = inputArr[0];
        int maxFrequency = freq[mostFrequentNumber];

        for (int i = 0; i < inputArr.Length; i++)
        {
            if (freq[inputArr[i]] > maxFrequency)
            {
                mostFrequentNumber = inputArr[i];
                maxFrequency = freq[inputArr[i]];
            }
        }

        return mostFrequentNumber;
    }
    
    // Practice Strings
    // 1.1 Using a char array
    public static void ReverseString1()
    {
        string input = Console.ReadLine();
        char[] charArr = input.ToCharArray();
        Array.Reverse(charArr);
        string result = new string(charArr);
        Console.WriteLine($"Reversed string is {result}");
    }
    
    // 1.2 Using a for loop
    public static void ReverseString2()
    {
        string input = Console.ReadLine();
        Console.Write("Reversed string is: ");
        for (int i = input.Length - 1; i > -1; i--)
        {
            Console.Write(input[i]);
        }

        Console.WriteLine();
    }
    
    // 2
    public static string ReverseSentence(string input)
    {
        char[] separators = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        
        List<string> words = new List<string>();
        List<string> separatorsList = new List<string>();
        
        StringBuilder word = new StringBuilder();
        foreach (char c in input)
        {
            if (Array.Exists(separators, element => element == c))
            {
                if (word.Length > 0)
                {
                    words.Add(word.ToString());
                    word.Clear();
                }
                separatorsList.Add(c.ToString());
            }
            else
            {
                word.Append(c);
            }
        }

        if (word.Length > 0)
        {
            words.Add(word.ToString());
        }
        
        words.Reverse();

        StringBuilder result = new StringBuilder();
        int wordIndex = 0;
        int separatorIndex = 0;

        while (wordIndex < words.Count && separatorIndex < separatorsList.Count)
        {
            result.Append(words[wordIndex++]);
            result.Append(separatorsList[separatorIndex++]);
        }

        while (wordIndex < words.Count)
        {
            result.Append(words[wordIndex++]);
        }

        while (separatorIndex < separatorsList.Count)
        {
            result.Append(separatorsList[separatorIndex++]);
        }

        return result.ToString();
    }
    
    // 3
    public static bool IsPalindrome(string input)
    {
        int length = input.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (input[i] != input[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
    
    public static void ExtractPalindromes(string input)
    {
        List<string> pal = new List<string>();
        string[] words = Regex.Split(input, @"\W+");
        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                pal.Add(word);
            }
        }

        foreach (string ele in pal)
        {
            Console.WriteLine(ele);
        }

    }
    
    // 4
    public static void UrlParser(string url)
    {
        string protocol = null;
        string server = null;
        string resource = null;

        int protocolPart = url.IndexOf("://");
        if (protocolPart != -1)
        {
            protocol = url.Substring(0, protocolPart);
            url = url.Substring(protocolPart + 3);
        }
        
        int serverPart = url.IndexOf("/");
        if (serverPart != -1)
        {
            server = url.Substring(0, serverPart);
            resource = url.Substring(serverPart + 1);
        }
        else
        {
            server = url;
        }

        Console.WriteLine($"[protocol] = \"{(protocol == null ? string.Empty : protocol)}\"\n" +
                          $"[server] = \"{server}\"\n" +
                          $"[resource] = \"{(resource == null ? string.Empty : resource)}\"");
    }
    
    public static void Main(string[] args)
    {
        // RotateArray();
        // Console.WriteLine(ReverseSentence("C# is not C++, and PHP is not Delphi!"));
        // ExtractPalindromes("Hi,exe? ABBA! Hog fully a string: ExE. Bob");
        UrlParser("https://google.com");
    }
    
}
