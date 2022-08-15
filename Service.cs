namespace ClassLibrary1;

public class Service: IService
{

    public object FindElement(IEnumerable<object> data, int index)
    {
        return new List<Objt>(data).ElementAt(index);
    }

    public bool AreTheseStringsEqual(string str1, string str2)
    {
        return str2.Equals(str1);
    }

    public int Factorial(int n)
    {
        if (n == 1)
            return n;
        return n* Factorial(n - 1);
    }

    public int Fibonacci(int n)
    {
        if (n < 2)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);

    }

    public IEnumerable<int> FindValuesGreaterThan(IEnumerable<int> data, int value)
    {
        throw new NotImplementedException();
    }

    public double FindAverage(IEnumerable<int> data)
    {
        //throw new NotImplementedException();
        return new List<int>(data).Average();
    }

    public string SwapCharacters(string testString, char swapA, char swapB)
    {
        //throw new NotImplementedException();
        var newString = "";
        foreach ( char character in testString)
        {
            if (character.Equals(swapA))
            {
                newString = newString + swapB;
            }else if (character.Equals(swapB))
            {
                newString = newString + swapA;
            }
            else
            {
                newString = newString + character;
            }
        }
        return newString;
    }

    public int ConvertStringToIntIfValidIntegerValue(string testString)
    {
        int returnValue = -1;
        try
        {
            return Int32.Parse(testString);
        }
        catch (FormatException e)
        {
            throw e;

        }
    }
    class InnerClassCreatedForMocking
    {
        public int field;
        public int Property
        {
            get
            {
                return field * 2;
            }
            set
            {
                field = value;
            }
        }

        public object CreateObjectWithPropretyWhichHasAccessors()
    {
        //throw new NotImplementedException();
        return new InnerClassCreatedForMocking();
    }

    public IEnumerable<object> CreateListWithObjectsContainingIntAndItsSquare(IEnumerable<int> data)
    {
        throw new NotImplementedException();
    }

    public Dictionary<int, int> CreateDictionrayWithIntsAndTheirFrequency(IEnumerable<int> data)
    {
        //throw new NotImplementedException();
        return data.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

    }

    public IEnumerable<int> CreateListOfHighestFiveNumbers(IEnumerable<int> data)
    {
        //throw new NotImplementedException();
        return data.OrderByDescending(x => x).Select(x => x).Take(5);

    }

    public bool IsDateEarlierThanToday(DateTime date)
    {
        //throw new NotImplementedException();
        return date < DateTime.Now;

    }

    public DateTime CreateDateFromNumberOfMillisecondsSinceUnixEpoch(long milliseconds)
    {
        //throw new NotImplementedException();
        return DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).Date;

    }

    public List<DateTime> CreateListOfLatestTwoDates(IEnumerable<DateTime> dates)
    {
        //throw new NotImplementedException();
        return dates.OrderByDescending(x => x).Select(x => x).Take(2).ToList();
    }

    public IEnumerable<string> PerformInMemoryInnerJoin(IEnumerable<string> left, IEnumerable<string> right)
    {
        //throw new NotImplementedException();
        return left.Join(right, str1 => str1, str2 => str2, (str1, str2) => str1);
    }

    public List<int> EvilNumbers(List<int> data)
    {
        //throw new NotImplementedException();
        List<int> evils = new List<int>();
        {
            for (var i = 0; i < data.Count; i++)
            {
                string bin = Convert.ToString(data[i], 2);
                int count = 0;
                for (var j = 0; j < bin.Length; j++)
                {
                    if (bin[j].Equals('1'))
                    {
                        count++;
                    }
                }
                if (count % 2 == 0)
                {
                    evils.Add(data[i]);
                }
            }
        }
        return evils;
    }

    public List<int> AbundantNumbers(IEnumerable<int> data)
    {
        //throw new NotImplementedException();
        var list = new List<int>(data);
        List<int> abundants = new List<int>();
        for (var i = 0; i < list.Count; i++)
        {
            var count = 0;
            for (var j = 1; j < list[i]; j++)
            {
                if (list[i] % j == 1) {
                    count = count + j;
                }
            }
            if (count > list[i])
            {
                abundants.Add(list[i]);
            }
        }
        return abundants;
    }
}