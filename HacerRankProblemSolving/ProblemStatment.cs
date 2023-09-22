using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
    }

}
