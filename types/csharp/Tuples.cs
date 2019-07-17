using System;

namespace csharp
{
    class Tuples
    {
        public static void CreatingTuples()
        {
            Tuple<int, int, int> firstTuple =
                new Tuple<int, int, int>(1, 2, 3);

            Tuple<int, bool, string> secondTuple =
                new Tuple<int, bool, string>(1, true, "Gabriel");

            Tuple<int, bool> thirdTuple =
                new Tuple<int, bool>(3, false);

            Tuple<int, int, int, bool, string> fourthTuple =
                new Tuple<int, int, int, bool, string>(1, 2, 3, false, "Test");

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
            Console.WriteLine(fourthTuple);

            int item1 = firstTuple.Item1;
            int item2 = firstTuple.Item2;
            int item3 = firstTuple.Item3;

            Console.WriteLine(item1);
            Console.WriteLine(item2);
            Console.WriteLine(item3);
        }
    }
}