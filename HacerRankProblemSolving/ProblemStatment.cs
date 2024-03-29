﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace HacerRankProblemSolving
{
    public static class ProblemStatment
    {
        public static int pickingNumbers(List<int> a)
        {

            a.Sort();
            int len = 0, start = 0, num = 1;
            for (int i = 1; i < a.Count(); i++)
            {
                int t = a[i] - a[start];

                if (t >= 2)
                {
                    num = 1;
                    len = Math.Max(len, i - start);
                    start = i;
                }
                else
                {
                    num++;
                }
            }

            return Math.Max(len, num);
        }

        public static void miniMaxSum(List<int> arr)
        {
            List<long> longList = arr.ConvertAll(i => (long)i);

            var ArrSum = Convert.ToInt64(longList.Sum());

            List<long> res = new List<long>();

            for (int i = 0; i < arr.Count; i++)
            {
                var l = longList[i];

                res.Add(ArrSum - l);
            }

            Console.WriteLine((res.Min().ToString() + " " + res.Max().ToString()));


        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            var Max = candles.Max();

            int Counter = 0;

            for (int i = 0; i < candles.Count(); i++)
            {
                if (candles[i] == Max)
                {
                    Counter++;
                }
            }

            return Counter;

        }

        public static string timeConversion(string s)
        {
            var H = Convert.ToInt16(s.Substring(0, 2));
            var M = s.Substring(3, 2);
            var S = s.Substring(6, 2);
            var ST = s.Substring(8, 2);

            string RH;

            if (H == 12 && ST == "AM")
            {
                RH = "00";
            }
            else if ((H == 12 && ST == "PM") || (ST == "AM"))
            {
                RH = H.ToString().PadLeft(2, '0');
            }

            else
            {
                RH = (H + 12).ToString();
            }

            return RH + ":" + M + ":" + S;
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int AppleCounter = 0;
            int OrrangeCounter = 0;
            for (int i = 0; i < apples.Count(); i++)
            {
                if ((a + apples[i]) >= s && (a + apples[i]) <= t)
                {
                    AppleCounter++;
                }
            }

            for (int i = 0; i < oranges.Count(); i++)
            {
                if (b + oranges[i] >= s && (b + oranges[i]) <= t)
                {
                    OrrangeCounter++;
                }
            }

            Console.WriteLine(AppleCounter.ToString() + "\n" + OrrangeCounter.ToString());

        }

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if ((x1 > x2 && v1 > v2) || (x1 < x2 && v1 < v2))
            {
                return "NO";
            }
            else if (x1 == x2 && v1 != v2)
            {
                return "NO";
            }
            else if ((v1 - v2) == 0)
            {
                return "NO";
            }

            else if ((x2 - x1) % (v1 - v2) == 0)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
        public static List<int> breakingRecords(List<int> scores)
        {
            int Max = 0;
            int Min = 0;
            int HigScr = scores[0];
            int LowScr = scores[0];

            for (int i = 1; i < scores.Count(); i++)
            {
                if (scores[i] > HigScr)
                {
                    Max++;
                    HigScr = scores[i];

                }
                else if (scores[i] < LowScr)
                {
                    Min++;
                    LowScr = scores[i];
                }
            }

            return new List<int>() { Max, Min };

        }
        public static int findDigits(int n)
        {
            //58095
            int i = n;
            int c = 0;

            while (i > 0)
            {
                int s = i % 10;

                if (s != 0 && n % s == 0)
                {
                    c++;
                }
                i = i / 10;
            }

            return c;
        }

        //4, 6 ,5 ,3, 3 ,1 
        public static int pickingNumbers(List<int> a, bool aaa)
        {

            a.Sort();

            int start = 0;

            int Bc = 0;
            int Ac = 1;

            for (int i = 1; i < a.Count(); i++)
            {
                int A = a[i];
                int B = a[start];

                int T = A - B;

                if (T <= 1)
                {
                    Ac++;
                }
                else
                {
                    if (Ac > Bc)
                    {
                        Bc = Ac;
                    }

                    start = i;
                    Ac = 1;
                }

            }

            return Math.Max(Ac, Bc);
        }

        public static int designerPdfViewer()
        {
            string Alphabate = "abcdefghijklmnopqrstuvwxyz";

            string terget = "g";

            int index = 1; // Alphabate.IndexOf(,terget);

            string Str = Alphabate[0].ToString();





            return index;

        }

        public static int designerPdfViewer(List<int> h, string word)
        {
            string Alphabate = "abcdefghijklmnopqrstuvwxyz";

            int AlphaCount = word.Length;

            int Max = 0;




            for (int i = 0; i < AlphaCount; i++)
            {
                int IndexofLetter = Alphabate.IndexOf(word[i]);

                if (h[IndexofLetter] > Max)
                {
                    Max = h[IndexofLetter];
                }

            }

            return Max * AlphaCount;

        }

        public static int utopianTree(int n)
        {
            int H = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 > 0)
                {
                    H = H * 2;
                }
                else if (i % 2 == 0)
                {
                    H = H + 1;
                }
            }

            return H;

        }

        public static int utopianTree2(int n)
        {
            int H = 0;

            for (int i = 0; i <= n; i = i + 2)
            {
                H = (H * 2) + 1;
            }

            if (n % 2 == 1)
            {
                H = H * 2;
            }

            return H;

        }


        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            var Res = new List<int>();

            var Count = a.Count;

            for (int i = 0; i < queries.Count; i++)
            {
                int A = (Count + (queries[i] + k * (-1) % Count)) % Count;

                Res.Add(a[A]);
            }
            return Res;

        }

        public static List<int> permutationEquation(List<int> p)
        {
            List<int> Y = new List<int>();

            for (int i = 1; i <= p.Count; i++)
            {


                int FI = p.FindIndex(x => x == i);
                int F2 = p.IndexOf(i);
                int FT = p.FindIndex(x => x == FI);

                Y.Add(FT);
            }
            return Y;

        }

        public static int FindIndexofList(this List<int> P, int Value)
        {
            int index = 0;

            for (int i = 0; i < P.Count; i++)
            {
                if (P[i] == Value)
                {
                    index = i;
                    break;
                }
            }
            return index + 1;
        }

        //static int jumpingOnClouds(int[] c, int k)
        //{

        //    int Cunt = c.Count();

        //    int Jumpstep =0;

        //    if(Cunt%2==0)
        //    {
        //        Jumpstep=Cunt/2;
        //    }
        //    else
        //    {
        //        Jumpstep = Cunt;
        //    }
        //}

        public static string ReverseWords(string sentence)
        {
            var Count = sentence.Length - 1;
            var A = sentence.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = Count; i >= 0; i--)
            {
                var aa = A[i].ToString();
                sb.Append(aa);
            }

            var res = sb.ToString();
            return res;
        }
        public static int jumpingOnCloudsNumvers(int c, int k)
        {
            int Cunt = c;
            int Mod = Cunt;
            int Divider = 0;
            int Cnt = Cunt;

            while (Mod != 0)
            {
                Mod = (Cnt % k);
                Divider = Divider + (Cnt / k);
                Cnt = Cunt + Mod;
            }
            return Divider;

        }

        public static int jumpingOnClouds(int[] c, int k)
        {
            int count = c.Count();
            int Start = 0;
            int Point = (c[0] == 0) ? (100 - 1) : (100 - 3);

            while (Start != 0)
            {
                Point = (c[Start] == 0) ? (Point - 1) : (Point - 3);
                Start = (Start + k) % count;
            }
            return Point;
        }

        public static int jumpingOnCloudsV2(int[] c, int k)
        {
            int count = c.Count();
            int Start = 0;
            int Point = (c[0] == 0) ? (100 - 1) : (100 - 3);

            while (Start != 0)
            {
                Point = (c[Start] == 0) ? (Point - 1) : (Point - 3);
                Start = (Start + k) % count;
            }
            return Point;
        }

        public static List<int> cutTheSticks(List<int> arr)
        {
            arr.Sort();
            List<int> stickCut = new List<int>();

            string ABC = "Hakim Uddin";

            //string aa = ABC.Substring(,);

            var A = ABC[0];


            while (arr.Count() != 0)
            {
                int Smallest = arr[0];
                stickCut.Add(arr.Count());

                arr.RemoveAll(x => x == Smallest);
            }
            return stickCut;
        }


        public static long repeatedString(string s, long n)
        {
            long CountString = s.Count();
            long CountA = s.Count(x => x == 'a');

            long Mul = n / CountString;

            long CountA1 = Mul * CountA;

            int Rest = Convert.ToInt16(n % CountString);

            string Substring = s.Substring(0, Rest);

            long CountB = Substring.Count(x => x == 'a');

            return CountA1 + CountB;
        }

        public static string _substring(this string _string, long _start, long _length)
        {
            //string _res=string.Empty;


            //for (long i = _start; i < _length; i++)
            //{
            //    _res = _res + _string[i].ToString();
            //}

            return _string;
        }

        public static int equalizeArray(List<int> arr)
        {
            Dictionary<int, int> _hasNumber = new Dictionary<int, int>();

            for (int i = 0; i < arr.Count(); i++)
            {
                if (_hasNumber.ContainsKey(arr[i]))
                {
                    _hasNumber[arr[i]] += 1;
                }
                else
                {
                    _hasNumber.Add(arr[i], 1);
                }
            }
            var arrc = arr.Count();
            var aa = _hasNumber.Values.Max();
            return arrc - aa;
        }


        public static List<int> acmTeam(List<string> topic)
        {
            int _maxTopic = 0;
            int _teamCounter = 0;

            List<List<string>> _var = new List<List<string>>();

            for (int i = 0; i < topic.Count(); i++)
            {
                for (int j = topic.Count() - 1; j > i; j--)
                {
                    _var.Add(new List<string>()
                {
                    topic[i],
                    topic[j]
                });
                }
            }

            for (int i = 0; i < _var.Count(); i++)
            {
                var _stringAray_f = _var[i][0].ToArray();
                var _stringAray_s = _var[i][1].ToArray();

                int _SkillCounter = 0;

                for (int j = 0; j < _stringAray_f.Count(); j++)
                {
                    if (_stringAray_f[j] == '1' || _stringAray_s[j] == '1')
                    {
                        _SkillCounter++;
                    }
                }

                if (_SkillCounter == _maxTopic)
                {
                    _teamCounter++;
                }

                if (_SkillCounter > _maxTopic)
                {
                    _maxTopic = _SkillCounter;
                    _teamCounter = 1;

                }
            }

            return new List<int> { _maxTopic, _teamCounter, };

        }


        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            List<long> Res = new List<long>();
            Res.Add(b * bc + w * wc);


            Res.Add(b * bc + w * (bc + z));
            Res.Add(w * wc + b * (wc + z));

            long Number = 223432;

            double SquareNumber = Math.Pow(Number, 2);

            return Res.Min();
        }


        public static void kaprekarNumbers(int p, int q)
        {
            var Coun = 0;
            for (int i = p; i <= q; i++)
            {
                if (DefineKapricar(i))
                {
                    Console.Write($"{i} ");
                    Coun++;
                }
            }
            if (Coun == 0)
            {
                Console.WriteLine("INVALID RANGE");
            }
        }
        public static bool DefineKapricar(long number)
        {
            var SquareNumber = Convert.ToInt64(Math.Pow(number, 2));

            int NumberdigitCount = number.DigitCount();
            int SquareNumberCount = SquareNumber.DigitCount();

            var SpecifytheCondition = (SquareNumberCount == 2 * NumberdigitCount) || (SquareNumber == (2 * NumberdigitCount) - 1);

            var ASP = Convert.ToInt64(Math.Pow(10, NumberdigitCount));

            var S_SplitDigit = SquareNumber % ASP;

            var F_splitDigit = (SquareNumber - S_SplitDigit) / ASP;

            var ActualCondition = F_splitDigit + S_SplitDigit == number;


            if (SpecifytheCondition && ActualCondition)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static int DigitCount(this long Number)
        {
            int Counter = 0;

            while (Number != 0)
            {
                Number = Number / 10;
                Counter++;
            }
            return Counter;
        }


        // 1, 2, 4, 5, 7, 8, 10
        public static int beautifulTriplets(int d, List<int> arr)
        {
            var sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                var current = arr[i];

                var Contain1 = current + d * 1;
                var Contain2 = current + d * 2;

                if (arr.Contains(current + d * 1) && arr.Contains(current + d * 2))
                {
                    sum++;
                }
            }
            return sum;

            Hashtable numberNames = new Hashtable();
        }

        //7 1 3 4 1 7
        public static int minimumDistances(List<int> a)
        {
            Dictionary<int, int> Mapp = new Dictionary<int, int>();
            int Counter = a.Count();
            int MinValue = Counter;

            for (int i = 0; i < Counter; i++)
            {
                if (Mapp.ContainsKey(a[i]))
                {
                    var Maa = Mapp[a[i]];
                    MinValue = Math.Min(MinValue, (i - Mapp[a[i]]));
                }
                else
                {
                    Mapp.Add(a[i], i);
                }
            }

            if (MinValue != Counter)
            {
                return MinValue;
            }
            else
            {
                return -1;
            }

        }
        //18192035842


        //p: 16 ,d:2,m: 1,s: 9981

        //100 1 1 99
        // Output 9917
        public static int howManyGames(int p, int d, int m, int s)
        {
            int Counter = 0;

            while (p > m && s > p && s >= 0)
            {
                s = s - p;
                p = p - d;
                Counter++;
            }
            if (s > 0 && s > p)
            {
                Counter = Counter + (s / m);
            }

            return Counter;
        }

        //width = [2 ,3 ,1 ,2 ,3 ,2 ,3 ,3]

        //cases = [[0, 3], [4, 6], [6, 7], [3, 5], [0, 7]]

        public static List<int> serviceLane(int n, List<int> width, List<List<int>> cases)
        {
            List<int> res = new List<int>();

            for (int i = 0; i < cases.Count(); i++)
            {
                List<int> Minlist = new List<int>();
                int StartIndex = cases[i][0] == 0 ? 0 : cases[i][0] - 1;
                int EndIndex = cases[i][1] - 1;

                for (int j = StartIndex; j <= EndIndex; j++)
                {
                    Minlist.Add(width[j]);
                }
                res.Add(Minlist.Min());
            }

            return res;
        }

        public static int workbook(int n, int k, List<int> arr)
        {
            int page = 1, chapter = 1, first_exercise = 1, res = 0;

            while (chapter <= n)
            {
                int last_exercise = Math.Min(first_exercise + k - 1, arr[chapter - 1]);
                if (first_exercise <= page && page <= last_exercise) res++;
                first_exercise = last_exercise + 1;

                if (first_exercise > arr[chapter - 1])
                {
                    chapter++;
                    first_exercise = 1;
                }
                page++;
            }
            return res;

        }


        public static int flatlandSpaceStations(int n, int[] c)
        {
            Dictionary<int, int> Map = new Dictionary<int, int>();

            for (int i = 0; i < c.Count(); i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var Value = Math.Abs(c[i] - j);

                    if (!Map.ContainsKey(j))
                    {
                        Map.Add(j, Value);
                    }
                    else if (Map[j] > Value)
                    {
                        Map[j] = Value;
                    }
                }
            }
            return Map.Values.Max();
        }

        static int flatlandSpaceStations2(int n, int[] c)
        {
            Array.Sort(c);

            int Answer = 0;
            int arrCount = c.Count();

            for (int i = 1; i < arrCount; i++)
            {
                Answer = Math.Max(Answer, (c[i] - c[i - 1]));
            }
            Answer = Math.Max((Answer / 2), c[0]);

            Answer = Math.Max(Answer, n - 1 - c[arrCount - 1]);

            return Answer;

        }


        public static List<string> cavityMap(List<string> grid)
        {
            var count = grid.Count();

            for (int x = 1; x < count - 1; x++)
            {
                StringBuilder sb = new StringBuilder(grid[x]);
                for (int y = 1; y < count - 1; y++)
                {
                    if (grid[x][y] > grid[x][y - 1] && grid[x][y] > grid[x][y + 1] &&
                        grid[x][y] > grid[x - 1][y] && grid[x][y] > grid[x + 1][y])
                    {
                        sb[y] = 'X';
                    }
                }
                grid[x] = sb.ToString();
            }
            return grid;
        }

        //5 3 23
        public static List<int> stones(int n, int a, int b)
        {
            var res = new List<int>();

            int incriser = 0;
            int decriser = n - 1;

            while (decriser >= 0)
            {
                res.Add(((decriser * a) + (incriser * b)));

                decriser--;
                incriser++;
            }

            res = res.Distinct().ToList();
            res.Sort();
            return res;
        }

        //public static string happyLadybugs(string b)
        //{
        //    Vector<int> occ= new Vector<int>();
        //    int n = b.Length;
        //    bool p=true, q=false;

        //    for (int i = 0; i< n;i++) 
        //    {
        //        if ()
        //        {

        //        }


        //        if (i==0 && b[i] == b[i+1] && p )
        //        {
        //            p = true;
        //        }
        //        else if (i== n-1 && b[n - 1] == b[n-2] && p)
        //        {
        //            p = true;
        //        }
        //        else if ((b[i] == b[i - 1] || b[i] == b[i + 1]) && p)
        //        {
        //            p = true;   
        //        }
        //        else
        //        {
        //            p = false;
        //        }

        //        if (b[i]=='_')
        //            q = true;
        //    }

        //    if (p )
        //        return "Yes";
        //    else if (!p && !q)
        //        return "No";

        //    else if (!p && q)
        //    {
        //        var A = b.ToCharArray();
        //        Array.Sort(A);
        //        b = new  string(A);

        //        for (int i = 1; i < n-1; i++)
        //        {
        //            if (b[i] == b[i+1] || b[i] == b[i-1] || b[i]=='_')
        //            {
        //                p = true;
        //            }
        //            else
        //            {
        //                p= false;
        //                break;
        //            }
        //        }
        //    }

        //    if (p)
        //    {
        //        return "Yes";
        //    }
        //    else
        //    {
        //        return "No";
        //    }
        //}



        public static string happyLadybugs2(string b)
        {
            Dictionary<char, int> occ = new Dictionary<char, int>();
            for (int i = 0; i < b.Length; i++)
            {
                if (occ.ContainsKey(b[i]) && b[i] != '_') occ[b[i]]++;

                else if (b[i] != '_') occ.Add(b[i], 1);
            }

            if (occ.Any(x => x.Value == 1)) return "No";
            else if (b.Contains('_')) return "Yes";
            else
            {
                for (int i = 1; i < b.Length - 1; i++)
                {
                    if (b[i] != b[i + 1] && b[i] != b[i - 1]) return "No";
                }
                return "Yes";
            }
        }

        //def strangeCounter(t):
        //    n=4
        //    while t>=n:
        //        n=(n*2)+2
        //    return n-t

        public static long strangeCounter(long t)
        {

            long n = 4;

            while (t >= n)
            {
                n = n * 2 + 2;
            }

            return n - t;
        }

        // s = "ab##", t = "c#d#"

        //["flower","flow","flight"]
        public static string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs);
            string FirstString = strs[0];
            string LastString = strs[strs.Length - 1];

            int Index = 0;

            while (true)
            {
                if (FirstString[0] == LastString[0])
                {
                    Index++;
                }
                else
                {
                    break;
                }

            }
            return FirstString.Substring(0, Index);
        }

        public static bool isValid(string s)
        {
            Stack<char> stack = new Stack<char>(); // create an empty stack
            for (int i = 0; i < s.Length; i++)
            { // loop through each character in the string
                if (s[i] == '(') // if the character is an opening parenthesis
                    stack.Push(')'); // push the corresponding closing parenthesis onto the stack
                else if (s[i] == '{') // if the character is an opening brace
                    stack.Push('}'); // push the corresponding closing brace onto the stack
                else if (s[i] == '[') // if the character is an opening bracket
                    stack.Push(']'); // push the corresponding closing bracket onto the stack

                else if (stack.Count == 0 || stack.Pop() != s[i]) // if the character is a closing bracket
                                                                  // if the stack is empty (i.e., there is no matching opening bracket) or the top of the stack
                                                                  // does not match the closing bracket, the string is not valid, so return false
                    return false;
            }
            // if the stack is empty, all opening brackets have been matched with their corresponding closing brackets,
            // so the string is valid, otherwise, there are unmatched opening brackets, so return false
            return stack.Count == 0;
        }

        public static bool IsPowerOfFour(int n)
        {

            if (n == 1) return true;
            while (n / 4 >= 1)
            {

                if (n / 4 == 1 && n % 4 == 0) return true;
                n = n / 4;
            }
            return false;
        }

        public static int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            //Dictionary<int, int> ctn = new Dictionary<int, int>();

            Hashtable ctn = new Hashtable();



            for (int i = 0; i < nums.Length; i++)
            {
                if (ctn.ContainsKey(nums[i]))
                {

                    //count += ctn[nums[i]]++;
                }

                else
                    ctn[nums[i]] = 1;
            }
            return count;
        }

        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            Dictionary<int, List<int>> temp_group = new Dictionary<int, List<int>>();
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < groupSizes.Length; i++)
            {
                int size = groupSizes[i];
                if (!temp_group.ContainsKey(size))
                {
                    temp_group[size] = new List<int>();
                }
                temp_group[size].Add(i);

                if (temp_group[size].Count == size)
                {
                    result.Add(new List<int>(temp_group[size]));
                    temp_group[size].Clear();
                }
            }
            return result;
        }

        //s: "a##c", t: "#a#c"
        public static bool BackspaceCompare(string s, string t)
        {

            Stack<char> sStack = new Stack<char>();
            Stack<char> tStack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {

                if (sStack.Count != 0 && s[i] == '#')
                {
                    sStack.Pop();
                }
                else if (s[i] != '#')
                {
                    sStack.Push(s[i]);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (tStack.Count != 0 && t[i] == '#')
                {
                    tStack.Pop();
                }
                else if (t[i] != '#')
                {
                    tStack.Push(s[i]);
                }
            }

            if (sStack.Count != tStack.Count)
                return false;

            while (sStack.Count != 0)
            {
                if (sStack.Peek() == tStack.Peek())
                {
                    sStack.Pop();
                    tStack.Pop();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static bool BackspaceCompareAlter(string s, string t)
        {
            char[] s_char = new char[s.Length];
            char[] t_char = new char[t.Length];

            int k = 0, p = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {

                    k--;
                    k = (int)Math.Max(0, k);
                }
                else
                {
                    s_char[k] = s[i];
                    k++;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == '#')
                {
                    p--;
                    p = (int)Math.Max(0, p);
                }
                else
                {
                    t_char[p] = t[i];
                    p++;
                }
            }
            if (k != p)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    if (s_char[i] != t_char[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }


        public static string removeOuterParentheses(string s)
        {
            StringBuilder sb = new StringBuilder();
            int opened = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' && opened++ > 0) sb.Append(s[i]);
                if (s[i] == ')' && opened-- > 1) s.Append(s[i]);
            }
            return sb.ToString();
        }
        public static List<int> closestNumbers(List<int> arr)
        {
            arr.Sort();

            Dictionary<int, List<int>> map = new();

            for (int i = 1; i < arr.Count; i++)
            {
                if (map.ContainsKey(arr[i] - arr[i - 1]))
                {
                    map[arr[i] - arr[i - 1]].Add(arr[i - 1]);
                    map[arr[i] - arr[i - 1]].Add(arr[i]);
                }
                else
                {
                    map.Add(arr[i] - arr[i - 1], new List<int>() { arr[i - 1], arr[i] });
                }
            }

            return map[map.Keys.Min()];

        }


        public static int MaxFrequency(int[] nums, int k)
        {
            Array.Sort(nums);
            int res = 0;
            int frequency;
            for (long i = nums.Length - 1; i > 0; i--)
            {
                frequency = 1;
                for (long j = (i - 1); j >= 0; j--)
                {
                    if (nums[i] <= nums[j] + k)
                    {
                        frequency++;
                    }
                }
                if (frequency > res)
                {
                    res = frequency;
                }
            }
            return res;
        }


        public static int MaxFrequencyV2(int[] nums, int k)
        {
            Array.Sort(nums);

            int left = 0, answer = 0, current = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                int target = nums[right];
                current += target;


                var vali = (right - left + 1) * target - current > k;

                while ((right - left + 1) * target - current > k)
                {
                    current -= nums[left];
                    left++;
                }

                answer = Math.Max(answer, right - left + 1);
            }
            return answer;
        }


        public static IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            IList<bool> res = new List<bool>();

            for (int i = 0; i < l.Length; i++)
            {
                int[] sortedSubArray = sortedSubarray(nums, l[i], r[i]);

                bool flag = true;
                int diff = sortedSubArray[1] - sortedSubArray[0];

                for (int j = 2; j < sortedSubArray.Length; j++)
                {
                    if (sortedSubArray[j] - sortedSubArray[j - 1] == diff)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }

                res.Add(flag);
            }

            return res;
        }

        private static int[] sortedSubarray(int[] nums, int startIndex, int endIndex)
        {
            int arrIndex = 0;
            int[] array = new int[endIndex - startIndex + 1];

            for (int i = startIndex; i <= endIndex; i++)
            {
                array[arrIndex] = nums[i];
                arrIndex++;
            }

            Array.Sort(array);
            return array;
        }

        public static IList<bool> checkArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            IList<bool> res = new List<bool>();

            for (int i = 0; i < l.Length; i++)
            {
                res.Add(isArithmeticSub(nums, l[i], r[i]));
            }
            return res;
        }

        private static bool isArithmeticSub(int[] nums, int l, int r)
        {
            if (r - l < 2) return true;

            int max = int.MinValue, min = int.MaxValue;
            List<int> set = new List<int>();

            for (int i = l; i <= r; i++)
            {
                max = Math.Max(max, nums[i]);
                min = Math.Max(min, nums[i]);

                set.Add(nums[i]);
            }
            if ((max - min) % (r - l) != 0) return false;

            int interval = (max - min) / (r - l);

            for (int i = 1; i <= r - l; i++)
            {
                if (!set.Contains(min + i * interval)) return false;
            }
            return true;
        }

        private static bool isArithmeticSeq(int[] nums, int start, int end)
        {
            if (end - start < 2) return true;

            int min = int.MaxValue, max = int.MinValue;

            List<int> set = new List<int>();

            for (int i = start; i <= end; i++)
            {
                min = Math.Min(min, nums[i]);
                max = Math.Max(max, nums[i]);
                set.Add(nums[i]);
            }

            if ((max - min) % (end - start) != 0) return false;
            int interval = (max - min) / (end - start);

            for (int i = 1; i <= end - start; i++)
            {
                var aaa = min + i * interval;
                if (!set.Contains(min + i * interval)) return false;
            }

            return true;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public static bool isSymmetric(TreeNode root)
        {
            if (root == null) return true;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode left, right;


            if (root.left != null && root.right != null)
            {
                if (root.right == null) return false;
                stack.Push(root.left);
                stack.Push(root.right);
            }
            else if (root.right != null)
            {
                return false;
            }

            while (stack.Count() != 0)
            {
                if (stack.Count() % 2 != 0) return false;
                right = stack.Pop();
                left = stack.Pop();

                if (right.val != left.val) return false;

                if (left.left != null)
                {
                    if (right.right == null) return false;
                    stack.Push(left.left);
                    stack.Push(right.right);
                }
                else if (right.right != null)
                {
                    return false;
                }

                if (left.right != null)
                {
                    if (right.left == null) return false;
                    stack.Push(left.right);
                    stack.Push(right.left);
                }
                else if (right.left != null)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool isSymmetricrfd(TreeNode root)
        {
            if (root == null) return true;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode left, right;

            if (root.left is null && root.right is null) return true;
            if (root.left is null || root.right is null) return false;


            stack.Push(root.left);
            stack.Push(root.right);

            while (stack.Count() != 0)
            {
                if (stack.Count() % 2 != 0) return false;
                right = stack.Pop();
                left = stack.Pop();

                if (right.val != left.val) return false;



                if (left.left is not null)
                {
                    if (right.right == null) return false;
                    stack.Push(left.left);
                    stack.Push(right.right);
                }
                else if (right.right != null)
                {
                    return false;
                }

                if (left.right != null)
                {
                    if (right.left == null) return false;
                    stack.Push(left.right);
                    stack.Push(right.left);
                }
                else if (right.left != null)
                {
                    return false;
                }
            }

            return true;
        }


        public static int CountCharacters(string[] words, string chars)
        {
            int res = 0;
            int[] seen = new int[26];

            for (int i = 0; i < chars.Length; i++)
            {
                seen[chars[i] - 'a']++;
            }

            for (int i = 0; i < words.Length; i++)
            {
                int[] tseen = new int[26];

                Array.Copy(seen, tseen, 26);

                string word = words[i];
                int tCount = 0;

                for (int j = 0; j < word.Length; j++)
                {

                    char aaaaaa = word[j];
                    var aaaaaaaa = word[j] - 'a';
                    var sssg = tseen[word[j] - 'a'];
                    if (tseen[word[j] - 'a'] > 0)
                    {
                        tCount++;
                        tseen[word[j] - 'a']--;
                    }
                }
                if (tCount == word.Length)
                {
                    res += tCount;
                }
            }
            return res;
        }


        public static string LargestGoodInteger(string num)
        {

            int maxval = -1;
            for (int i = 0; i <= num.Length - 3; i++)
            {

                var a = num[i];
                var b = num[i + 1];
                var c = num[i + 2];
                if (num[i] == num[i + 1] && num[i] == num[i + 2])
                    maxval = Math.Max(maxval, int.Parse(num[i].ToString()));
            }
            return maxval == -1 ? string.Empty : maxval == 0 ? "000" : (maxval * 111).ToString();

        }

        public static int NumberOfMatches(int n)
        {

            int rest = 0;
            int count = 0;

            while (n > 1)
            {
                count += (n + rest) / 2;
                rest = n % 2;
                n = (n + rest) / 2;

            }
            return count;
        }

        public static int GoodNodes(TreeNode root)
        {
            Stack<(TreeNode, int)> stack = new Stack<(TreeNode, int)>();
            stack.Push((root, int.MinValue));
            int count = 0;

            while (stack.Count > 0)
            {
                var (node, maxNum) = stack.Pop();

                if (node.val >= maxNum)
                {
                    count++;
                }

                maxNum = Math.Max(maxNum, node.val);

                if (node.left != null)
                {
                    stack.Push((node.left, maxNum));
                }

                if (node.right != null)
                {
                    stack.Push((node.right, maxNum));
                }
            }

            return count;
        }


        public static int LengthOfLongestSubstring(string s)
        {
            int result = 0;
            int length = s.Count();

            for (int i = 0; i < length - 1; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < length; j++)
                {
                    if (s[i] == s[j]) break;
                    counter++;
                }
                result = Math.Max(counter, result);
            }
            return result;
        }


        public static int LengthOfLongestSubstring2d(string s)
        {
            int l = 0;
            int length = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Count(); i++)
            {
                char c = s[i];
                if (map.ContainsKey(c) && map[c] >= l)
                {
                    l = map[c] + 1;
                    map[c] = i;
                }
                else
                {
                    length = Math.Max(length, i - l + 1);
                    map.Add(c, i);
                }
            }
            return length;
        }

        public static string LongestPalindrome(string s)
        {
            Dictionary<int, string> result = new();
            int i = 1, r = 0;
            int length = s.Count();

            while (i < length)
            {
                if (r >= 0 && s[i] == s[r])
                {
                    result.Add(i - r + 1, s.Substring(r, (i - r + 1)));
                    r = r - 1;
                }
                else if (r >= 0 && s[i] == s[r - 1])
                {
                    result.Add(i - r + 2, s.Substring(r - 1, (i - r + 2)));
                    i++;
                    r = r - 2;
                }
                else
                {
                    i++;
                    r = i - 1;
                }
            }

            return string.Empty;
        }



        public static int[] CountBits(int n)
        {
            int[] result = new int[n + 1];

            for (int i = 1; i < n + 1; i++)
            {
                var aaaa = 1 / 2;
                var aaa = result[i / 2];
                var bbb = i % 2;

                result[i] = result[i >> 1] + i % 2;
            }
            return result;
        }

        public static int NumDecodings(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            Dictionary<string, int> dp = new Dictionary<string, int>();

            int dfs(string str)
            {
                if (!dp.ContainsKey(str))
                {
                    if (str.Length > 0 && str[0] == '0')
                        dp[str] = 0;

                    else if (string.IsNullOrEmpty(str) || str.Length == 1)
                        dp[str] = 1;

                    else if (int.Parse(str.Substring(0, 2)) <= 26)
                    {
                        int first = dfs(str.Substring(1));
                        int second = dfs(str.Substring(2));

                        dp[str] = first + second;
                    }
                    else
                        dp[str] = dfs(str.Substring(1));

                }


                return dp[str];
            }


            return dfs(s);
        }



        public static int NumDecodings2(string s)
        {
            Dictionary<int, int> dp = new Dictionary<int, int>()
            {
                { s.Length,1}
            };

            int dfs(int i)
            {
                if (dp.ContainsKey(i))
                    return dp[i];
                if (s[i] == '0')
                    return 0;

                int res = dfs(i + 1);

                if (i + 1 < s.Length && (s[i] == '1' || (s[i] == '2' && s[i + 1] <= 6)))
                    res += dfs(i + 2);

                dp[i] = res;

                return res;
            }
            return dfs(0);
        }

        public static double MyPow(double x, int n)
        {

            double result = 1;

            if (n == 0) result = 1;

            else if (n < 0)
            {
                for (long i = -1; i >= n; i--)
                {
                    result *= x;
                }
                result = 1 / result;
            }
            else
            {
                for (long i = -1; i >= n; i--)
                {
                    result *= x;
                }
            }

            return result;
        }


        public static int FindMiddleIndex(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            int prefix = 0, suffix = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                suffix = sum - prefix + nums[i];

                if (suffix == prefix)
                {
                    return i;
                }

                prefix += nums[i];
            }
            return -1;
        }

        public static IList<IList<int>> Generate(int numRows)
        {

            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>() { 1 });

            for (int i = 1; i < numRows - 1; i++)
            {
                List<int> temp = new List<int>();

                temp.Add(0);
                temp.AddRange(result[i - 1]);
                temp.Add(0);

                IList<int> res = new List<int>();

                for (int j = 0; j < i + 1; j++)
                {
                    res.Add(temp[j] + temp[j + 1]);
                }

                result.Add(res);
            }

            return result;
        }

        public static int[][] Merge(int[][] intervals)
        {

            Array.Sort(intervals, (x, y) => x[0] - y[0]);

            int i = 0, j = 1;

            while(j< intervals.Length)
            {
                var first = intervals[i];
                var second = intervals[j];

                if (first[1]>= second[0])
                {
                    first[1] = Math.Max(first[1], second[1]);
                }
                else
                {
                    intervals[i + 1] = intervals[j];
                    i++;
                }

                j++;
            }

            return intervals.Take(i+1).ToArray();
        }
     }
}
