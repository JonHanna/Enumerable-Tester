using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace EnumerableTester
{
    public static class NewEnumerable
    {
        public static int Min(this IEnumerable<int> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            int value;
            using (IEnumerator<int> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                value = e.Current;
                while (e.MoveNext())
                {
                    int x = e.Current;
                    if (x < value) value = x;
                }
            }
            return value;
        }

        public static int? Min(this IEnumerable<int?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            int? value;
            using (IEnumerator<int?> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) return null;
                value = e.Current;
                // Start off knowing that we've a non-null value (or exit here, knowing we don't)
                // so we don't have to keep testing for nullity.
                while (!value.HasValue)
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                // Keep hold of the wrapped value, and do comparisons on that, rather than
                // using the lifted operation each time.
                int valueVal = value.GetValueOrDefault();
                while (e.MoveNext())
                {
                    int? cur = e.Current;
                    int x = cur.GetValueOrDefault();
                    // Do not replace & with &&. The branch prediction cost outweighs the extra operation
                    // unless nulls either never happen or always happen. 
                    if (cur.HasValue & x < valueVal)
                    {
                        valueVal = x;
                        value = cur;
                    }
                }
            }
            return value;
        }

        public static long Min(this IEnumerable<long> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long value;
            using (IEnumerator<long> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                value = e.Current;
                while (e.MoveNext())
                {
                    long x = e.Current;
                    if (x < value) value = x;
                }
            }
            return value;
        }

        public static long? Min(this IEnumerable<long?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long? value;
            using (IEnumerator<long?> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) return null;
                value = e.Current;
                while (!value.HasValue)
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                long valueVal = value.GetValueOrDefault();
                while (e.MoveNext())
                {
                    long? cur = e.Current;
                    long x = cur.GetValueOrDefault();
                    // Do not replace & with &&. The branch prediction cost outweighs the extra operation
                    // unless nulls either never happen or always happen. 
                    if (cur.HasValue & x < valueVal)
                    {
                        valueVal = x;
                        value = cur;
                    }
                }
            }
            return value;
        }
        
        public static float Min(this IEnumerable<float> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            float value;
            using (IEnumerator<float> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                value = e.Current;
                while(e.MoveNext())
                {
                    float x = e.Current;
                    if (x < value) value = x;
                    // Normally NaN < anything is false, as is anything < NaN
                    // However, this leads to some irksome outcomes in Min and Max.
                    // If we use those semantics then Min(NaN, 5.0) is NaN, but
                    // Min(5.0, NaN) is 5.0!  To fix this, we impose a total
                    // ordering where NaN is smaller than every value, including
                    // negative infinity.
                    // Not testing for NaN therefore isn't an option, but since we
                    // can't find a smaller value, we can short-circuit. But we consume
                    // the rest for backwards-compatibility reasons.
                    else if (float.IsNaN(x))
                    {
                        while (e.MoveNext()) {}
                        return x;
                    }
                }
            }
            return value;
        }

        public static float? Min(this IEnumerable<float?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            float? value;
            using (IEnumerator<float?> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) return null;
                value = e.Current;
                while (!value.HasValue)
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                float valueVal = value.GetValueOrDefault();
                while (e.MoveNext())
                {
                    float? cur = e.Current;
                    if (cur.HasValue)
                    {
                        float x = cur.GetValueOrDefault();
                        if (x < valueVal)
                        {
                            valueVal = x;
                            value = cur;
                        }
                        else if (float.IsNaN(x))
                        {
                            while (e.MoveNext()) { }
                            return cur;
                        }
                    }
                }
            }
            return value;
        }

        public static double Min(this IEnumerable<double> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double value;
            using (IEnumerator<double> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                value = e.Current;
                while(e.MoveNext())
                {
                    double x = e.Current;
                    if (x < value) value = x;
                    else if (double.IsNaN(x))
                    {
                        while (e.MoveNext()) {}
                        return x;
                    }
                }
            }
            return value;
        }

        public static double? Min(this IEnumerable<double?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double? value;
            using (IEnumerator<double?> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) return null;
                value = e.Current;
                while (!value.HasValue)
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                double valueVal = value.GetValueOrDefault();
                while (e.MoveNext())
                {
                    double? cur = e.Current;
                    if (cur.HasValue)
                    {
                        double x = cur.GetValueOrDefault();
                        if (x < valueVal)
                        {
                            valueVal = x;
                            value = cur;
                        }
                        else if (double.IsNaN(x))
                        {
                            while (e.MoveNext()) {}
                            return cur;
                        }
                    }
                }
            }
            return value;
        }


        public static decimal Min(this IEnumerable<decimal> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal value;
            using (IEnumerator<decimal> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                value = e.Current;
                while (e.MoveNext())
                {
                    decimal x = e.Current;
                    if (x < value) value = x;
                }
            }
            return value;
        }

        public static decimal? Min(this IEnumerable<decimal?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal? value;
            using (IEnumerator<decimal?> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) return null;
                value = e.Current;
                while (!value.HasValue)
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                decimal valueVal = value.GetValueOrDefault();
                while (e.MoveNext())
                {
                    decimal? cur = e.Current;
                    decimal x = cur.GetValueOrDefault();
                    if (cur.HasValue && x < valueVal)
                    {
                        valueVal = x;
                        value = cur;
                    }
                }
            }
            return value;
        }

        public static TSource Min<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            Comparer<TSource> comparer = Comparer<TSource>.Default;
            TSource value = default(TSource);
            if (value == null)
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    // A do…while may seem more natural here, but profiled worse across a wide set of test data
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                    while (value == null)
                    {
                        if (!e.MoveNext()) return value;
                        value = e.Current;
                    }
                    while (e.MoveNext())
                    {
                        TSource x = e.Current;
                        if (x != null && comparer.Compare(x, value) < 0) value = x;
                    }
                }
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (!e.MoveNext()) throw Error.NoElements();
                    value = e.Current;
                    while (e.MoveNext())
                    {
                        TSource x = e.Current;
                        if (comparer.Compare(x, value) < 0) value = x;
                    }
                }
            }
            return value;
        }

        public static int Max(this IEnumerable<int> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            int value;
            using (IEnumerator<int> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                value = e.Current;
                while (e.MoveNext())
                {
                    int x = e.Current;
                    if (x > value) value = x;
                }
            }
            return value;
        }

        public static int? Max(this IEnumerable<int?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            int? value;
            using (IEnumerator<int?> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) return null;
                value = e.Current;
                while (!value.HasValue)
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                int valueVal = value.GetValueOrDefault();
                if (valueVal >= 0)
                {
                    // We can fast-path this case where we know HasValue will
                    // never affect the outcome, without constantly checking
                    // if we're in such a state. A similar fast-path could
                    // be done for Min on negative values, but as all-positive
                    // or mostly-positive values are quite common in real-world
                    // uses, it's only been done in this direction.
                    while (e.MoveNext())
                    {
                        int? cur = e.Current;
                        int x = cur.GetValueOrDefault();
                        if (x > valueVal)
                        {
                            valueVal = x;
                            value = cur;
                        }
                    }
                }
                else
                {
                    while (e.MoveNext())
                    {
                        int? cur = e.Current;
                        int x = cur.GetValueOrDefault();
                        // Do not replace & with &&. The branch prediction cost outweighs the extra operation
                        // unless nulls either never happen or always happen. 
                        if (cur.HasValue & x > valueVal)
                        {
                            valueVal = x;
                            value = cur;
                        }
                    }
                }
            }
            return value;
        }

        public static long Max(this IEnumerable<long> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long value;
            using (IEnumerator<long> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                value = e.Current;
                while (e.MoveNext())
                {
                    long x = e.Current;
                    if (x > value) value = x;
                }
            }
            return value;
        }

        public static long? Max(this IEnumerable<long?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long? value;
            using (IEnumerator<long?> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) return null;
                value = e.Current;
                while (!value.HasValue)
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                long valueVal = value.GetValueOrDefault();
                if (valueVal >= 0)
                {
                    while (e.MoveNext())
                    {
                        long? cur = e.Current;
                        long x = cur.GetValueOrDefault();
                        if (x > valueVal)
                        {
                            valueVal = x;
                            value = cur;
                        }
                    }
                }
                else
                {
                    while (e.MoveNext())
                    {
                        long? cur = e.Current;
                        long x = cur.GetValueOrDefault();
                        // Do not replace & with &&. The branch prediction cost outweighs the extra operation
                        // unless nulls either never happen or always happen. 
                        if (cur.HasValue & x > valueVal)
                        {
                            valueVal = x;
                            value = cur;
                        }
                    }
                }
            }
            return value;
        }

        public static double Max(this IEnumerable<double> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double value;
            using (IEnumerator<double> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                value = e.Current;
                // As described in a comment on Min(this IEnumerable<double>) NaN is ordered
                // less than all other values. We need to do explicit checks to ensure this, but
                // once we've found a value that is not NaN we need no longer worry about it,
                // so first loop until such a value is found (or not, as the case may be).
                while (double.IsNaN(value))
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                while (e.MoveNext())
                {
                    double x = e.Current;
                    if (x > value) value = x;
                }
            }
            return value;
        }

        public static double? Max(this IEnumerable<double?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double? value;
            using (IEnumerator<double?> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) return null;
                value = e.Current;
                while (!value.HasValue)
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                double valueVal = value.GetValueOrDefault();
                while (double.IsNaN(valueVal))
                {
                    if (!e.MoveNext()) return value;
                    double? cur = e.Current;
                    if (cur.HasValue) valueVal = (value = cur).GetValueOrDefault();
                }
                while (e.MoveNext())
                {
                    double? cur = e.Current;
                    double x = cur.GetValueOrDefault();
                    // Do not replace & with &&. The branch prediction cost outweighs the extra operation
                    // unless nulls either never happen or always happen. 
                    if (cur.HasValue & x > valueVal)
                    {
                        valueVal = x;
                        value = cur;
                    }
                }
            }
            return value;
        }

        public static float Max(this IEnumerable<float> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            float value;
            using (IEnumerator<float> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                value = e.Current;
                while (float.IsNaN(value))
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                while (e.MoveNext())
                {
                    float x = e.Current;
                    if (x > value) value = x;
                }
            }
            return value;
        }

        public static float? Max(this IEnumerable<float?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            float? value;
            using (IEnumerator<float?> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) return null;
                value = e.Current;
                while (!value.HasValue)
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                float valueVal = value.GetValueOrDefault();
                while (float.IsNaN(valueVal))
                {
                    if (!e.MoveNext()) return value;
                    float? cur = e.Current;
                    if (cur.HasValue) valueVal = (value = cur).GetValueOrDefault();
                }
                while (e.MoveNext())
                {
                    float? cur = e.Current;
                    float x = cur.GetValueOrDefault();
                    // Do not replace & with &&. The branch prediction cost outweighs the extra operation
                    // unless nulls either never happen or always happen. 
                    if (cur.HasValue & x > valueVal)
                    {
                        valueVal = x;
                        value = cur;
                    }
                }
            }
            return value;
        }

        public static decimal Max(this IEnumerable<decimal> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal value;
            using (IEnumerator<decimal> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                value = e.Current;
                while (e.MoveNext())
                {
                    decimal x = e.Current;
                    if (x > value) value = x;
                }
            }
            return value;
        }

        public static decimal? Max(this IEnumerable<decimal?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal? value;
            using (IEnumerator<decimal?> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) return null;
                value = e.Current;
                while (!value.HasValue)
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                }
                decimal valueVal = value.GetValueOrDefault();
                while (e.MoveNext())
                {
                    decimal? cur = e.Current;
                    decimal x = cur.GetValueOrDefault();
                    if (cur.HasValue && x > valueVal)
                    {
                        valueVal = x;
                        value = cur;
                    }
                }
            }
            return value;
        }

        public static TSource Max<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            Comparer<TSource> comparer = Comparer<TSource>.Default;
            TSource value = default(TSource);
            if (value == null)
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (!e.MoveNext()) return value;
                    value = e.Current;
                    // A do…while may seem more natural here, but profiled worse across a wide set of test data
                    while (value == null)
                    {
                        if (!e.MoveNext()) return value;
                        value = e.Current;
                    } while (value == null);
                    while (e.MoveNext())
                    {
                        TSource x = e.Current;
                        if (x != null && comparer.Compare(x, value) > 0) value = x;
                    }
                }
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (!e.MoveNext()) throw Error.NoElements();
                    value = e.Current;
                    while (e.MoveNext())
                    {
                        TSource x = e.Current;
                        if (comparer.Compare(x, value) > 0) value = x;
                    }
                }
            }
            return value;
        }

        public static double Average(this IEnumerable<int> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            using (IEnumerator<int> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                long sum = e.Current;
                long count = 1;
                checked
                {
                    while (e.MoveNext())
                    {
                        sum += e.Current;
                        ++count;
                    }
                }
                return (double)sum / count;
            }
        }

        public static double? Average(this IEnumerable<int?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            using (IEnumerator<int?> e = source.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    int? v = e.Current;
                    if (v.HasValue)
                    {
                        long sum = v.GetValueOrDefault();
                        long count = 1;
                        checked
                        {
                            while (e.MoveNext())
                            {
                                v = e.Current;
                                if (v.HasValue)
                                {
                                    sum += v.GetValueOrDefault();
                                    ++count;
                                }
                            }
                        }
                        return (double)sum / count;
                    }
                }
            }
            return null;
        }

        public static double Average(this IEnumerable<long> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            using (IEnumerator<long> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                long sum = e.Current;
                long count = 1;
                checked
                {
                    while (e.MoveNext())
                    {
                        sum += e.Current;
                        ++count;
                    }
                }
                return (double)sum / count;
            }
        }

        public static double? Average(this IEnumerable<long?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            using (IEnumerator<long?> e = source.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    long? v = e.Current;
                    if (v.HasValue)
                    {
                        long sum = v.GetValueOrDefault();
                        long count = 1;
                        checked
                        {
                            while (e.MoveNext())
                            {
                                v = e.Current;
                                if (v.HasValue)
                                {
                                    sum += v.GetValueOrDefault();
                                    ++count;
                                }
                            }
                        }
                        return (double)sum / count;
                    }
                }
            }
            return null;
        }

        public static float Average(this IEnumerable<float> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            using (IEnumerator<float> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                double sum = e.Current;
                long count = 1;
                while (e.MoveNext())
                {
                    sum += e.Current;
                    ++count;
                }
                return (float)(sum / count);
            }
        }

        public static float? Average(this IEnumerable<float?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            using (IEnumerator<float?> e = source.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    float? v = e.Current;
                    if (v.HasValue)
                    {
                        double sum = v.GetValueOrDefault();
                        long count = 1;
                        checked
                        {
                            while (e.MoveNext())
                            {
                                v = e.Current;
                                if (v.HasValue)
                                {
                                    sum += v.GetValueOrDefault();
                                    ++count;
                                }
                            }
                        }
                        return (float)(sum / count);
                    }
                }
            }
            return null;
        }

        public static double Average(this IEnumerable<double> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            using (IEnumerator<double> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                double sum = e.Current;
                long count = 1;
                while (e.MoveNext())
                {
                    // There is an opportunity to short-circuit here, in that if e.Current is
                    // ever NaN then the result will always be NaN. Assuming that this case is
                    // rare enough that not checking is the better approach generally.
                    sum += e.Current;
                    ++count;
                }
                return sum / count;
            }
        }

        public static double? Average(this IEnumerable<double?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            using (IEnumerator<double?> e = source.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    double? v = e.Current;
                    if (v.HasValue)
                    {
                        double sum = v.GetValueOrDefault();
                        long count = 1;
                        checked
                        {
                            while (e.MoveNext())
                            {
                                v = e.Current;
                                if (v.HasValue)
                                {
                                    sum += v.GetValueOrDefault();
                                    ++count;
                                }
                            }
                        }
                        return sum / count;
                    }
                }
            }
            return null;
        }

        public static decimal Average(this IEnumerable<decimal> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            using (IEnumerator<decimal> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                decimal sum = e.Current;
                long count = 1;
                while (e.MoveNext())
                {
                    sum += e.Current;
                    ++count;
                }
                return sum / count;
            }
        }

        public static decimal? Average(this IEnumerable<decimal?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            using (IEnumerator<decimal?> e = source.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    decimal? v = e.Current;
                    if (v.HasValue)
                    {
                        decimal sum = v.GetValueOrDefault();
                        long count = 1;
                        while (e.MoveNext())
                        {
                            v = e.Current;
                            if (v.HasValue)
                            {
                                sum += v.GetValueOrDefault();
                                ++count;
                            }
                        }
                        return sum / count;
                    }
                }
            }
            return null;
        }
    }
}