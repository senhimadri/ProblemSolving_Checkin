using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
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
            for (int i = 1;i< a.Count();i++)
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

            return Math.Max(len,num);
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

            for (int i=0; i < candles.Count(); i++)
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
            var H = Convert.ToInt16(s.Substring(0,2));
            var M = s.Substring(3,2);
            var S = s.Substring(6,2);
            var ST = s.Substring(8,2);

            string RH;

            if (H == 12 && ST == "AM")
            {
                RH = "00";
            }
            else if ((H == 12 && ST == "PM") || (ST == "AM"))
            {
                RH = H.ToString().PadLeft(2,'0');
            }

            else 
            {
                RH = (H+12).ToString();
            }

            return RH+":"+M+":"+S;
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
                int s = i%10;

                if (s!=0 && n%s==0)
                {
                    c++;
                }
                i = i/10;
            }

            return c;
        }

        //4, 6 ,5 ,3, 3 ,1 
        public static int pickingNumbers(List<int> a,bool aaa)
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

                if (T<=1)
                {
                    Ac++;
                }
                else
                {
                    if (Ac>Bc)
                    {
                        Bc = Ac;
                    }

                    start = i;
                    Ac = 1;
                }
                
            }

            return Math.Max(Ac,Bc);
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

    


            for (int i=0; i < AlphaCount; i++)
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

        public static int FindIndexofList(this List<int> P,int Value)
        {
            int index=0;

            for (int i = 0;i < P.Count;i++) 
            {
                if (P[i] == Value)
                {
                    index = i;
                    break;
                }
            }
            return index+1;
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
            var Count = sentence.Length-1;
            var A = sentence.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = Count; i>=0;i--)
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
                Point = (c[Start] == 0) ?(Point - 1): (Point - 3);
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

        public static string _substring(this string _string,long _start,long _length)
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
            var aa=_hasNumber.Values.Max();
            return arrc-aa;
        }


        public static List<int> acmTeam(List<string> topic)
        {
            int _maxTopic = 0;
            int _teamCounter = 0;

            List<List<string>> _var = new List<List<string>>();

            for (int i = 0; i < topic.Count(); i++)
            {
                for (int j = topic.Count()-1; j > i; j--)
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

                for (int j=0 ; j < _stringAray_f.Count(); j++)
                {
                    if (_stringAray_f[j] == '1' || _stringAray_s[j] == '1')
                    {
                        _SkillCounter++;
                    }
                }

                if (_SkillCounter==_maxTopic)
                {
                    _teamCounter++;
                }

                if (_SkillCounter > _maxTopic)
                {
                    _maxTopic= _SkillCounter;
                    _teamCounter = 1;

                }
            }

            return new List<int> { _maxTopic,_teamCounter, };

        }


        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            List<long> Res= new List<long>();
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
            if (Coun==0)
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

            var F_splitDigit = (SquareNumber - S_SplitDigit)/ ASP;

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

            while (p > m && s>p && s >= 0)
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

            while(chapter<= n)
            {
                int last_exercise = Math.Min(first_exercise + k - 1, arr[chapter - 1]);
                if (first_exercise <= page && page <= last_exercise) res++;
                first_exercise = last_exercise + 1;

                if (first_exercise> arr[chapter-1])
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

                    if (!Map.ContainsKey(j) )
                    {
                        Map.Add(j, Value);
                    }
                    else if(Map[j] > Value)
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

                decriser --;
                incriser ++;
            }

            res= res.Distinct().ToList();
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
            Dictionary<char,int> occ = new Dictionary<char,int>();
            for (int i = 0; i < b.Length; i++)
            {
                if (occ.ContainsKey(b[i]) && b[i]!='_')  occ[b[i]]++;
                
                else if (b[i] != '_')  occ.Add(b[i],1);
            }

            if (occ.Any(x => x.Value == 1)) return "No";
            else if (b.Contains('_')) return "Yes";
            else
            {
                for (int i = 1; i < b.Length-1; i++)
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

        public static bool isValid(string  s)
        {
            Stack<char> stack = new Stack<char>(); // create an empty stack
            for (int i = 0; i < s.Length; i ++)
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
            return stack.Count ==0 ;
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

                if (sStack.Count!=0 && s[i] == '#')
                {
                    sStack.Pop();
                }
                else if (s[i]!='#')
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
            for (int i =0; i< s.Length;i++)
            {
                if (s[i] == '(' && opened++ > 0) sb.Append(s[i]);
                if (s[i] == ')' && opened-- > 1) s.Append(s[i]);
            }
            return sb.ToString();
        }
        public static List<int> closestNumbers(List<int> arr)
        {
            arr.Sort();

            Dictionary<int,List<int>> map = new();

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

            for(int right =0; right< nums.Length; right++)
            {
                int target = nums[right];
                current += target;


                var vali = (right - left + 1) * target - current > k;

                while ((right-left + 1)* target-current > k )
                {
                    current -= nums[left];
                    left++;
                }

                answer = Math.Max(answer, right - left + 1);
            }
            return answer;
        }
    }

}
