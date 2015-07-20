using System;
using System.Collections.Generic;

namespace EnumerableTester
{
    public static class Shuffler
    {
        public static IList<T> ToShuffled<T>(this IEnumerable<T> source, int seed)
        {
            return ToShuffled<T>(source, new Random(seed));
        }
        public static IList<T> ToShuffled<T>(this IEnumerable<T> source, Random rnd)
        {
            using(var en = source.GetEnumerator())
            {
                if(!en.MoveNext())
                    return new T[0];
                var asCol = source as ICollection<T>;
                var list = asCol != null ? new List<T>(asCol.Count) : new List<T>();
                list.Add(en.Current);
                int length = 1;
                while(en.MoveNext())
                {
                    int j = rnd.Next(length + 1);
                    if(j == length)
                        list.Add(en.Current);
                    else
                    {
                        list.Add(list[j]);
                        list[j] = en.Current;
                    }
                    ++length;
                }
                return list;
            }
        }
        public static IEnumerable<T> Interweave<T>(this IEnumerable<T> source0, IEnumerable<T> source1)
        {
            using(var en0 = source0.GetEnumerator())
            using(var en1 = source1.GetEnumerator())
                while(en0.MoveNext())
                {
                    yield return en0.Current;
                    if(en1.MoveNext())
                        yield return en1.Current;
                    else
                        break;
                }
        }
        // Replace numerator/denominator items in source with raisins,
        // then mix it up like a big ol' christams cake mix randomised on seed.
        public static IEnumerable<T> MixIn<T>(this IEnumerable<T> source, int numerator, int denominator, int seed, params T[] raisins)
        {
            var asCol = source as ICollection<T>;
            var list = asCol != null ? new List<T>(asCol.Count) : new List<T>();
            int idx = 0;
            int raisinIdx = 0;
            foreach(var item in source)
            {
                if((idx % denominator) < numerator)
                {
                    list.Add(raisins[raisinIdx]);
                    if(++raisinIdx == raisins.Length)
                        raisinIdx = 0;
                }
                else
                    list.Add(item);
                ++idx;
            }
            return list.ToShuffled(seed);
       }
    }
}