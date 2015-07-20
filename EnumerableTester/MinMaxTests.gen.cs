using System;
using System.Diagnostics;
using System.Linq;

namespace EnumerableTester
{
    public static class MinMaxTests
    {
                    private static void TestOldEnumerableInt32IncrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt32IncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32IncrementedMin()
        {
            Console.WriteLine("TestOldEnumerableInt32IncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32DecrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt32DecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32DecrementedMin()
        {
            Console.WriteLine("TestOldEnumerableInt32DecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32UpAndDownNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt32UpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32UpAndDownMin()
        {
            Console.WriteLine("TestOldEnumerableInt32UpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32ShuffledNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt32ShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32ShuffledMin()
        {
            Console.WriteLine("TestOldEnumerableInt32ShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32SolitaireNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt32SolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32SolitaireMin()
        {
            Console.WriteLine("TestOldEnumerableInt32SolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32EmptyNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt32EmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.EmptyNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32EmptyMin()
        {
            Console.WriteLine("TestOldEnumerableInt32EmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Min(SourceEnumerables.EmptyInt32);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableInt3210PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3210PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt3210PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3220PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3220PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt3220PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3230PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3230PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt3230PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3240PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3240PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt3240PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3250PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3250PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt3250PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3260PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3260PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt3260PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3270PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3270PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt3270PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3280PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3280PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt3280PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3290PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3290PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt3290PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestOldEnumerableInt32IncrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt32IncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32IncrementedMax()
        {
            Console.WriteLine("TestOldEnumerableInt32IncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32DecrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt32DecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32DecrementedMax()
        {
            Console.WriteLine("TestOldEnumerableInt32DecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32UpAndDownNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt32UpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32UpAndDownMax()
        {
            Console.WriteLine("TestOldEnumerableInt32UpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32ShuffledNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt32ShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32ShuffledMax()
        {
            Console.WriteLine("TestOldEnumerableInt32ShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32SolitaireNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt32SolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32SolitaireMax()
        {
            Console.WriteLine("TestOldEnumerableInt32SolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32EmptyNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt32EmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.EmptyNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32EmptyMax()
        {
            Console.WriteLine("TestOldEnumerableInt32EmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Max(SourceEnumerables.EmptyInt32);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableInt3210PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3210PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt3210PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3220PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3220PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt3220PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3230PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3230PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt3230PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3240PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3240PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt3240PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3250PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3250PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt3250PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3260PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3260PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt3260PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3270PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3270PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt3270PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3280PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3280PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt3280PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3290PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3290PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt3290PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestOldEnumerableInt64IncrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt64IncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64IncrementedMin()
        {
            Console.WriteLine("TestOldEnumerableInt64IncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64DecrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt64DecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64DecrementedMin()
        {
            Console.WriteLine("TestOldEnumerableInt64DecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64UpAndDownNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt64UpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64UpAndDownMin()
        {
            Console.WriteLine("TestOldEnumerableInt64UpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64ShuffledNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt64ShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64ShuffledMin()
        {
            Console.WriteLine("TestOldEnumerableInt64ShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64SolitaireNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt64SolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64SolitaireMin()
        {
            Console.WriteLine("TestOldEnumerableInt64SolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64EmptyNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableInt64EmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.EmptyNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64EmptyMin()
        {
            Console.WriteLine("TestOldEnumerableInt64EmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Min(SourceEnumerables.EmptyInt64);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableInt6410PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6410PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt6410PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6420PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6420PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt6420PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6430PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6430PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt6430PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6440PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6440PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt6440PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6450PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6450PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt6450PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6460PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6460PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt6460PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6470PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6470PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt6470PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6480PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6480PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt6480PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6490PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6490PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableInt6490PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestOldEnumerableInt64IncrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt64IncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64IncrementedMax()
        {
            Console.WriteLine("TestOldEnumerableInt64IncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64DecrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt64DecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64DecrementedMax()
        {
            Console.WriteLine("TestOldEnumerableInt64DecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64UpAndDownNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt64UpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64UpAndDownMax()
        {
            Console.WriteLine("TestOldEnumerableInt64UpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64ShuffledNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt64ShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64ShuffledMax()
        {
            Console.WriteLine("TestOldEnumerableInt64ShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64SolitaireNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt64SolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64SolitaireMax()
        {
            Console.WriteLine("TestOldEnumerableInt64SolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64EmptyNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableInt64EmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.EmptyNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64EmptyMax()
        {
            Console.WriteLine("TestOldEnumerableInt64EmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Max(SourceEnumerables.EmptyInt64);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableInt6410PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6410PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt6410PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6420PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6420PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt6420PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6430PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6430PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt6430PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6440PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6440PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt6440PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6450PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6450PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt6450PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6460PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6460PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt6460PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6470PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6470PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt6470PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6480PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6480PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt6480PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6490PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6490PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableInt6490PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestOldEnumerableSingleIncrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableSingleIncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleIncrementedMin()
        {
            Console.WriteLine("TestOldEnumerableSingleIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleDecrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableSingleDecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleDecrementedMin()
        {
            Console.WriteLine("TestOldEnumerableSingleDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleUpAndDownNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableSingleUpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleUpAndDownMin()
        {
            Console.WriteLine("TestOldEnumerableSingleUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleShuffledNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableSingleShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleShuffledMin()
        {
            Console.WriteLine("TestOldEnumerableSingleShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleSolitaireNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableSingleSolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleSolitaireMin()
        {
            Console.WriteLine("TestOldEnumerableSingleSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleEmptyNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableSingleEmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.EmptyNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleEmptyMin()
        {
            Console.WriteLine("TestOldEnumerableSingleEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Min(SourceEnumerables.EmptySingle);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableSingle10PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableSingle10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle20PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableSingle20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle30PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableSingle30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle40PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableSingle40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle50PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableSingle50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle60PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableSingle60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle70PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableSingle70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle80PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableSingle80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle90PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableSingle90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestOldEnumerableSingle10PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableSingle10PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Single10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle10PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle10PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableSingle10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle20PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableSingle20PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Single20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle20PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle20PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableSingle20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle30PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableSingle30PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Single30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle30PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle30PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableSingle30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle40PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableSingle40PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Single40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle40PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle40PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableSingle40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle50PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableSingle50PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Single50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle50PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle50PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableSingle50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle60PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableSingle60PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Single60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle60PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle60PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableSingle60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle70PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableSingle70PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Single70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle70PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle70PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableSingle70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle80PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableSingle80PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Single80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle80PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle80PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableSingle80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle90PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableSingle90PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Single90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle90PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle90PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableSingle90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestOldEnumerableSingleIncrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableSingleIncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleIncrementedMax()
        {
            Console.WriteLine("TestOldEnumerableSingleIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleDecrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableSingleDecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleDecrementedMax()
        {
            Console.WriteLine("TestOldEnumerableSingleDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleUpAndDownNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableSingleUpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleUpAndDownMax()
        {
            Console.WriteLine("TestOldEnumerableSingleUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleShuffledNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableSingleShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleShuffledMax()
        {
            Console.WriteLine("TestOldEnumerableSingleShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleSolitaireNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableSingleSolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleSolitaireMax()
        {
            Console.WriteLine("TestOldEnumerableSingleSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleEmptyNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableSingleEmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.EmptyNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleEmptyMax()
        {
            Console.WriteLine("TestOldEnumerableSingleEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Max(SourceEnumerables.EmptySingle);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableSingle10PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableSingle10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle20PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableSingle20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle30PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableSingle30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle40PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableSingle40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle50PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableSingle50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle60PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableSingle60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle70PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableSingle70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle80PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableSingle80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle90PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableSingle90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestOldEnumerableSingle10PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableSingle10PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Single10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle10PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle10PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableSingle10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle20PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableSingle20PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Single20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle20PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle20PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableSingle20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle30PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableSingle30PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Single30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle30PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle30PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableSingle30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle40PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableSingle40PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Single40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle40PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle40PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableSingle40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle50PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableSingle50PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Single50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle50PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle50PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableSingle50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle60PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableSingle60PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Single60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle60PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle60PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableSingle60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle70PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableSingle70PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Single70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle70PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle70PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableSingle70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle80PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableSingle80PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Single80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle80PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle80PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableSingle80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle90PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableSingle90PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Single90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle90PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle90PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableSingle90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestOldEnumerableDoubleIncrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDoubleIncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleIncrementedMin()
        {
            Console.WriteLine("TestOldEnumerableDoubleIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleDecrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDoubleDecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleDecrementedMin()
        {
            Console.WriteLine("TestOldEnumerableDoubleDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleUpAndDownNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDoubleUpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleUpAndDownMin()
        {
            Console.WriteLine("TestOldEnumerableDoubleUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleShuffledNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDoubleShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleShuffledMin()
        {
            Console.WriteLine("TestOldEnumerableDoubleShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleSolitaireNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDoubleSolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleSolitaireMin()
        {
            Console.WriteLine("TestOldEnumerableDoubleSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleEmptyNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDoubleEmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.EmptyNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleEmptyMin()
        {
            Console.WriteLine("TestOldEnumerableDoubleEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Min(SourceEnumerables.EmptyDouble);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableDouble10PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDouble10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble20PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDouble20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble30PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDouble30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble40PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDouble40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble50PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDouble50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble60PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDouble60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble70PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDouble70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble80PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDouble80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble90PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDouble90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestOldEnumerableDouble10PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableDouble10PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Double10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble10PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble10PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableDouble10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble20PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableDouble20PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Double20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble20PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble20PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableDouble20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble30PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableDouble30PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Double30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble30PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble30PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableDouble30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble40PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableDouble40PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Double40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble40PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble40PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableDouble40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble50PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableDouble50PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Double50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble50PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble50PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableDouble50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble60PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableDouble60PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Double60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble60PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble60PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableDouble60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble70PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableDouble70PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Double70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble70PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble70PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableDouble70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble80PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableDouble80PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Double80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble80PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble80PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableDouble80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble90PercentNaNMin()
        {
            Console.WriteLine("TestOldEnumerableDouble90PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.Double90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble90PercentNaNOrNullMin()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble90PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Min(SourceEnumerables.NullableDouble90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestOldEnumerableDoubleIncrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDoubleIncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleIncrementedMax()
        {
            Console.WriteLine("TestOldEnumerableDoubleIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleDecrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDoubleDecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleDecrementedMax()
        {
            Console.WriteLine("TestOldEnumerableDoubleDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleUpAndDownNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDoubleUpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleUpAndDownMax()
        {
            Console.WriteLine("TestOldEnumerableDoubleUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleShuffledNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDoubleShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleShuffledMax()
        {
            Console.WriteLine("TestOldEnumerableDoubleShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleSolitaireNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDoubleSolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleSolitaireMax()
        {
            Console.WriteLine("TestOldEnumerableDoubleSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleEmptyNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDoubleEmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.EmptyNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleEmptyMax()
        {
            Console.WriteLine("TestOldEnumerableDoubleEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Max(SourceEnumerables.EmptyDouble);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableDouble10PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDouble10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble20PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDouble20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble30PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDouble30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble40PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDouble40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble50PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDouble50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble60PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDouble60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble70PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDouble70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble80PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDouble80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble90PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDouble90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestOldEnumerableDouble10PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableDouble10PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Double10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble10PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble10PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableDouble10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble20PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableDouble20PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Double20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble20PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble20PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableDouble20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble30PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableDouble30PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Double30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble30PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble30PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableDouble30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble40PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableDouble40PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Double40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble40PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble40PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableDouble40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble50PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableDouble50PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Double50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble50PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble50PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableDouble50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble60PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableDouble60PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Double60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble60PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble60PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableDouble60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble70PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableDouble70PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Double70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble70PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble70PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableDouble70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble80PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableDouble80PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Double80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble80PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble80PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableDouble80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble90PercentNaNMax()
        {
            Console.WriteLine("TestOldEnumerableDouble90PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.Double90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble90PercentNaNOrNullMax()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble90PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Max(SourceEnumerables.NullableDouble90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestOldEnumerableDecimalIncrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDecimalIncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalIncrementedMin()
        {
            Console.WriteLine("TestOldEnumerableDecimalIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalDecrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDecimalDecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalDecrementedMin()
        {
            Console.WriteLine("TestOldEnumerableDecimalDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalUpAndDownNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDecimalUpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalUpAndDownMin()
        {
            Console.WriteLine("TestOldEnumerableDecimalUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalShuffledNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDecimalShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalShuffledMin()
        {
            Console.WriteLine("TestOldEnumerableDecimalShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalSolitaireNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDecimalSolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalSolitaireMin()
        {
            Console.WriteLine("TestOldEnumerableDecimalSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalEmptyNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDecimalEmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.EmptyNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalEmptyMin()
        {
            Console.WriteLine("TestOldEnumerableDecimalEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Min(SourceEnumerables.EmptyDecimal);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableDecimal10PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDecimal10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal20PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDecimal20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal30PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDecimal30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal40PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDecimal40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal50PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDecimal50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal60PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDecimal60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal70PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDecimal70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal80PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDecimal80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal90PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDecimal90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestOldEnumerableDecimalIncrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDecimalIncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalIncrementedMax()
        {
            Console.WriteLine("TestOldEnumerableDecimalIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalDecrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDecimalDecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalDecrementedMax()
        {
            Console.WriteLine("TestOldEnumerableDecimalDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalUpAndDownNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDecimalUpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalUpAndDownMax()
        {
            Console.WriteLine("TestOldEnumerableDecimalUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalShuffledNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDecimalShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalShuffledMax()
        {
            Console.WriteLine("TestOldEnumerableDecimalShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalSolitaireNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDecimalSolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalSolitaireMax()
        {
            Console.WriteLine("TestOldEnumerableDecimalSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalEmptyNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDecimalEmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.EmptyNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalEmptyMax()
        {
            Console.WriteLine("TestOldEnumerableDecimalEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Max(SourceEnumerables.EmptyDecimal);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableDecimal10PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDecimal10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal20PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDecimal20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal30PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDecimal30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal40PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDecimal40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal50PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDecimal50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal60PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDecimal60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal70PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDecimal70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal80PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDecimal80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal90PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDecimal90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }        private static void TestOldEnumerableStringIncrementedMin()
        {
            Console.WriteLine("TestOldEnumerableStringIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableStringDecrementedMin()
        {
            Console.WriteLine("TestOldEnumerableStringDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableStringUpAndDownMin()
        {
            Console.WriteLine("TestOldEnumerableStringUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableStringShuffledMin()
        {
            Console.WriteLine("TestOldEnumerableStringShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableStringSolitaireMin()
        {
            Console.WriteLine("TestOldEnumerableStringSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableStringEmptyMin()
        {
            Console.WriteLine("TestOldEnumerableStringEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Min(SourceEnumerables.EmptyString);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableString10PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableString10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.String10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString20PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableString20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.String20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString30PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableString30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.String30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString40PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableString40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.String40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString50PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableString50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.String50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString60PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableString60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.String60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString70PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableString70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.String70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString80PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableString80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.String80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString90PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableString90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.String90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }        private static void TestOldEnumerableStringIncrementedMax()
        {
            Console.WriteLine("TestOldEnumerableStringIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableStringDecrementedMax()
        {
            Console.WriteLine("TestOldEnumerableStringDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableStringUpAndDownMax()
        {
            Console.WriteLine("TestOldEnumerableStringUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableStringShuffledMax()
        {
            Console.WriteLine("TestOldEnumerableStringShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableStringSolitaireMax()
        {
            Console.WriteLine("TestOldEnumerableStringSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableStringEmptyMax()
        {
            Console.WriteLine("TestOldEnumerableStringEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Max(SourceEnumerables.EmptyString);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableString10PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableString10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.String10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString20PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableString20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.String20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString30PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableString30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.String30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString40PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableString40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.String40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString50PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableString50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.String50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString60PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableString60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.String60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString70PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableString70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.String70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString80PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableString80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.String80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableString90PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableString90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.String90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestOldEnumerableDateTimeIncrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeIncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeIncrementedMin()
        {
            Console.WriteLine("TestOldEnumerableDateTimeIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDateTimeDecrementedNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeDecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeDecrementedMin()
        {
            Console.WriteLine("TestOldEnumerableDateTimeDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDateTimeUpAndDownNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeUpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeUpAndDownMin()
        {
            Console.WriteLine("TestOldEnumerableDateTimeUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDateTimeShuffledNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeShuffledMin()
        {
            Console.WriteLine("TestOldEnumerableDateTimeShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDateTimeSolitaireNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeSolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeSolitaireMin()
        {
            Console.WriteLine("TestOldEnumerableDateTimeSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDateTimeEmptyNullableMin()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeEmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.EmptyNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeEmptyMin()
        {
            Console.WriteLine("TestOldEnumerableDateTimeEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Min(SourceEnumerables.EmptyDateTime);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableDateTime10PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDateTime10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime20PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDateTime20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime30PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDateTime30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime40PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDateTime40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime50PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDateTime50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime60PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDateTime60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime70PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDateTime70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime80PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDateTime80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime90PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.NullableDateTime90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestOldEnumerableDateTimeIncrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeIncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeIncrementedMax()
        {
            Console.WriteLine("TestOldEnumerableDateTimeIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDateTimeDecrementedNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeDecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeDecrementedMax()
        {
            Console.WriteLine("TestOldEnumerableDateTimeDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDateTimeUpAndDownNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeUpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeUpAndDownMax()
        {
            Console.WriteLine("TestOldEnumerableDateTimeUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDateTimeShuffledNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeShuffledMax()
        {
            Console.WriteLine("TestOldEnumerableDateTimeShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDateTimeSolitaireNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeSolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeSolitaireMax()
        {
            Console.WriteLine("TestOldEnumerableDateTimeSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDateTimeEmptyNullableMax()
                {
                    Console.WriteLine("TestOldEnumerableDateTimeEmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.EmptyNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDateTimeEmptyMax()
        {
            Console.WriteLine("TestOldEnumerableDateTimeEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Max(SourceEnumerables.EmptyDateTime);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableDateTime10PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDateTime10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime20PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDateTime20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime30PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDateTime30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime40PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDateTime40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime50PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDateTime50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime60PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDateTime60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime70PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDateTime70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime80PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDateTime80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDateTime90PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableNullableDateTime90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.NullableDateTime90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }        private static void TestOldEnumerableExampleReferenceTypeIncrementedMin()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.IncrementedExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableExampleReferenceTypeDecrementedMin()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.DecrementedExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableExampleReferenceTypeUpAndDownMin()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.UpAndDownExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableExampleReferenceTypeShuffledMin()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.ShuffledExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableExampleReferenceTypeSolitaireMin()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Min(SourceEnumerables.SolitaireExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableExampleReferenceTypeEmptyMin()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Min(SourceEnumerables.EmptyExampleReferenceType);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableExampleReferenceType10PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.ExampleReferenceType10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType20PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.ExampleReferenceType20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType30PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.ExampleReferenceType30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType40PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.ExampleReferenceType40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType50PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.ExampleReferenceType50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType60PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.ExampleReferenceType60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType70PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.ExampleReferenceType70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType80PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.ExampleReferenceType80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType90PercentNulledMin()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Min(SourceEnumerables.ExampleReferenceType90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }        private static void TestOldEnumerableExampleReferenceTypeIncrementedMax()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.IncrementedExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableExampleReferenceTypeDecrementedMax()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.DecrementedExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableExampleReferenceTypeUpAndDownMax()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.UpAndDownExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableExampleReferenceTypeShuffledMax()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.ShuffledExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableExampleReferenceTypeSolitaireMax()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Max(SourceEnumerables.SolitaireExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableExampleReferenceTypeEmptyMax()
        {
            Console.WriteLine("TestOldEnumerableExampleReferenceTypeEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Max(SourceEnumerables.EmptyExampleReferenceType);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableExampleReferenceType10PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.ExampleReferenceType10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType20PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.ExampleReferenceType20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType30PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.ExampleReferenceType30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType40PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.ExampleReferenceType40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType50PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.ExampleReferenceType50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType60PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.ExampleReferenceType60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType70PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.ExampleReferenceType70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType80PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.ExampleReferenceType80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableExampleReferenceType90PercentNulledMax()
            {
                Console.WriteLine("TestOldEnumerableExampleReferenceType90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Max(SourceEnumerables.ExampleReferenceType90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableInt32IncrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt32IncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32IncrementedMin()
        {
            Console.WriteLine("TestNewEnumerableInt32IncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32DecrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt32DecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32DecrementedMin()
        {
            Console.WriteLine("TestNewEnumerableInt32DecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32UpAndDownNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt32UpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32UpAndDownMin()
        {
            Console.WriteLine("TestNewEnumerableInt32UpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32ShuffledNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt32ShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32ShuffledMin()
        {
            Console.WriteLine("TestNewEnumerableInt32ShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32SolitaireNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt32SolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32SolitaireMin()
        {
            Console.WriteLine("TestNewEnumerableInt32SolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32EmptyNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt32EmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.EmptyNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32EmptyMin()
        {
            Console.WriteLine("TestNewEnumerableInt32EmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Min(SourceEnumerables.EmptyInt32);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableInt3210PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3210PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt3210PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3220PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3220PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt3220PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3230PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3230PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt3230PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3240PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3240PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt3240PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3250PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3250PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt3250PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3260PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3260PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt3260PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3270PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3270PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt3270PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3280PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3280PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt3280PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3290PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3290PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt3290PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableInt32IncrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt32IncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32IncrementedMax()
        {
            Console.WriteLine("TestNewEnumerableInt32IncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32DecrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt32DecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32DecrementedMax()
        {
            Console.WriteLine("TestNewEnumerableInt32DecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32UpAndDownNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt32UpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32UpAndDownMax()
        {
            Console.WriteLine("TestNewEnumerableInt32UpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32ShuffledNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt32ShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32ShuffledMax()
        {
            Console.WriteLine("TestNewEnumerableInt32ShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32SolitaireNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt32SolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32SolitaireMax()
        {
            Console.WriteLine("TestNewEnumerableInt32SolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32EmptyNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt32EmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.EmptyNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32EmptyMax()
        {
            Console.WriteLine("TestNewEnumerableInt32EmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Max(SourceEnumerables.EmptyInt32);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableInt3210PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3210PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt3210PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3220PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3220PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt3220PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3230PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3230PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt3230PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3240PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3240PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt3240PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3250PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3250PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt3250PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3260PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3260PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt3260PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3270PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3270PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt3270PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3280PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3280PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt3280PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3290PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3290PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt3290PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableInt64IncrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt64IncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64IncrementedMin()
        {
            Console.WriteLine("TestNewEnumerableInt64IncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64DecrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt64DecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64DecrementedMin()
        {
            Console.WriteLine("TestNewEnumerableInt64DecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64UpAndDownNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt64UpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64UpAndDownMin()
        {
            Console.WriteLine("TestNewEnumerableInt64UpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64ShuffledNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt64ShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64ShuffledMin()
        {
            Console.WriteLine("TestNewEnumerableInt64ShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64SolitaireNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt64SolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64SolitaireMin()
        {
            Console.WriteLine("TestNewEnumerableInt64SolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64EmptyNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableInt64EmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.EmptyNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64EmptyMin()
        {
            Console.WriteLine("TestNewEnumerableInt64EmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Min(SourceEnumerables.EmptyInt64);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableInt6410PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6410PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt6410PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6420PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6420PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt6420PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6430PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6430PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt6430PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6440PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6440PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt6440PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6450PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6450PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt6450PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6460PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6460PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt6460PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6470PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6470PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt6470PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6480PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6480PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt6480PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6490PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6490PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableInt6490PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableInt64IncrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt64IncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64IncrementedMax()
        {
            Console.WriteLine("TestNewEnumerableInt64IncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64DecrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt64DecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64DecrementedMax()
        {
            Console.WriteLine("TestNewEnumerableInt64DecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64UpAndDownNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt64UpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64UpAndDownMax()
        {
            Console.WriteLine("TestNewEnumerableInt64UpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64ShuffledNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt64ShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64ShuffledMax()
        {
            Console.WriteLine("TestNewEnumerableInt64ShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64SolitaireNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt64SolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64SolitaireMax()
        {
            Console.WriteLine("TestNewEnumerableInt64SolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64EmptyNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableInt64EmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.EmptyNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64EmptyMax()
        {
            Console.WriteLine("TestNewEnumerableInt64EmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Max(SourceEnumerables.EmptyInt64);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableInt6410PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6410PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt6410PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6420PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6420PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt6420PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6430PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6430PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt6430PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6440PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6440PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt6440PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6450PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6450PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt6450PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6460PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6460PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt6460PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6470PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6470PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt6470PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6480PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6480PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt6480PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6490PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6490PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableInt6490PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableSingleIncrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableSingleIncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleIncrementedMin()
        {
            Console.WriteLine("TestNewEnumerableSingleIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleDecrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableSingleDecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleDecrementedMin()
        {
            Console.WriteLine("TestNewEnumerableSingleDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleUpAndDownNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableSingleUpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleUpAndDownMin()
        {
            Console.WriteLine("TestNewEnumerableSingleUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleShuffledNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableSingleShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleShuffledMin()
        {
            Console.WriteLine("TestNewEnumerableSingleShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleSolitaireNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableSingleSolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleSolitaireMin()
        {
            Console.WriteLine("TestNewEnumerableSingleSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleEmptyNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableSingleEmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.EmptyNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleEmptyMin()
        {
            Console.WriteLine("TestNewEnumerableSingleEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Min(SourceEnumerables.EmptySingle);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableSingle10PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableSingle10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle20PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableSingle20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle30PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableSingle30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle40PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableSingle40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle50PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableSingle50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle60PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableSingle60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle70PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableSingle70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle80PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableSingle80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle90PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableSingle90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestNewEnumerableSingle10PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableSingle10PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Single10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle10PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle10PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableSingle10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle20PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableSingle20PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Single20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle20PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle20PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableSingle20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle30PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableSingle30PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Single30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle30PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle30PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableSingle30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle40PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableSingle40PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Single40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle40PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle40PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableSingle40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle50PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableSingle50PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Single50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle50PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle50PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableSingle50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle60PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableSingle60PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Single60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle60PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle60PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableSingle60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle70PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableSingle70PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Single70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle70PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle70PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableSingle70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle80PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableSingle80PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Single80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle80PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle80PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableSingle80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle90PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableSingle90PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Single90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle90PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle90PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableSingle90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestNewEnumerableSingleIncrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableSingleIncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleIncrementedMax()
        {
            Console.WriteLine("TestNewEnumerableSingleIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleDecrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableSingleDecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleDecrementedMax()
        {
            Console.WriteLine("TestNewEnumerableSingleDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleUpAndDownNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableSingleUpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleUpAndDownMax()
        {
            Console.WriteLine("TestNewEnumerableSingleUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleShuffledNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableSingleShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleShuffledMax()
        {
            Console.WriteLine("TestNewEnumerableSingleShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleSolitaireNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableSingleSolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleSolitaireMax()
        {
            Console.WriteLine("TestNewEnumerableSingleSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleEmptyNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableSingleEmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.EmptyNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleEmptyMax()
        {
            Console.WriteLine("TestNewEnumerableSingleEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Max(SourceEnumerables.EmptySingle);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableSingle10PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableSingle10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle20PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableSingle20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle30PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableSingle30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle40PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableSingle40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle50PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableSingle50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle60PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableSingle60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle70PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableSingle70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle80PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableSingle80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle90PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableSingle90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestNewEnumerableSingle10PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableSingle10PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Single10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle10PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle10PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableSingle10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle20PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableSingle20PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Single20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle20PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle20PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableSingle20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle30PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableSingle30PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Single30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle30PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle30PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableSingle30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle40PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableSingle40PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Single40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle40PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle40PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableSingle40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle50PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableSingle50PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Single50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle50PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle50PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableSingle50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle60PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableSingle60PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Single60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle60PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle60PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableSingle60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle70PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableSingle70PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Single70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle70PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle70PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableSingle70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle80PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableSingle80PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Single80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle80PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle80PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableSingle80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle90PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableSingle90PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Single90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle90PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle90PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableSingle90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestNewEnumerableDoubleIncrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDoubleIncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleIncrementedMin()
        {
            Console.WriteLine("TestNewEnumerableDoubleIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleDecrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDoubleDecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleDecrementedMin()
        {
            Console.WriteLine("TestNewEnumerableDoubleDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleUpAndDownNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDoubleUpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleUpAndDownMin()
        {
            Console.WriteLine("TestNewEnumerableDoubleUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleShuffledNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDoubleShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleShuffledMin()
        {
            Console.WriteLine("TestNewEnumerableDoubleShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleSolitaireNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDoubleSolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleSolitaireMin()
        {
            Console.WriteLine("TestNewEnumerableDoubleSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleEmptyNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDoubleEmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.EmptyNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleEmptyMin()
        {
            Console.WriteLine("TestNewEnumerableDoubleEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Min(SourceEnumerables.EmptyDouble);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableDouble10PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDouble10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble20PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDouble20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble30PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDouble30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble40PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDouble40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble50PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDouble50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble60PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDouble60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble70PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDouble70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble80PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDouble80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble90PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDouble90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestNewEnumerableDouble10PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableDouble10PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Double10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble10PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble10PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableDouble10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble20PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableDouble20PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Double20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble20PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble20PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableDouble20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble30PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableDouble30PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Double30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble30PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble30PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableDouble30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble40PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableDouble40PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Double40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble40PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble40PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableDouble40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble50PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableDouble50PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Double50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble50PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble50PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableDouble50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble60PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableDouble60PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Double60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble60PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble60PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableDouble60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble70PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableDouble70PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Double70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble70PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble70PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableDouble70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble80PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableDouble80PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Double80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble80PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble80PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableDouble80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble90PercentNaNMin()
        {
            Console.WriteLine("TestNewEnumerableDouble90PercentNaNMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.Double90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble90PercentNaNOrNullMin()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble90PercentNaNOrNullMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Min(SourceEnumerables.NullableDouble90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestNewEnumerableDoubleIncrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDoubleIncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleIncrementedMax()
        {
            Console.WriteLine("TestNewEnumerableDoubleIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleDecrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDoubleDecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleDecrementedMax()
        {
            Console.WriteLine("TestNewEnumerableDoubleDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleUpAndDownNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDoubleUpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleUpAndDownMax()
        {
            Console.WriteLine("TestNewEnumerableDoubleUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleShuffledNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDoubleShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleShuffledMax()
        {
            Console.WriteLine("TestNewEnumerableDoubleShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleSolitaireNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDoubleSolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleSolitaireMax()
        {
            Console.WriteLine("TestNewEnumerableDoubleSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleEmptyNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDoubleEmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.EmptyNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleEmptyMax()
        {
            Console.WriteLine("TestNewEnumerableDoubleEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Max(SourceEnumerables.EmptyDouble);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableDouble10PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDouble10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble20PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDouble20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble30PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDouble30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble40PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDouble40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble50PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDouble50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble60PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDouble60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble70PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDouble70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble80PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDouble80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble90PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDouble90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestNewEnumerableDouble10PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableDouble10PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Double10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble10PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble10PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableDouble10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble20PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableDouble20PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Double20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble20PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble20PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableDouble20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble30PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableDouble30PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Double30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble30PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble30PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableDouble30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble40PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableDouble40PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Double40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble40PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble40PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableDouble40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble50PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableDouble50PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Double50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble50PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble50PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableDouble50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble60PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableDouble60PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Double60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble60PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble60PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableDouble60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble70PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableDouble70PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Double70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble70PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble70PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableDouble70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble80PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableDouble80PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Double80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble80PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble80PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableDouble80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble90PercentNaNMax()
        {
            Console.WriteLine("TestNewEnumerableDouble90PercentNaNMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.Double90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble90PercentNaNOrNullMax()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble90PercentNaNOrNullMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Max(SourceEnumerables.NullableDouble90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestNewEnumerableDecimalIncrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDecimalIncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalIncrementedMin()
        {
            Console.WriteLine("TestNewEnumerableDecimalIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalDecrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDecimalDecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalDecrementedMin()
        {
            Console.WriteLine("TestNewEnumerableDecimalDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalUpAndDownNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDecimalUpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalUpAndDownMin()
        {
            Console.WriteLine("TestNewEnumerableDecimalUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalShuffledNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDecimalShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalShuffledMin()
        {
            Console.WriteLine("TestNewEnumerableDecimalShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalSolitaireNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDecimalSolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalSolitaireMin()
        {
            Console.WriteLine("TestNewEnumerableDecimalSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalEmptyNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDecimalEmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.EmptyNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalEmptyMin()
        {
            Console.WriteLine("TestNewEnumerableDecimalEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Min(SourceEnumerables.EmptyDecimal);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableDecimal10PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDecimal10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal20PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDecimal20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal30PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDecimal30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal40PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDecimal40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal50PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDecimal50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal60PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDecimal60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal70PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDecimal70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal80PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDecimal80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal90PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDecimal90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableDecimalIncrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDecimalIncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalIncrementedMax()
        {
            Console.WriteLine("TestNewEnumerableDecimalIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalDecrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDecimalDecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalDecrementedMax()
        {
            Console.WriteLine("TestNewEnumerableDecimalDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalUpAndDownNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDecimalUpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalUpAndDownMax()
        {
            Console.WriteLine("TestNewEnumerableDecimalUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalShuffledNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDecimalShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalShuffledMax()
        {
            Console.WriteLine("TestNewEnumerableDecimalShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalSolitaireNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDecimalSolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalSolitaireMax()
        {
            Console.WriteLine("TestNewEnumerableDecimalSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalEmptyNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDecimalEmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.EmptyNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalEmptyMax()
        {
            Console.WriteLine("TestNewEnumerableDecimalEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Max(SourceEnumerables.EmptyDecimal);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableDecimal10PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDecimal10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal20PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDecimal20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal30PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDecimal30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal40PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDecimal40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal50PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDecimal50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal60PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDecimal60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal70PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDecimal70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal80PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDecimal80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal90PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDecimal90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }        private static void TestNewEnumerableStringIncrementedMin()
        {
            Console.WriteLine("TestNewEnumerableStringIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableStringDecrementedMin()
        {
            Console.WriteLine("TestNewEnumerableStringDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableStringUpAndDownMin()
        {
            Console.WriteLine("TestNewEnumerableStringUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableStringShuffledMin()
        {
            Console.WriteLine("TestNewEnumerableStringShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableStringSolitaireMin()
        {
            Console.WriteLine("TestNewEnumerableStringSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableStringEmptyMin()
        {
            Console.WriteLine("TestNewEnumerableStringEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Min(SourceEnumerables.EmptyString);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableString10PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableString10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.String10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString20PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableString20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.String20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString30PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableString30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.String30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString40PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableString40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.String40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString50PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableString50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.String50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString60PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableString60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.String60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString70PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableString70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.String70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString80PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableString80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.String80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString90PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableString90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.String90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }        private static void TestNewEnumerableStringIncrementedMax()
        {
            Console.WriteLine("TestNewEnumerableStringIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableStringDecrementedMax()
        {
            Console.WriteLine("TestNewEnumerableStringDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableStringUpAndDownMax()
        {
            Console.WriteLine("TestNewEnumerableStringUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableStringShuffledMax()
        {
            Console.WriteLine("TestNewEnumerableStringShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableStringSolitaireMax()
        {
            Console.WriteLine("TestNewEnumerableStringSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireString);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableStringEmptyMax()
        {
            Console.WriteLine("TestNewEnumerableStringEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Max(SourceEnumerables.EmptyString);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableString10PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableString10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.String10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString20PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableString20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.String20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString30PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableString30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.String30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString40PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableString40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.String40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString50PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableString50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.String50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString60PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableString60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.String60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString70PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableString70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.String70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString80PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableString80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.String80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableString90PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableString90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.String90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableDateTimeIncrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeIncrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeIncrementedMin()
        {
            Console.WriteLine("TestNewEnumerableDateTimeIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDateTimeDecrementedNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeDecrementedNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeDecrementedMin()
        {
            Console.WriteLine("TestNewEnumerableDateTimeDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDateTimeUpAndDownNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeUpAndDownNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeUpAndDownMin()
        {
            Console.WriteLine("TestNewEnumerableDateTimeUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDateTimeShuffledNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeShuffledNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeShuffledMin()
        {
            Console.WriteLine("TestNewEnumerableDateTimeShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDateTimeSolitaireNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeSolitaireNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeSolitaireMin()
        {
            Console.WriteLine("TestNewEnumerableDateTimeSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDateTimeEmptyNullableMin()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeEmptyNullableMin");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.EmptyNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeEmptyMin()
        {
            Console.WriteLine("TestNewEnumerableDateTimeEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Min(SourceEnumerables.EmptyDateTime);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableDateTime10PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDateTime10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime20PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDateTime20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime30PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDateTime30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime40PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDateTime40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime50PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDateTime50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime60PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDateTime60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime70PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDateTime70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime80PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDateTime80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime90PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.NullableDateTime90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableDateTimeIncrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeIncrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeIncrementedMax()
        {
            Console.WriteLine("TestNewEnumerableDateTimeIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDateTimeDecrementedNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeDecrementedNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeDecrementedMax()
        {
            Console.WriteLine("TestNewEnumerableDateTimeDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDateTimeUpAndDownNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeUpAndDownNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeUpAndDownMax()
        {
            Console.WriteLine("TestNewEnumerableDateTimeUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDateTimeShuffledNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeShuffledNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeShuffledMax()
        {
            Console.WriteLine("TestNewEnumerableDateTimeShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDateTimeSolitaireNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeSolitaireNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeSolitaireMax()
        {
            Console.WriteLine("TestNewEnumerableDateTimeSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireDateTime);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDateTimeEmptyNullableMax()
                {
                    Console.WriteLine("TestNewEnumerableDateTimeEmptyNullableMax");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.EmptyNullableDateTime);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDateTimeEmptyMax()
        {
            Console.WriteLine("TestNewEnumerableDateTimeEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Max(SourceEnumerables.EmptyDateTime);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableDateTime10PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDateTime10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime20PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDateTime20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime30PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDateTime30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime40PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDateTime40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime50PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDateTime50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime60PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDateTime60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime70PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDateTime70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime80PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDateTime80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDateTime90PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableNullableDateTime90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.NullableDateTime90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }        private static void TestNewEnumerableExampleReferenceTypeIncrementedMin()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeIncrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.IncrementedExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableExampleReferenceTypeDecrementedMin()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeDecrementedMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.DecrementedExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableExampleReferenceTypeUpAndDownMin()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeUpAndDownMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.UpAndDownExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableExampleReferenceTypeShuffledMin()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeShuffledMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.ShuffledExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableExampleReferenceTypeSolitaireMin()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeSolitaireMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Min(SourceEnumerables.SolitaireExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableExampleReferenceTypeEmptyMin()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeEmptyMin");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Min(SourceEnumerables.EmptyExampleReferenceType);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableExampleReferenceType10PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType10PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.ExampleReferenceType10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType20PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType20PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.ExampleReferenceType20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType30PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType30PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.ExampleReferenceType30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType40PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType40PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.ExampleReferenceType40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType50PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType50PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.ExampleReferenceType50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType60PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType60PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.ExampleReferenceType60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType70PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType70PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.ExampleReferenceType70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType80PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType80PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.ExampleReferenceType80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType90PercentNulledMin()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType90PercentNulledMin");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Min(SourceEnumerables.ExampleReferenceType90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }        private static void TestNewEnumerableExampleReferenceTypeIncrementedMax()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeIncrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.IncrementedExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableExampleReferenceTypeDecrementedMax()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeDecrementedMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.DecrementedExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableExampleReferenceTypeUpAndDownMax()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeUpAndDownMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.UpAndDownExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableExampleReferenceTypeShuffledMax()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeShuffledMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.ShuffledExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableExampleReferenceTypeSolitaireMax()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeSolitaireMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Max(SourceEnumerables.SolitaireExampleReferenceType);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableExampleReferenceTypeEmptyMax()
        {
            Console.WriteLine("TestNewEnumerableExampleReferenceTypeEmptyMax");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Max(SourceEnumerables.EmptyExampleReferenceType);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableExampleReferenceType10PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType10PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.ExampleReferenceType10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType20PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType20PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.ExampleReferenceType20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType30PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType30PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.ExampleReferenceType30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType40PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType40PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.ExampleReferenceType40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType50PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType50PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.ExampleReferenceType50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType60PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType60PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.ExampleReferenceType60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType70PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType70PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.ExampleReferenceType70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType80PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType80PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.ExampleReferenceType80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableExampleReferenceType90PercentNulledMax()
            {
                Console.WriteLine("TestNewEnumerableExampleReferenceType90PercentNulledMax");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Max(SourceEnumerables.ExampleReferenceType90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }      public static void DoTests()
        {
            TestOldEnumerableInt32IncrementedNullableMin();
            TestOldEnumerableInt32IncrementedMin();
            TestOldEnumerableInt32DecrementedNullableMin();
            TestOldEnumerableInt32DecrementedMin();
            TestOldEnumerableInt32UpAndDownNullableMin();
            TestOldEnumerableInt32UpAndDownMin();
            TestOldEnumerableInt32ShuffledNullableMin();
            TestOldEnumerableInt32ShuffledMin();
            TestOldEnumerableInt32SolitaireNullableMin();
            TestOldEnumerableInt32SolitaireMin();
            TestOldEnumerableInt32EmptyNullableMin();
            TestOldEnumerableInt32EmptyMin();
            TestOldEnumerableNullableInt3210PercentNulledMin();
            TestOldEnumerableNullableInt3220PercentNulledMin();
            TestOldEnumerableNullableInt3230PercentNulledMin();
            TestOldEnumerableNullableInt3240PercentNulledMin();
            TestOldEnumerableNullableInt3250PercentNulledMin();
            TestOldEnumerableNullableInt3260PercentNulledMin();
            TestOldEnumerableNullableInt3270PercentNulledMin();
            TestOldEnumerableNullableInt3280PercentNulledMin();
            TestOldEnumerableNullableInt3290PercentNulledMin();
            TestOldEnumerableInt32IncrementedNullableMax();
            TestOldEnumerableInt32IncrementedMax();
            TestOldEnumerableInt32DecrementedNullableMax();
            TestOldEnumerableInt32DecrementedMax();
            TestOldEnumerableInt32UpAndDownNullableMax();
            TestOldEnumerableInt32UpAndDownMax();
            TestOldEnumerableInt32ShuffledNullableMax();
            TestOldEnumerableInt32ShuffledMax();
            TestOldEnumerableInt32SolitaireNullableMax();
            TestOldEnumerableInt32SolitaireMax();
            TestOldEnumerableInt32EmptyNullableMax();
            TestOldEnumerableInt32EmptyMax();
            TestOldEnumerableNullableInt3210PercentNulledMax();
            TestOldEnumerableNullableInt3220PercentNulledMax();
            TestOldEnumerableNullableInt3230PercentNulledMax();
            TestOldEnumerableNullableInt3240PercentNulledMax();
            TestOldEnumerableNullableInt3250PercentNulledMax();
            TestOldEnumerableNullableInt3260PercentNulledMax();
            TestOldEnumerableNullableInt3270PercentNulledMax();
            TestOldEnumerableNullableInt3280PercentNulledMax();
            TestOldEnumerableNullableInt3290PercentNulledMax();
            TestOldEnumerableInt64IncrementedNullableMin();
            TestOldEnumerableInt64IncrementedMin();
            TestOldEnumerableInt64DecrementedNullableMin();
            TestOldEnumerableInt64DecrementedMin();
            TestOldEnumerableInt64UpAndDownNullableMin();
            TestOldEnumerableInt64UpAndDownMin();
            TestOldEnumerableInt64ShuffledNullableMin();
            TestOldEnumerableInt64ShuffledMin();
            TestOldEnumerableInt64SolitaireNullableMin();
            TestOldEnumerableInt64SolitaireMin();
            TestOldEnumerableInt64EmptyNullableMin();
            TestOldEnumerableInt64EmptyMin();
            TestOldEnumerableNullableInt6410PercentNulledMin();
            TestOldEnumerableNullableInt6420PercentNulledMin();
            TestOldEnumerableNullableInt6430PercentNulledMin();
            TestOldEnumerableNullableInt6440PercentNulledMin();
            TestOldEnumerableNullableInt6450PercentNulledMin();
            TestOldEnumerableNullableInt6460PercentNulledMin();
            TestOldEnumerableNullableInt6470PercentNulledMin();
            TestOldEnumerableNullableInt6480PercentNulledMin();
            TestOldEnumerableNullableInt6490PercentNulledMin();
            TestOldEnumerableInt64IncrementedNullableMax();
            TestOldEnumerableInt64IncrementedMax();
            TestOldEnumerableInt64DecrementedNullableMax();
            TestOldEnumerableInt64DecrementedMax();
            TestOldEnumerableInt64UpAndDownNullableMax();
            TestOldEnumerableInt64UpAndDownMax();
            TestOldEnumerableInt64ShuffledNullableMax();
            TestOldEnumerableInt64ShuffledMax();
            TestOldEnumerableInt64SolitaireNullableMax();
            TestOldEnumerableInt64SolitaireMax();
            TestOldEnumerableInt64EmptyNullableMax();
            TestOldEnumerableInt64EmptyMax();
            TestOldEnumerableNullableInt6410PercentNulledMax();
            TestOldEnumerableNullableInt6420PercentNulledMax();
            TestOldEnumerableNullableInt6430PercentNulledMax();
            TestOldEnumerableNullableInt6440PercentNulledMax();
            TestOldEnumerableNullableInt6450PercentNulledMax();
            TestOldEnumerableNullableInt6460PercentNulledMax();
            TestOldEnumerableNullableInt6470PercentNulledMax();
            TestOldEnumerableNullableInt6480PercentNulledMax();
            TestOldEnumerableNullableInt6490PercentNulledMax();
            TestOldEnumerableSingleIncrementedNullableMin();
            TestOldEnumerableSingleIncrementedMin();
            TestOldEnumerableSingleDecrementedNullableMin();
            TestOldEnumerableSingleDecrementedMin();
            TestOldEnumerableSingleUpAndDownNullableMin();
            TestOldEnumerableSingleUpAndDownMin();
            TestOldEnumerableSingleShuffledNullableMin();
            TestOldEnumerableSingleShuffledMin();
            TestOldEnumerableSingleSolitaireNullableMin();
            TestOldEnumerableSingleSolitaireMin();
            TestOldEnumerableSingleEmptyNullableMin();
            TestOldEnumerableSingleEmptyMin();
            TestOldEnumerableNullableSingle10PercentNulledMin();
            TestOldEnumerableNullableSingle20PercentNulledMin();
            TestOldEnumerableNullableSingle30PercentNulledMin();
            TestOldEnumerableNullableSingle40PercentNulledMin();
            TestOldEnumerableNullableSingle50PercentNulledMin();
            TestOldEnumerableNullableSingle60PercentNulledMin();
            TestOldEnumerableNullableSingle70PercentNulledMin();
            TestOldEnumerableNullableSingle80PercentNulledMin();
            TestOldEnumerableNullableSingle90PercentNulledMin();
            TestOldEnumerableSingle10PercentNaNMin();
            TestOldEnumerableNullableSingle10PercentNaNOrNullMin();
            TestOldEnumerableSingle20PercentNaNMin();
            TestOldEnumerableNullableSingle20PercentNaNOrNullMin();
            TestOldEnumerableSingle30PercentNaNMin();
            TestOldEnumerableNullableSingle30PercentNaNOrNullMin();
            TestOldEnumerableSingle40PercentNaNMin();
            TestOldEnumerableNullableSingle40PercentNaNOrNullMin();
            TestOldEnumerableSingle50PercentNaNMin();
            TestOldEnumerableNullableSingle50PercentNaNOrNullMin();
            TestOldEnumerableSingle60PercentNaNMin();
            TestOldEnumerableNullableSingle60PercentNaNOrNullMin();
            TestOldEnumerableSingle70PercentNaNMin();
            TestOldEnumerableNullableSingle70PercentNaNOrNullMin();
            TestOldEnumerableSingle80PercentNaNMin();
            TestOldEnumerableNullableSingle80PercentNaNOrNullMin();
            TestOldEnumerableSingle90PercentNaNMin();
            TestOldEnumerableNullableSingle90PercentNaNOrNullMin();
            TestOldEnumerableSingleIncrementedNullableMax();
            TestOldEnumerableSingleIncrementedMax();
            TestOldEnumerableSingleDecrementedNullableMax();
            TestOldEnumerableSingleDecrementedMax();
            TestOldEnumerableSingleUpAndDownNullableMax();
            TestOldEnumerableSingleUpAndDownMax();
            TestOldEnumerableSingleShuffledNullableMax();
            TestOldEnumerableSingleShuffledMax();
            TestOldEnumerableSingleSolitaireNullableMax();
            TestOldEnumerableSingleSolitaireMax();
            TestOldEnumerableSingleEmptyNullableMax();
            TestOldEnumerableSingleEmptyMax();
            TestOldEnumerableNullableSingle10PercentNulledMax();
            TestOldEnumerableNullableSingle20PercentNulledMax();
            TestOldEnumerableNullableSingle30PercentNulledMax();
            TestOldEnumerableNullableSingle40PercentNulledMax();
            TestOldEnumerableNullableSingle50PercentNulledMax();
            TestOldEnumerableNullableSingle60PercentNulledMax();
            TestOldEnumerableNullableSingle70PercentNulledMax();
            TestOldEnumerableNullableSingle80PercentNulledMax();
            TestOldEnumerableNullableSingle90PercentNulledMax();
            TestOldEnumerableSingle10PercentNaNMax();
            TestOldEnumerableNullableSingle10PercentNaNOrNullMax();
            TestOldEnumerableSingle20PercentNaNMax();
            TestOldEnumerableNullableSingle20PercentNaNOrNullMax();
            TestOldEnumerableSingle30PercentNaNMax();
            TestOldEnumerableNullableSingle30PercentNaNOrNullMax();
            TestOldEnumerableSingle40PercentNaNMax();
            TestOldEnumerableNullableSingle40PercentNaNOrNullMax();
            TestOldEnumerableSingle50PercentNaNMax();
            TestOldEnumerableNullableSingle50PercentNaNOrNullMax();
            TestOldEnumerableSingle60PercentNaNMax();
            TestOldEnumerableNullableSingle60PercentNaNOrNullMax();
            TestOldEnumerableSingle70PercentNaNMax();
            TestOldEnumerableNullableSingle70PercentNaNOrNullMax();
            TestOldEnumerableSingle80PercentNaNMax();
            TestOldEnumerableNullableSingle80PercentNaNOrNullMax();
            TestOldEnumerableSingle90PercentNaNMax();
            TestOldEnumerableNullableSingle90PercentNaNOrNullMax();
            TestOldEnumerableDoubleIncrementedNullableMin();
            TestOldEnumerableDoubleIncrementedMin();
            TestOldEnumerableDoubleDecrementedNullableMin();
            TestOldEnumerableDoubleDecrementedMin();
            TestOldEnumerableDoubleUpAndDownNullableMin();
            TestOldEnumerableDoubleUpAndDownMin();
            TestOldEnumerableDoubleShuffledNullableMin();
            TestOldEnumerableDoubleShuffledMin();
            TestOldEnumerableDoubleSolitaireNullableMin();
            TestOldEnumerableDoubleSolitaireMin();
            TestOldEnumerableDoubleEmptyNullableMin();
            TestOldEnumerableDoubleEmptyMin();
            TestOldEnumerableNullableDouble10PercentNulledMin();
            TestOldEnumerableNullableDouble20PercentNulledMin();
            TestOldEnumerableNullableDouble30PercentNulledMin();
            TestOldEnumerableNullableDouble40PercentNulledMin();
            TestOldEnumerableNullableDouble50PercentNulledMin();
            TestOldEnumerableNullableDouble60PercentNulledMin();
            TestOldEnumerableNullableDouble70PercentNulledMin();
            TestOldEnumerableNullableDouble80PercentNulledMin();
            TestOldEnumerableNullableDouble90PercentNulledMin();
            TestOldEnumerableDouble10PercentNaNMin();
            TestOldEnumerableNullableDouble10PercentNaNOrNullMin();
            TestOldEnumerableDouble20PercentNaNMin();
            TestOldEnumerableNullableDouble20PercentNaNOrNullMin();
            TestOldEnumerableDouble30PercentNaNMin();
            TestOldEnumerableNullableDouble30PercentNaNOrNullMin();
            TestOldEnumerableDouble40PercentNaNMin();
            TestOldEnumerableNullableDouble40PercentNaNOrNullMin();
            TestOldEnumerableDouble50PercentNaNMin();
            TestOldEnumerableNullableDouble50PercentNaNOrNullMin();
            TestOldEnumerableDouble60PercentNaNMin();
            TestOldEnumerableNullableDouble60PercentNaNOrNullMin();
            TestOldEnumerableDouble70PercentNaNMin();
            TestOldEnumerableNullableDouble70PercentNaNOrNullMin();
            TestOldEnumerableDouble80PercentNaNMin();
            TestOldEnumerableNullableDouble80PercentNaNOrNullMin();
            TestOldEnumerableDouble90PercentNaNMin();
            TestOldEnumerableNullableDouble90PercentNaNOrNullMin();
            TestOldEnumerableDoubleIncrementedNullableMax();
            TestOldEnumerableDoubleIncrementedMax();
            TestOldEnumerableDoubleDecrementedNullableMax();
            TestOldEnumerableDoubleDecrementedMax();
            TestOldEnumerableDoubleUpAndDownNullableMax();
            TestOldEnumerableDoubleUpAndDownMax();
            TestOldEnumerableDoubleShuffledNullableMax();
            TestOldEnumerableDoubleShuffledMax();
            TestOldEnumerableDoubleSolitaireNullableMax();
            TestOldEnumerableDoubleSolitaireMax();
            TestOldEnumerableDoubleEmptyNullableMax();
            TestOldEnumerableDoubleEmptyMax();
            TestOldEnumerableNullableDouble10PercentNulledMax();
            TestOldEnumerableNullableDouble20PercentNulledMax();
            TestOldEnumerableNullableDouble30PercentNulledMax();
            TestOldEnumerableNullableDouble40PercentNulledMax();
            TestOldEnumerableNullableDouble50PercentNulledMax();
            TestOldEnumerableNullableDouble60PercentNulledMax();
            TestOldEnumerableNullableDouble70PercentNulledMax();
            TestOldEnumerableNullableDouble80PercentNulledMax();
            TestOldEnumerableNullableDouble90PercentNulledMax();
            TestOldEnumerableDouble10PercentNaNMax();
            TestOldEnumerableNullableDouble10PercentNaNOrNullMax();
            TestOldEnumerableDouble20PercentNaNMax();
            TestOldEnumerableNullableDouble20PercentNaNOrNullMax();
            TestOldEnumerableDouble30PercentNaNMax();
            TestOldEnumerableNullableDouble30PercentNaNOrNullMax();
            TestOldEnumerableDouble40PercentNaNMax();
            TestOldEnumerableNullableDouble40PercentNaNOrNullMax();
            TestOldEnumerableDouble50PercentNaNMax();
            TestOldEnumerableNullableDouble50PercentNaNOrNullMax();
            TestOldEnumerableDouble60PercentNaNMax();
            TestOldEnumerableNullableDouble60PercentNaNOrNullMax();
            TestOldEnumerableDouble70PercentNaNMax();
            TestOldEnumerableNullableDouble70PercentNaNOrNullMax();
            TestOldEnumerableDouble80PercentNaNMax();
            TestOldEnumerableNullableDouble80PercentNaNOrNullMax();
            TestOldEnumerableDouble90PercentNaNMax();
            TestOldEnumerableNullableDouble90PercentNaNOrNullMax();
            TestOldEnumerableDecimalIncrementedNullableMin();
            TestOldEnumerableDecimalIncrementedMin();
            TestOldEnumerableDecimalDecrementedNullableMin();
            TestOldEnumerableDecimalDecrementedMin();
            TestOldEnumerableDecimalUpAndDownNullableMin();
            TestOldEnumerableDecimalUpAndDownMin();
            TestOldEnumerableDecimalShuffledNullableMin();
            TestOldEnumerableDecimalShuffledMin();
            TestOldEnumerableDecimalSolitaireNullableMin();
            TestOldEnumerableDecimalSolitaireMin();
            TestOldEnumerableDecimalEmptyNullableMin();
            TestOldEnumerableDecimalEmptyMin();
            TestOldEnumerableNullableDecimal10PercentNulledMin();
            TestOldEnumerableNullableDecimal20PercentNulledMin();
            TestOldEnumerableNullableDecimal30PercentNulledMin();
            TestOldEnumerableNullableDecimal40PercentNulledMin();
            TestOldEnumerableNullableDecimal50PercentNulledMin();
            TestOldEnumerableNullableDecimal60PercentNulledMin();
            TestOldEnumerableNullableDecimal70PercentNulledMin();
            TestOldEnumerableNullableDecimal80PercentNulledMin();
            TestOldEnumerableNullableDecimal90PercentNulledMin();
            TestOldEnumerableDecimalIncrementedNullableMax();
            TestOldEnumerableDecimalIncrementedMax();
            TestOldEnumerableDecimalDecrementedNullableMax();
            TestOldEnumerableDecimalDecrementedMax();
            TestOldEnumerableDecimalUpAndDownNullableMax();
            TestOldEnumerableDecimalUpAndDownMax();
            TestOldEnumerableDecimalShuffledNullableMax();
            TestOldEnumerableDecimalShuffledMax();
            TestOldEnumerableDecimalSolitaireNullableMax();
            TestOldEnumerableDecimalSolitaireMax();
            TestOldEnumerableDecimalEmptyNullableMax();
            TestOldEnumerableDecimalEmptyMax();
            TestOldEnumerableNullableDecimal10PercentNulledMax();
            TestOldEnumerableNullableDecimal20PercentNulledMax();
            TestOldEnumerableNullableDecimal30PercentNulledMax();
            TestOldEnumerableNullableDecimal40PercentNulledMax();
            TestOldEnumerableNullableDecimal50PercentNulledMax();
            TestOldEnumerableNullableDecimal60PercentNulledMax();
            TestOldEnumerableNullableDecimal70PercentNulledMax();
            TestOldEnumerableNullableDecimal80PercentNulledMax();
            TestOldEnumerableNullableDecimal90PercentNulledMax();
            TestOldEnumerableStringIncrementedMin();
            TestOldEnumerableStringDecrementedMin();
            TestOldEnumerableStringUpAndDownMin();
            TestOldEnumerableStringShuffledMin();
            TestOldEnumerableStringSolitaireMin();
            TestOldEnumerableStringEmptyMin();
            TestOldEnumerableString10PercentNulledMin();
            TestOldEnumerableString20PercentNulledMin();
            TestOldEnumerableString30PercentNulledMin();
            TestOldEnumerableString40PercentNulledMin();
            TestOldEnumerableString50PercentNulledMin();
            TestOldEnumerableString60PercentNulledMin();
            TestOldEnumerableString70PercentNulledMin();
            TestOldEnumerableString80PercentNulledMin();
            TestOldEnumerableString90PercentNulledMin();
            TestOldEnumerableStringIncrementedMax();
            TestOldEnumerableStringDecrementedMax();
            TestOldEnumerableStringUpAndDownMax();
            TestOldEnumerableStringShuffledMax();
            TestOldEnumerableStringSolitaireMax();
            TestOldEnumerableStringEmptyMax();
            TestOldEnumerableString10PercentNulledMax();
            TestOldEnumerableString20PercentNulledMax();
            TestOldEnumerableString30PercentNulledMax();
            TestOldEnumerableString40PercentNulledMax();
            TestOldEnumerableString50PercentNulledMax();
            TestOldEnumerableString60PercentNulledMax();
            TestOldEnumerableString70PercentNulledMax();
            TestOldEnumerableString80PercentNulledMax();
            TestOldEnumerableString90PercentNulledMax();
            TestOldEnumerableDateTimeIncrementedNullableMin();
            TestOldEnumerableDateTimeIncrementedMin();
            TestOldEnumerableDateTimeDecrementedNullableMin();
            TestOldEnumerableDateTimeDecrementedMin();
            TestOldEnumerableDateTimeUpAndDownNullableMin();
            TestOldEnumerableDateTimeUpAndDownMin();
            TestOldEnumerableDateTimeShuffledNullableMin();
            TestOldEnumerableDateTimeShuffledMin();
            TestOldEnumerableDateTimeSolitaireNullableMin();
            TestOldEnumerableDateTimeSolitaireMin();
            TestOldEnumerableDateTimeEmptyNullableMin();
            TestOldEnumerableDateTimeEmptyMin();
            TestOldEnumerableNullableDateTime10PercentNulledMin();
            TestOldEnumerableNullableDateTime20PercentNulledMin();
            TestOldEnumerableNullableDateTime30PercentNulledMin();
            TestOldEnumerableNullableDateTime40PercentNulledMin();
            TestOldEnumerableNullableDateTime50PercentNulledMin();
            TestOldEnumerableNullableDateTime60PercentNulledMin();
            TestOldEnumerableNullableDateTime70PercentNulledMin();
            TestOldEnumerableNullableDateTime80PercentNulledMin();
            TestOldEnumerableNullableDateTime90PercentNulledMin();
            TestOldEnumerableDateTimeIncrementedNullableMax();
            TestOldEnumerableDateTimeIncrementedMax();
            TestOldEnumerableDateTimeDecrementedNullableMax();
            TestOldEnumerableDateTimeDecrementedMax();
            TestOldEnumerableDateTimeUpAndDownNullableMax();
            TestOldEnumerableDateTimeUpAndDownMax();
            TestOldEnumerableDateTimeShuffledNullableMax();
            TestOldEnumerableDateTimeShuffledMax();
            TestOldEnumerableDateTimeSolitaireNullableMax();
            TestOldEnumerableDateTimeSolitaireMax();
            TestOldEnumerableDateTimeEmptyNullableMax();
            TestOldEnumerableDateTimeEmptyMax();
            TestOldEnumerableNullableDateTime10PercentNulledMax();
            TestOldEnumerableNullableDateTime20PercentNulledMax();
            TestOldEnumerableNullableDateTime30PercentNulledMax();
            TestOldEnumerableNullableDateTime40PercentNulledMax();
            TestOldEnumerableNullableDateTime50PercentNulledMax();
            TestOldEnumerableNullableDateTime60PercentNulledMax();
            TestOldEnumerableNullableDateTime70PercentNulledMax();
            TestOldEnumerableNullableDateTime80PercentNulledMax();
            TestOldEnumerableNullableDateTime90PercentNulledMax();
            TestOldEnumerableExampleReferenceTypeIncrementedMin();
            TestOldEnumerableExampleReferenceTypeDecrementedMin();
            TestOldEnumerableExampleReferenceTypeUpAndDownMin();
            TestOldEnumerableExampleReferenceTypeShuffledMin();
            TestOldEnumerableExampleReferenceTypeSolitaireMin();
            TestOldEnumerableExampleReferenceTypeEmptyMin();
            TestOldEnumerableExampleReferenceType10PercentNulledMin();
            TestOldEnumerableExampleReferenceType20PercentNulledMin();
            TestOldEnumerableExampleReferenceType30PercentNulledMin();
            TestOldEnumerableExampleReferenceType40PercentNulledMin();
            TestOldEnumerableExampleReferenceType50PercentNulledMin();
            TestOldEnumerableExampleReferenceType60PercentNulledMin();
            TestOldEnumerableExampleReferenceType70PercentNulledMin();
            TestOldEnumerableExampleReferenceType80PercentNulledMin();
            TestOldEnumerableExampleReferenceType90PercentNulledMin();
            TestOldEnumerableExampleReferenceTypeIncrementedMax();
            TestOldEnumerableExampleReferenceTypeDecrementedMax();
            TestOldEnumerableExampleReferenceTypeUpAndDownMax();
            TestOldEnumerableExampleReferenceTypeShuffledMax();
            TestOldEnumerableExampleReferenceTypeSolitaireMax();
            TestOldEnumerableExampleReferenceTypeEmptyMax();
            TestOldEnumerableExampleReferenceType10PercentNulledMax();
            TestOldEnumerableExampleReferenceType20PercentNulledMax();
            TestOldEnumerableExampleReferenceType30PercentNulledMax();
            TestOldEnumerableExampleReferenceType40PercentNulledMax();
            TestOldEnumerableExampleReferenceType50PercentNulledMax();
            TestOldEnumerableExampleReferenceType60PercentNulledMax();
            TestOldEnumerableExampleReferenceType70PercentNulledMax();
            TestOldEnumerableExampleReferenceType80PercentNulledMax();
            TestOldEnumerableExampleReferenceType90PercentNulledMax();
            TestNewEnumerableInt32IncrementedNullableMin();
            TestNewEnumerableInt32IncrementedMin();
            TestNewEnumerableInt32DecrementedNullableMin();
            TestNewEnumerableInt32DecrementedMin();
            TestNewEnumerableInt32UpAndDownNullableMin();
            TestNewEnumerableInt32UpAndDownMin();
            TestNewEnumerableInt32ShuffledNullableMin();
            TestNewEnumerableInt32ShuffledMin();
            TestNewEnumerableInt32SolitaireNullableMin();
            TestNewEnumerableInt32SolitaireMin();
            TestNewEnumerableInt32EmptyNullableMin();
            TestNewEnumerableInt32EmptyMin();
            TestNewEnumerableNullableInt3210PercentNulledMin();
            TestNewEnumerableNullableInt3220PercentNulledMin();
            TestNewEnumerableNullableInt3230PercentNulledMin();
            TestNewEnumerableNullableInt3240PercentNulledMin();
            TestNewEnumerableNullableInt3250PercentNulledMin();
            TestNewEnumerableNullableInt3260PercentNulledMin();
            TestNewEnumerableNullableInt3270PercentNulledMin();
            TestNewEnumerableNullableInt3280PercentNulledMin();
            TestNewEnumerableNullableInt3290PercentNulledMin();
            TestNewEnumerableInt32IncrementedNullableMax();
            TestNewEnumerableInt32IncrementedMax();
            TestNewEnumerableInt32DecrementedNullableMax();
            TestNewEnumerableInt32DecrementedMax();
            TestNewEnumerableInt32UpAndDownNullableMax();
            TestNewEnumerableInt32UpAndDownMax();
            TestNewEnumerableInt32ShuffledNullableMax();
            TestNewEnumerableInt32ShuffledMax();
            TestNewEnumerableInt32SolitaireNullableMax();
            TestNewEnumerableInt32SolitaireMax();
            TestNewEnumerableInt32EmptyNullableMax();
            TestNewEnumerableInt32EmptyMax();
            TestNewEnumerableNullableInt3210PercentNulledMax();
            TestNewEnumerableNullableInt3220PercentNulledMax();
            TestNewEnumerableNullableInt3230PercentNulledMax();
            TestNewEnumerableNullableInt3240PercentNulledMax();
            TestNewEnumerableNullableInt3250PercentNulledMax();
            TestNewEnumerableNullableInt3260PercentNulledMax();
            TestNewEnumerableNullableInt3270PercentNulledMax();
            TestNewEnumerableNullableInt3280PercentNulledMax();
            TestNewEnumerableNullableInt3290PercentNulledMax();
            TestNewEnumerableInt64IncrementedNullableMin();
            TestNewEnumerableInt64IncrementedMin();
            TestNewEnumerableInt64DecrementedNullableMin();
            TestNewEnumerableInt64DecrementedMin();
            TestNewEnumerableInt64UpAndDownNullableMin();
            TestNewEnumerableInt64UpAndDownMin();
            TestNewEnumerableInt64ShuffledNullableMin();
            TestNewEnumerableInt64ShuffledMin();
            TestNewEnumerableInt64SolitaireNullableMin();
            TestNewEnumerableInt64SolitaireMin();
            TestNewEnumerableInt64EmptyNullableMin();
            TestNewEnumerableInt64EmptyMin();
            TestNewEnumerableNullableInt6410PercentNulledMin();
            TestNewEnumerableNullableInt6420PercentNulledMin();
            TestNewEnumerableNullableInt6430PercentNulledMin();
            TestNewEnumerableNullableInt6440PercentNulledMin();
            TestNewEnumerableNullableInt6450PercentNulledMin();
            TestNewEnumerableNullableInt6460PercentNulledMin();
            TestNewEnumerableNullableInt6470PercentNulledMin();
            TestNewEnumerableNullableInt6480PercentNulledMin();
            TestNewEnumerableNullableInt6490PercentNulledMin();
            TestNewEnumerableInt64IncrementedNullableMax();
            TestNewEnumerableInt64IncrementedMax();
            TestNewEnumerableInt64DecrementedNullableMax();
            TestNewEnumerableInt64DecrementedMax();
            TestNewEnumerableInt64UpAndDownNullableMax();
            TestNewEnumerableInt64UpAndDownMax();
            TestNewEnumerableInt64ShuffledNullableMax();
            TestNewEnumerableInt64ShuffledMax();
            TestNewEnumerableInt64SolitaireNullableMax();
            TestNewEnumerableInt64SolitaireMax();
            TestNewEnumerableInt64EmptyNullableMax();
            TestNewEnumerableInt64EmptyMax();
            TestNewEnumerableNullableInt6410PercentNulledMax();
            TestNewEnumerableNullableInt6420PercentNulledMax();
            TestNewEnumerableNullableInt6430PercentNulledMax();
            TestNewEnumerableNullableInt6440PercentNulledMax();
            TestNewEnumerableNullableInt6450PercentNulledMax();
            TestNewEnumerableNullableInt6460PercentNulledMax();
            TestNewEnumerableNullableInt6470PercentNulledMax();
            TestNewEnumerableNullableInt6480PercentNulledMax();
            TestNewEnumerableNullableInt6490PercentNulledMax();
            TestNewEnumerableSingleIncrementedNullableMin();
            TestNewEnumerableSingleIncrementedMin();
            TestNewEnumerableSingleDecrementedNullableMin();
            TestNewEnumerableSingleDecrementedMin();
            TestNewEnumerableSingleUpAndDownNullableMin();
            TestNewEnumerableSingleUpAndDownMin();
            TestNewEnumerableSingleShuffledNullableMin();
            TestNewEnumerableSingleShuffledMin();
            TestNewEnumerableSingleSolitaireNullableMin();
            TestNewEnumerableSingleSolitaireMin();
            TestNewEnumerableSingleEmptyNullableMin();
            TestNewEnumerableSingleEmptyMin();
            TestNewEnumerableNullableSingle10PercentNulledMin();
            TestNewEnumerableNullableSingle20PercentNulledMin();
            TestNewEnumerableNullableSingle30PercentNulledMin();
            TestNewEnumerableNullableSingle40PercentNulledMin();
            TestNewEnumerableNullableSingle50PercentNulledMin();
            TestNewEnumerableNullableSingle60PercentNulledMin();
            TestNewEnumerableNullableSingle70PercentNulledMin();
            TestNewEnumerableNullableSingle80PercentNulledMin();
            TestNewEnumerableNullableSingle90PercentNulledMin();
            TestNewEnumerableSingle10PercentNaNMin();
            TestNewEnumerableNullableSingle10PercentNaNOrNullMin();
            TestNewEnumerableSingle20PercentNaNMin();
            TestNewEnumerableNullableSingle20PercentNaNOrNullMin();
            TestNewEnumerableSingle30PercentNaNMin();
            TestNewEnumerableNullableSingle30PercentNaNOrNullMin();
            TestNewEnumerableSingle40PercentNaNMin();
            TestNewEnumerableNullableSingle40PercentNaNOrNullMin();
            TestNewEnumerableSingle50PercentNaNMin();
            TestNewEnumerableNullableSingle50PercentNaNOrNullMin();
            TestNewEnumerableSingle60PercentNaNMin();
            TestNewEnumerableNullableSingle60PercentNaNOrNullMin();
            TestNewEnumerableSingle70PercentNaNMin();
            TestNewEnumerableNullableSingle70PercentNaNOrNullMin();
            TestNewEnumerableSingle80PercentNaNMin();
            TestNewEnumerableNullableSingle80PercentNaNOrNullMin();
            TestNewEnumerableSingle90PercentNaNMin();
            TestNewEnumerableNullableSingle90PercentNaNOrNullMin();
            TestNewEnumerableSingleIncrementedNullableMax();
            TestNewEnumerableSingleIncrementedMax();
            TestNewEnumerableSingleDecrementedNullableMax();
            TestNewEnumerableSingleDecrementedMax();
            TestNewEnumerableSingleUpAndDownNullableMax();
            TestNewEnumerableSingleUpAndDownMax();
            TestNewEnumerableSingleShuffledNullableMax();
            TestNewEnumerableSingleShuffledMax();
            TestNewEnumerableSingleSolitaireNullableMax();
            TestNewEnumerableSingleSolitaireMax();
            TestNewEnumerableSingleEmptyNullableMax();
            TestNewEnumerableSingleEmptyMax();
            TestNewEnumerableNullableSingle10PercentNulledMax();
            TestNewEnumerableNullableSingle20PercentNulledMax();
            TestNewEnumerableNullableSingle30PercentNulledMax();
            TestNewEnumerableNullableSingle40PercentNulledMax();
            TestNewEnumerableNullableSingle50PercentNulledMax();
            TestNewEnumerableNullableSingle60PercentNulledMax();
            TestNewEnumerableNullableSingle70PercentNulledMax();
            TestNewEnumerableNullableSingle80PercentNulledMax();
            TestNewEnumerableNullableSingle90PercentNulledMax();
            TestNewEnumerableSingle10PercentNaNMax();
            TestNewEnumerableNullableSingle10PercentNaNOrNullMax();
            TestNewEnumerableSingle20PercentNaNMax();
            TestNewEnumerableNullableSingle20PercentNaNOrNullMax();
            TestNewEnumerableSingle30PercentNaNMax();
            TestNewEnumerableNullableSingle30PercentNaNOrNullMax();
            TestNewEnumerableSingle40PercentNaNMax();
            TestNewEnumerableNullableSingle40PercentNaNOrNullMax();
            TestNewEnumerableSingle50PercentNaNMax();
            TestNewEnumerableNullableSingle50PercentNaNOrNullMax();
            TestNewEnumerableSingle60PercentNaNMax();
            TestNewEnumerableNullableSingle60PercentNaNOrNullMax();
            TestNewEnumerableSingle70PercentNaNMax();
            TestNewEnumerableNullableSingle70PercentNaNOrNullMax();
            TestNewEnumerableSingle80PercentNaNMax();
            TestNewEnumerableNullableSingle80PercentNaNOrNullMax();
            TestNewEnumerableSingle90PercentNaNMax();
            TestNewEnumerableNullableSingle90PercentNaNOrNullMax();
            TestNewEnumerableDoubleIncrementedNullableMin();
            TestNewEnumerableDoubleIncrementedMin();
            TestNewEnumerableDoubleDecrementedNullableMin();
            TestNewEnumerableDoubleDecrementedMin();
            TestNewEnumerableDoubleUpAndDownNullableMin();
            TestNewEnumerableDoubleUpAndDownMin();
            TestNewEnumerableDoubleShuffledNullableMin();
            TestNewEnumerableDoubleShuffledMin();
            TestNewEnumerableDoubleSolitaireNullableMin();
            TestNewEnumerableDoubleSolitaireMin();
            TestNewEnumerableDoubleEmptyNullableMin();
            TestNewEnumerableDoubleEmptyMin();
            TestNewEnumerableNullableDouble10PercentNulledMin();
            TestNewEnumerableNullableDouble20PercentNulledMin();
            TestNewEnumerableNullableDouble30PercentNulledMin();
            TestNewEnumerableNullableDouble40PercentNulledMin();
            TestNewEnumerableNullableDouble50PercentNulledMin();
            TestNewEnumerableNullableDouble60PercentNulledMin();
            TestNewEnumerableNullableDouble70PercentNulledMin();
            TestNewEnumerableNullableDouble80PercentNulledMin();
            TestNewEnumerableNullableDouble90PercentNulledMin();
            TestNewEnumerableDouble10PercentNaNMin();
            TestNewEnumerableNullableDouble10PercentNaNOrNullMin();
            TestNewEnumerableDouble20PercentNaNMin();
            TestNewEnumerableNullableDouble20PercentNaNOrNullMin();
            TestNewEnumerableDouble30PercentNaNMin();
            TestNewEnumerableNullableDouble30PercentNaNOrNullMin();
            TestNewEnumerableDouble40PercentNaNMin();
            TestNewEnumerableNullableDouble40PercentNaNOrNullMin();
            TestNewEnumerableDouble50PercentNaNMin();
            TestNewEnumerableNullableDouble50PercentNaNOrNullMin();
            TestNewEnumerableDouble60PercentNaNMin();
            TestNewEnumerableNullableDouble60PercentNaNOrNullMin();
            TestNewEnumerableDouble70PercentNaNMin();
            TestNewEnumerableNullableDouble70PercentNaNOrNullMin();
            TestNewEnumerableDouble80PercentNaNMin();
            TestNewEnumerableNullableDouble80PercentNaNOrNullMin();
            TestNewEnumerableDouble90PercentNaNMin();
            TestNewEnumerableNullableDouble90PercentNaNOrNullMin();
            TestNewEnumerableDoubleIncrementedNullableMax();
            TestNewEnumerableDoubleIncrementedMax();
            TestNewEnumerableDoubleDecrementedNullableMax();
            TestNewEnumerableDoubleDecrementedMax();
            TestNewEnumerableDoubleUpAndDownNullableMax();
            TestNewEnumerableDoubleUpAndDownMax();
            TestNewEnumerableDoubleShuffledNullableMax();
            TestNewEnumerableDoubleShuffledMax();
            TestNewEnumerableDoubleSolitaireNullableMax();
            TestNewEnumerableDoubleSolitaireMax();
            TestNewEnumerableDoubleEmptyNullableMax();
            TestNewEnumerableDoubleEmptyMax();
            TestNewEnumerableNullableDouble10PercentNulledMax();
            TestNewEnumerableNullableDouble20PercentNulledMax();
            TestNewEnumerableNullableDouble30PercentNulledMax();
            TestNewEnumerableNullableDouble40PercentNulledMax();
            TestNewEnumerableNullableDouble50PercentNulledMax();
            TestNewEnumerableNullableDouble60PercentNulledMax();
            TestNewEnumerableNullableDouble70PercentNulledMax();
            TestNewEnumerableNullableDouble80PercentNulledMax();
            TestNewEnumerableNullableDouble90PercentNulledMax();
            TestNewEnumerableDouble10PercentNaNMax();
            TestNewEnumerableNullableDouble10PercentNaNOrNullMax();
            TestNewEnumerableDouble20PercentNaNMax();
            TestNewEnumerableNullableDouble20PercentNaNOrNullMax();
            TestNewEnumerableDouble30PercentNaNMax();
            TestNewEnumerableNullableDouble30PercentNaNOrNullMax();
            TestNewEnumerableDouble40PercentNaNMax();
            TestNewEnumerableNullableDouble40PercentNaNOrNullMax();
            TestNewEnumerableDouble50PercentNaNMax();
            TestNewEnumerableNullableDouble50PercentNaNOrNullMax();
            TestNewEnumerableDouble60PercentNaNMax();
            TestNewEnumerableNullableDouble60PercentNaNOrNullMax();
            TestNewEnumerableDouble70PercentNaNMax();
            TestNewEnumerableNullableDouble70PercentNaNOrNullMax();
            TestNewEnumerableDouble80PercentNaNMax();
            TestNewEnumerableNullableDouble80PercentNaNOrNullMax();
            TestNewEnumerableDouble90PercentNaNMax();
            TestNewEnumerableNullableDouble90PercentNaNOrNullMax();
            TestNewEnumerableDecimalIncrementedNullableMin();
            TestNewEnumerableDecimalIncrementedMin();
            TestNewEnumerableDecimalDecrementedNullableMin();
            TestNewEnumerableDecimalDecrementedMin();
            TestNewEnumerableDecimalUpAndDownNullableMin();
            TestNewEnumerableDecimalUpAndDownMin();
            TestNewEnumerableDecimalShuffledNullableMin();
            TestNewEnumerableDecimalShuffledMin();
            TestNewEnumerableDecimalSolitaireNullableMin();
            TestNewEnumerableDecimalSolitaireMin();
            TestNewEnumerableDecimalEmptyNullableMin();
            TestNewEnumerableDecimalEmptyMin();
            TestNewEnumerableNullableDecimal10PercentNulledMin();
            TestNewEnumerableNullableDecimal20PercentNulledMin();
            TestNewEnumerableNullableDecimal30PercentNulledMin();
            TestNewEnumerableNullableDecimal40PercentNulledMin();
            TestNewEnumerableNullableDecimal50PercentNulledMin();
            TestNewEnumerableNullableDecimal60PercentNulledMin();
            TestNewEnumerableNullableDecimal70PercentNulledMin();
            TestNewEnumerableNullableDecimal80PercentNulledMin();
            TestNewEnumerableNullableDecimal90PercentNulledMin();
            TestNewEnumerableDecimalIncrementedNullableMax();
            TestNewEnumerableDecimalIncrementedMax();
            TestNewEnumerableDecimalDecrementedNullableMax();
            TestNewEnumerableDecimalDecrementedMax();
            TestNewEnumerableDecimalUpAndDownNullableMax();
            TestNewEnumerableDecimalUpAndDownMax();
            TestNewEnumerableDecimalShuffledNullableMax();
            TestNewEnumerableDecimalShuffledMax();
            TestNewEnumerableDecimalSolitaireNullableMax();
            TestNewEnumerableDecimalSolitaireMax();
            TestNewEnumerableDecimalEmptyNullableMax();
            TestNewEnumerableDecimalEmptyMax();
            TestNewEnumerableNullableDecimal10PercentNulledMax();
            TestNewEnumerableNullableDecimal20PercentNulledMax();
            TestNewEnumerableNullableDecimal30PercentNulledMax();
            TestNewEnumerableNullableDecimal40PercentNulledMax();
            TestNewEnumerableNullableDecimal50PercentNulledMax();
            TestNewEnumerableNullableDecimal60PercentNulledMax();
            TestNewEnumerableNullableDecimal70PercentNulledMax();
            TestNewEnumerableNullableDecimal80PercentNulledMax();
            TestNewEnumerableNullableDecimal90PercentNulledMax();
            TestNewEnumerableStringIncrementedMin();
            TestNewEnumerableStringDecrementedMin();
            TestNewEnumerableStringUpAndDownMin();
            TestNewEnumerableStringShuffledMin();
            TestNewEnumerableStringSolitaireMin();
            TestNewEnumerableStringEmptyMin();
            TestNewEnumerableString10PercentNulledMin();
            TestNewEnumerableString20PercentNulledMin();
            TestNewEnumerableString30PercentNulledMin();
            TestNewEnumerableString40PercentNulledMin();
            TestNewEnumerableString50PercentNulledMin();
            TestNewEnumerableString60PercentNulledMin();
            TestNewEnumerableString70PercentNulledMin();
            TestNewEnumerableString80PercentNulledMin();
            TestNewEnumerableString90PercentNulledMin();
            TestNewEnumerableStringIncrementedMax();
            TestNewEnumerableStringDecrementedMax();
            TestNewEnumerableStringUpAndDownMax();
            TestNewEnumerableStringShuffledMax();
            TestNewEnumerableStringSolitaireMax();
            TestNewEnumerableStringEmptyMax();
            TestNewEnumerableString10PercentNulledMax();
            TestNewEnumerableString20PercentNulledMax();
            TestNewEnumerableString30PercentNulledMax();
            TestNewEnumerableString40PercentNulledMax();
            TestNewEnumerableString50PercentNulledMax();
            TestNewEnumerableString60PercentNulledMax();
            TestNewEnumerableString70PercentNulledMax();
            TestNewEnumerableString80PercentNulledMax();
            TestNewEnumerableString90PercentNulledMax();
            TestNewEnumerableDateTimeIncrementedNullableMin();
            TestNewEnumerableDateTimeIncrementedMin();
            TestNewEnumerableDateTimeDecrementedNullableMin();
            TestNewEnumerableDateTimeDecrementedMin();
            TestNewEnumerableDateTimeUpAndDownNullableMin();
            TestNewEnumerableDateTimeUpAndDownMin();
            TestNewEnumerableDateTimeShuffledNullableMin();
            TestNewEnumerableDateTimeShuffledMin();
            TestNewEnumerableDateTimeSolitaireNullableMin();
            TestNewEnumerableDateTimeSolitaireMin();
            TestNewEnumerableDateTimeEmptyNullableMin();
            TestNewEnumerableDateTimeEmptyMin();
            TestNewEnumerableNullableDateTime10PercentNulledMin();
            TestNewEnumerableNullableDateTime20PercentNulledMin();
            TestNewEnumerableNullableDateTime30PercentNulledMin();
            TestNewEnumerableNullableDateTime40PercentNulledMin();
            TestNewEnumerableNullableDateTime50PercentNulledMin();
            TestNewEnumerableNullableDateTime60PercentNulledMin();
            TestNewEnumerableNullableDateTime70PercentNulledMin();
            TestNewEnumerableNullableDateTime80PercentNulledMin();
            TestNewEnumerableNullableDateTime90PercentNulledMin();
            TestNewEnumerableDateTimeIncrementedNullableMax();
            TestNewEnumerableDateTimeIncrementedMax();
            TestNewEnumerableDateTimeDecrementedNullableMax();
            TestNewEnumerableDateTimeDecrementedMax();
            TestNewEnumerableDateTimeUpAndDownNullableMax();
            TestNewEnumerableDateTimeUpAndDownMax();
            TestNewEnumerableDateTimeShuffledNullableMax();
            TestNewEnumerableDateTimeShuffledMax();
            TestNewEnumerableDateTimeSolitaireNullableMax();
            TestNewEnumerableDateTimeSolitaireMax();
            TestNewEnumerableDateTimeEmptyNullableMax();
            TestNewEnumerableDateTimeEmptyMax();
            TestNewEnumerableNullableDateTime10PercentNulledMax();
            TestNewEnumerableNullableDateTime20PercentNulledMax();
            TestNewEnumerableNullableDateTime30PercentNulledMax();
            TestNewEnumerableNullableDateTime40PercentNulledMax();
            TestNewEnumerableNullableDateTime50PercentNulledMax();
            TestNewEnumerableNullableDateTime60PercentNulledMax();
            TestNewEnumerableNullableDateTime70PercentNulledMax();
            TestNewEnumerableNullableDateTime80PercentNulledMax();
            TestNewEnumerableNullableDateTime90PercentNulledMax();
            TestNewEnumerableExampleReferenceTypeIncrementedMin();
            TestNewEnumerableExampleReferenceTypeDecrementedMin();
            TestNewEnumerableExampleReferenceTypeUpAndDownMin();
            TestNewEnumerableExampleReferenceTypeShuffledMin();
            TestNewEnumerableExampleReferenceTypeSolitaireMin();
            TestNewEnumerableExampleReferenceTypeEmptyMin();
            TestNewEnumerableExampleReferenceType10PercentNulledMin();
            TestNewEnumerableExampleReferenceType20PercentNulledMin();
            TestNewEnumerableExampleReferenceType30PercentNulledMin();
            TestNewEnumerableExampleReferenceType40PercentNulledMin();
            TestNewEnumerableExampleReferenceType50PercentNulledMin();
            TestNewEnumerableExampleReferenceType60PercentNulledMin();
            TestNewEnumerableExampleReferenceType70PercentNulledMin();
            TestNewEnumerableExampleReferenceType80PercentNulledMin();
            TestNewEnumerableExampleReferenceType90PercentNulledMin();
            TestNewEnumerableExampleReferenceTypeIncrementedMax();
            TestNewEnumerableExampleReferenceTypeDecrementedMax();
            TestNewEnumerableExampleReferenceTypeUpAndDownMax();
            TestNewEnumerableExampleReferenceTypeShuffledMax();
            TestNewEnumerableExampleReferenceTypeSolitaireMax();
            TestNewEnumerableExampleReferenceTypeEmptyMax();
            TestNewEnumerableExampleReferenceType10PercentNulledMax();
            TestNewEnumerableExampleReferenceType20PercentNulledMax();
            TestNewEnumerableExampleReferenceType30PercentNulledMax();
            TestNewEnumerableExampleReferenceType40PercentNulledMax();
            TestNewEnumerableExampleReferenceType50PercentNulledMax();
            TestNewEnumerableExampleReferenceType60PercentNulledMax();
            TestNewEnumerableExampleReferenceType70PercentNulledMax();
            TestNewEnumerableExampleReferenceType80PercentNulledMax();
            TestNewEnumerableExampleReferenceType90PercentNulledMax();
        }
    }
}