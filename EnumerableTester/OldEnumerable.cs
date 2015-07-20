using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumerableTester
{
    public static class OldEnumerable
    {
        public static int Min(this IEnumerable<int> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            int value = 0;
            bool hasValue = false;
            foreach (int x in source)
            {
                if (hasValue)
                {
                    if (x < value) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw Error.NoElements();
        }

        public static int? Min(this IEnumerable<int?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            int? value = null;
            foreach (int? x in source)
            {
                if (value == null || x < value)
                    value = x;
            }
            return value;
        }

        public static long Min(this IEnumerable<long> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long value = 0;
            bool hasValue = false;
            foreach (long x in source)
            {
                if (hasValue)
                {
                    if (x < value) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw Error.NoElements();
        }

        public static long? Min(this IEnumerable<long?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long? value = null;
            foreach (long? x in source)
            {
                if (value == null || x < value) value = x;
            }
            return value;
        }

        public static float Min(this IEnumerable<float> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            float value = 0;
            bool hasValue = false;
            foreach (float x in source)
            {
                if (hasValue)
                {
                    // Normally NaN < anything is false, as is anything < NaN
                    // However, this leads to some irksome outcomes in Min and Max.
                    // If we use those semantics then Min(NaN, 5.0) is NaN, but
                    // Min(5.0, NaN) is 5.0!  To fix this, we impose a total
                    // ordering where NaN is smaller than every value, including
                    // negative infinity.
                    if (x < value || System.Single.IsNaN(x)) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw Error.NoElements();
        }

        public static float? Min(this IEnumerable<float?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            float? value = null;
            foreach (float? x in source)
            {
                if (x == null) continue;
                if (value == null || x < value || System.Single.IsNaN((float)x)) value = x;
            }
            return value;
        }

        public static double Min(this IEnumerable<double> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double value = 0;
            bool hasValue = false;
            foreach (double x in source)
            {
                if (hasValue)
                {
                    if (x < value || System.Double.IsNaN(x)) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw Error.NoElements();
        }

        public static double? Min(this IEnumerable<double?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double? value = null;
            foreach (double? x in source)
            {
                if (x == null) continue;
                if (value == null || x < value || System.Double.IsNaN((double)x)) value = x;
            }
            return value;
        }

        public static decimal Min(this IEnumerable<decimal> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal value = 0;
            bool hasValue = false;
            foreach (decimal x in source)
            {
                if (hasValue)
                {
                    if (x < value) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw Error.NoElements();
        }

        public static decimal? Min(this IEnumerable<decimal?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal? value = null;
            foreach (decimal? x in source)
            {
                if (value == null || x < value) value = x;
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
                foreach (TSource x in source)
                {
                    if (x != null && (value == null || comparer.Compare(x, value) < 0))
                        value = x;
                }
                return value;
            }
            else
            {
                bool hasValue = false;
                foreach (TSource x in source)
                {
                    if (hasValue)
                    {
                        if (comparer.Compare(x, value) < 0)
                            value = x;
                    }
                    else
                    {
                        value = x;
                        hasValue = true;
                    }
                }
                if (hasValue) return value;
                throw Error.NoElements();
            }
        }

        public static int Max(this IEnumerable<int> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            int value = 0;
            bool hasValue = false;
            foreach (int x in source)
            {
                if (hasValue)
                {
                    if (x > value) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw Error.NoElements();
        }

        public static int? Max(this IEnumerable<int?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            int? value = null;
            foreach (int? x in source)
            {
                if (value == null || x > value) value = x;
            }
            return value;
        }

        public static long Max(this IEnumerable<long> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long value = 0;
            bool hasValue = false;
            foreach (long x in source)
            {
                if (hasValue)
                {
                    if (x > value) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw Error.NoElements();
        }

        public static long? Max(this IEnumerable<long?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long? value = null;
            foreach (long? x in source)
            {
                if (value == null || x > value) value = x;
            }
            return value;
        }

        public static double Max(this IEnumerable<double> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double value = 0;
            bool hasValue = false;
            foreach (double x in source)
            {
                if (hasValue)
                {
                    if (x > value || System.Double.IsNaN(value)) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw Error.NoElements();
        }

        public static double? Max(this IEnumerable<double?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double? value = null;
            foreach (double? x in source)
            {
                if (x == null) continue;
                if (value == null || x > value || System.Double.IsNaN((double)value)) value = x;
            }
            return value;
        }

        public static float Max(this IEnumerable<float> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            float value = 0;
            bool hasValue = false;
            foreach (float x in source)
            {
                if (hasValue)
                {
                    if (x > value || System.Double.IsNaN(value)) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw Error.NoElements();
        }

        public static float? Max(this IEnumerable<float?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            float? value = null;
            foreach (float? x in source)
            {
                if (x == null) continue;
                if (value == null || x > value || System.Single.IsNaN((float)value)) value = x;
            }
            return value;
        }

        public static decimal Max(this IEnumerable<decimal> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal value = 0;
            bool hasValue = false;
            foreach (decimal x in source)
            {
                if (hasValue)
                {
                    if (x > value) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw Error.NoElements();
        }

        public static decimal? Max(this IEnumerable<decimal?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal? value = null;
            foreach (decimal? x in source)
            {
                if (value == null || x > value) value = x;
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
                foreach (TSource x in source)
                {
                    if (x != null && (value == null || comparer.Compare(x, value) > 0))
                        value = x;
                }
                return value;
            }
            else
            {
                bool hasValue = false;
                foreach (TSource x in source)
                {
                    if (hasValue)
                    {
                        if (comparer.Compare(x, value) > 0)
                            value = x;
                    }
                    else
                    {
                        value = x;
                        hasValue = true;
                    }
                }
                if (hasValue) return value;
                throw Error.NoElements();
            }
        }

        public static double Average(this IEnumerable<int> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long sum = 0;
            long count = 0;
            checked
            {
                foreach (int v in source)
                {
                    sum += v;
                    count++;
                }
            }
            if (count > 0) return (double)sum / count;
            throw Error.NoElements();
        }

        public static double? Average(this IEnumerable<int?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long sum = 0;
            long count = 0;
            checked
            {
                foreach (int? v in source)
                {
                    if (v != null)
                    {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            if (count > 0) return (double)sum / count;
            return null;
        }

        public static double Average(this IEnumerable<long> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long sum = 0;
            long count = 0;
            checked
            {
                foreach (long v in source)
                {
                    sum += v;
                    count++;
                }
            }
            if (count > 0) return (double)sum / count;
            throw Error.NoElements();
        }

        public static double? Average(this IEnumerable<long?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            long sum = 0;
            long count = 0;
            checked
            {
                foreach (long? v in source)
                {
                    if (v != null)
                    {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            if (count > 0) return (double)sum / count;
            return null;
        }

        public static float Average(this IEnumerable<float> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double sum = 0;
            long count = 0;
            checked
            {
                foreach (float v in source)
                {
                    sum += v;
                    count++;
                }
            }
            if (count > 0) return (float)(sum / count);
            throw Error.NoElements();
        }

        public static float? Average(this IEnumerable<float?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double sum = 0;
            long count = 0;
            checked
            {
                foreach (float? v in source)
                {
                    if (v != null)
                    {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            if (count > 0) return (float)(sum / count);
            return null;
        }

        public static double Average(this IEnumerable<double> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double sum = 0;
            long count = 0;
            checked
            {
                foreach (double v in source)
                {
                    sum += v;
                    count++;
                }
            }
            if (count > 0) return sum / count;
            throw Error.NoElements();
        }

        public static double? Average(this IEnumerable<double?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            double sum = 0;
            long count = 0;
            checked
            {
                foreach (double? v in source)
                {
                    if (v != null)
                    {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            if (count > 0) return sum / count;
            return null;
        }

        public static decimal Average(this IEnumerable<decimal> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal sum = 0;
            long count = 0;
            checked
            {
                foreach (decimal v in source)
                {
                    sum += v;
                    count++;
                }
            }
            if (count > 0) return sum / count;
            throw Error.NoElements();
        }

        public static decimal? Average(this IEnumerable<decimal?> source)
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal sum = 0;
            long count = 0;
            checked
            {
                foreach (decimal? v in source)
                {
                    if (v != null)
                    {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            if (count > 0) return sum / count;
            return null;
        }
    }
}