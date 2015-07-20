using System;
using System.Diagnostics;
using System.Linq;

namespace EnumerableTester
{
    public static class AverageTests
    {
                    private static void TestOldEnumerableInt32IncrementedNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt32IncrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.IncrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32IncrementedAverage()
        {
            Console.WriteLine("TestOldEnumerableInt32IncrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.IncrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32DecrementedNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt32DecrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.DecrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32DecrementedAverage()
        {
            Console.WriteLine("TestOldEnumerableInt32DecrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.DecrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32UpAndDownNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt32UpAndDownNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.UpAndDownNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32UpAndDownAverage()
        {
            Console.WriteLine("TestOldEnumerableInt32UpAndDownAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.UpAndDownInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32ShuffledNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt32ShuffledNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.ShuffledNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32ShuffledAverage()
        {
            Console.WriteLine("TestOldEnumerableInt32ShuffledAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.ShuffledInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32SolitaireNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt32SolitaireNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.SolitaireNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32SolitaireAverage()
        {
            Console.WriteLine("TestOldEnumerableInt32SolitaireAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.SolitaireInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt32EmptyNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt32EmptyNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.EmptyNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt32EmptyAverage()
        {
            Console.WriteLine("TestOldEnumerableInt32EmptyAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Average(SourceEnumerables.EmptyInt32);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableInt3210PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3210PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt3210PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3220PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3220PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt3220PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3230PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3230PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt3230PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3240PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3240PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt3240PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3250PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3250PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt3250PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3260PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3260PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt3260PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3270PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3270PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt3270PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3280PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3280PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt3280PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt3290PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt3290PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt3290PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestOldEnumerableInt64IncrementedNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt64IncrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.IncrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64IncrementedAverage()
        {
            Console.WriteLine("TestOldEnumerableInt64IncrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.IncrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64DecrementedNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt64DecrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.DecrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64DecrementedAverage()
        {
            Console.WriteLine("TestOldEnumerableInt64DecrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.DecrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64UpAndDownNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt64UpAndDownNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.UpAndDownNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64UpAndDownAverage()
        {
            Console.WriteLine("TestOldEnumerableInt64UpAndDownAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.UpAndDownInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64ShuffledNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt64ShuffledNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.ShuffledNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64ShuffledAverage()
        {
            Console.WriteLine("TestOldEnumerableInt64ShuffledAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.ShuffledInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64SolitaireNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt64SolitaireNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.SolitaireNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64SolitaireAverage()
        {
            Console.WriteLine("TestOldEnumerableInt64SolitaireAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.SolitaireInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableInt64EmptyNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableInt64EmptyNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.EmptyNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableInt64EmptyAverage()
        {
            Console.WriteLine("TestOldEnumerableInt64EmptyAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Average(SourceEnumerables.EmptyInt64);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableInt6410PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6410PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt6410PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6420PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6420PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt6420PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6430PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6430PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt6430PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6440PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6440PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt6440PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6450PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6450PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt6450PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6460PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6460PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt6460PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6470PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6470PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt6470PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6480PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6480PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt6480PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableInt6490PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableInt6490PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableInt6490PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestOldEnumerableSingleIncrementedNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableSingleIncrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.IncrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleIncrementedAverage()
        {
            Console.WriteLine("TestOldEnumerableSingleIncrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.IncrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleDecrementedNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableSingleDecrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.DecrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleDecrementedAverage()
        {
            Console.WriteLine("TestOldEnumerableSingleDecrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.DecrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleUpAndDownNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableSingleUpAndDownNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.UpAndDownNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleUpAndDownAverage()
        {
            Console.WriteLine("TestOldEnumerableSingleUpAndDownAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.UpAndDownSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleShuffledNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableSingleShuffledNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.ShuffledNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleShuffledAverage()
        {
            Console.WriteLine("TestOldEnumerableSingleShuffledAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.ShuffledSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleSolitaireNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableSingleSolitaireNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.SolitaireNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleSolitaireAverage()
        {
            Console.WriteLine("TestOldEnumerableSingleSolitaireAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.SolitaireSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableSingleEmptyNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableSingleEmptyNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.EmptyNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableSingleEmptyAverage()
        {
            Console.WriteLine("TestOldEnumerableSingleEmptyAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Average(SourceEnumerables.EmptySingle);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableSingle10PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle10PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableSingle10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle20PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle20PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableSingle20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle30PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle30PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableSingle30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle40PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle40PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableSingle40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle50PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle50PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableSingle50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle60PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle60PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableSingle60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle70PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle70PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableSingle70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle80PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle80PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableSingle80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableSingle90PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableSingle90PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableSingle90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestOldEnumerableSingle10PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableSingle10PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Single10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle10PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle10PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableSingle10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle20PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableSingle20PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Single20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle20PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle20PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableSingle20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle30PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableSingle30PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Single30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle30PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle30PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableSingle30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle40PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableSingle40PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Single40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle40PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle40PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableSingle40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle50PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableSingle50PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Single50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle50PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle50PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableSingle50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle60PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableSingle60PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Single60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle60PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle60PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableSingle60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle70PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableSingle70PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Single70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle70PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle70PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableSingle70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle80PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableSingle80PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Single80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle80PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle80PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableSingle80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableSingle90PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableSingle90PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Single90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableSingle90PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableSingle90PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableSingle90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestOldEnumerableDoubleIncrementedNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDoubleIncrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.IncrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleIncrementedAverage()
        {
            Console.WriteLine("TestOldEnumerableDoubleIncrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.IncrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleDecrementedNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDoubleDecrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.DecrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleDecrementedAverage()
        {
            Console.WriteLine("TestOldEnumerableDoubleDecrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.DecrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleUpAndDownNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDoubleUpAndDownNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.UpAndDownNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleUpAndDownAverage()
        {
            Console.WriteLine("TestOldEnumerableDoubleUpAndDownAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.UpAndDownDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleShuffledNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDoubleShuffledNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.ShuffledNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleShuffledAverage()
        {
            Console.WriteLine("TestOldEnumerableDoubleShuffledAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.ShuffledDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleSolitaireNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDoubleSolitaireNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.SolitaireNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleSolitaireAverage()
        {
            Console.WriteLine("TestOldEnumerableDoubleSolitaireAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.SolitaireDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDoubleEmptyNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDoubleEmptyNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.EmptyNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDoubleEmptyAverage()
        {
            Console.WriteLine("TestOldEnumerableDoubleEmptyAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Average(SourceEnumerables.EmptyDouble);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableDouble10PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble10PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDouble10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble20PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble20PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDouble20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble30PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble30PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDouble30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble40PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble40PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDouble40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble50PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble50PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDouble50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble60PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble60PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDouble60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble70PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble70PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDouble70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble80PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble80PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDouble80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDouble90PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDouble90PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDouble90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestOldEnumerableDouble10PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableDouble10PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Double10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble10PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble10PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableDouble10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble20PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableDouble20PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Double20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble20PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble20PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableDouble20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble30PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableDouble30PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Double30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble30PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble30PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableDouble30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble40PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableDouble40PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Double40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble40PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble40PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableDouble40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble50PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableDouble50PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Double50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble50PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble50PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableDouble50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble60PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableDouble60PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Double60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble60PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble60PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableDouble60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble70PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableDouble70PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Double70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble70PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble70PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableDouble70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble80PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableDouble80PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Double80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble80PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble80PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableDouble80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableDouble90PercentNaNAverage()
        {
            Console.WriteLine("TestOldEnumerableDouble90PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.Double90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestOldEnumerableNullableDouble90PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestOldEnumerableNullableDouble90PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                OldEnumerable.Average(SourceEnumerables.NullableDouble90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestOldEnumerableDecimalIncrementedNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDecimalIncrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.IncrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalIncrementedAverage()
        {
            Console.WriteLine("TestOldEnumerableDecimalIncrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.IncrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalDecrementedNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDecimalDecrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.DecrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalDecrementedAverage()
        {
            Console.WriteLine("TestOldEnumerableDecimalDecrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.DecrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalUpAndDownNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDecimalUpAndDownNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.UpAndDownNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalUpAndDownAverage()
        {
            Console.WriteLine("TestOldEnumerableDecimalUpAndDownAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.UpAndDownDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalShuffledNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDecimalShuffledNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.ShuffledNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalShuffledAverage()
        {
            Console.WriteLine("TestOldEnumerableDecimalShuffledAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.ShuffledDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalSolitaireNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDecimalSolitaireNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.SolitaireNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalSolitaireAverage()
        {
            Console.WriteLine("TestOldEnumerableDecimalSolitaireAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.SolitaireDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestOldEnumerableDecimalEmptyNullableAverage()
                {
                    Console.WriteLine("TestOldEnumerableDecimalEmptyNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        OldEnumerable.Average(SourceEnumerables.EmptyNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestOldEnumerableDecimalEmptyAverage()
        {
            Console.WriteLine("TestOldEnumerableDecimalEmptyAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        OldEnumerable.Average(SourceEnumerables.EmptyDecimal);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestOldEnumerableNullableDecimal10PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal10PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDecimal10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal20PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal20PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDecimal20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal30PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal30PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDecimal30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal40PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal40PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDecimal40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal50PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal50PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDecimal50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal60PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal60PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDecimal60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal70PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal70PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDecimal70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal80PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal80PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDecimal80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestOldEnumerableNullableDecimal90PercentNulledAverage()
            {
                Console.WriteLine("TestOldEnumerableNullableDecimal90PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    OldEnumerable.Average(SourceEnumerables.NullableDecimal90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableInt32IncrementedNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt32IncrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.IncrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32IncrementedAverage()
        {
            Console.WriteLine("TestNewEnumerableInt32IncrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.IncrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32DecrementedNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt32DecrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.DecrementedNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32DecrementedAverage()
        {
            Console.WriteLine("TestNewEnumerableInt32DecrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.DecrementedInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32UpAndDownNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt32UpAndDownNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.UpAndDownNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32UpAndDownAverage()
        {
            Console.WriteLine("TestNewEnumerableInt32UpAndDownAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.UpAndDownInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32ShuffledNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt32ShuffledNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.ShuffledNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32ShuffledAverage()
        {
            Console.WriteLine("TestNewEnumerableInt32ShuffledAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.ShuffledInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32SolitaireNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt32SolitaireNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.SolitaireNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32SolitaireAverage()
        {
            Console.WriteLine("TestNewEnumerableInt32SolitaireAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.SolitaireInt32);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt32EmptyNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt32EmptyNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.EmptyNullableInt32);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt32EmptyAverage()
        {
            Console.WriteLine("TestNewEnumerableInt32EmptyAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Average(SourceEnumerables.EmptyInt32);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableInt3210PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3210PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt3210PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3220PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3220PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt3220PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3230PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3230PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt3230PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3240PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3240PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt3240PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3250PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3250PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt3250PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3260PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3260PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt3260PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3270PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3270PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt3270PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3280PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3280PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt3280PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt3290PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt3290PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt3290PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableInt64IncrementedNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt64IncrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.IncrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64IncrementedAverage()
        {
            Console.WriteLine("TestNewEnumerableInt64IncrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.IncrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64DecrementedNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt64DecrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.DecrementedNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64DecrementedAverage()
        {
            Console.WriteLine("TestNewEnumerableInt64DecrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.DecrementedInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64UpAndDownNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt64UpAndDownNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.UpAndDownNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64UpAndDownAverage()
        {
            Console.WriteLine("TestNewEnumerableInt64UpAndDownAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.UpAndDownInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64ShuffledNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt64ShuffledNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.ShuffledNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64ShuffledAverage()
        {
            Console.WriteLine("TestNewEnumerableInt64ShuffledAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.ShuffledInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64SolitaireNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt64SolitaireNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.SolitaireNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64SolitaireAverage()
        {
            Console.WriteLine("TestNewEnumerableInt64SolitaireAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.SolitaireInt64);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableInt64EmptyNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableInt64EmptyNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.EmptyNullableInt64);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableInt64EmptyAverage()
        {
            Console.WriteLine("TestNewEnumerableInt64EmptyAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Average(SourceEnumerables.EmptyInt64);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableInt6410PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6410PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt6410PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6420PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6420PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt6420PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6430PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6430PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt6430PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6440PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6440PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt6440PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6450PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6450PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt6450PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6460PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6460PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt6460PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6470PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6470PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt6470PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6480PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6480PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt6480PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableInt6490PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableInt6490PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableInt6490PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }                private static void TestNewEnumerableSingleIncrementedNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableSingleIncrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.IncrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleIncrementedAverage()
        {
            Console.WriteLine("TestNewEnumerableSingleIncrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.IncrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleDecrementedNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableSingleDecrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.DecrementedNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleDecrementedAverage()
        {
            Console.WriteLine("TestNewEnumerableSingleDecrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.DecrementedSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleUpAndDownNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableSingleUpAndDownNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.UpAndDownNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleUpAndDownAverage()
        {
            Console.WriteLine("TestNewEnumerableSingleUpAndDownAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.UpAndDownSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleShuffledNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableSingleShuffledNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.ShuffledNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleShuffledAverage()
        {
            Console.WriteLine("TestNewEnumerableSingleShuffledAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.ShuffledSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleSolitaireNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableSingleSolitaireNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.SolitaireNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleSolitaireAverage()
        {
            Console.WriteLine("TestNewEnumerableSingleSolitaireAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.SolitaireSingle);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableSingleEmptyNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableSingleEmptyNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.EmptyNullableSingle);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableSingleEmptyAverage()
        {
            Console.WriteLine("TestNewEnumerableSingleEmptyAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Average(SourceEnumerables.EmptySingle);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableSingle10PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle10PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableSingle10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle20PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle20PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableSingle20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle30PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle30PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableSingle30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle40PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle40PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableSingle40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle50PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle50PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableSingle50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle60PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle60PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableSingle60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle70PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle70PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableSingle70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle80PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle80PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableSingle80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableSingle90PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableSingle90PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableSingle90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestNewEnumerableSingle10PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableSingle10PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Single10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle10PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle10PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableSingle10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle20PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableSingle20PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Single20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle20PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle20PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableSingle20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle30PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableSingle30PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Single30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle30PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle30PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableSingle30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle40PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableSingle40PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Single40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle40PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle40PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableSingle40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle50PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableSingle50PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Single50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle50PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle50PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableSingle50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle60PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableSingle60PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Single60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle60PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle60PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableSingle60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle70PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableSingle70PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Single70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle70PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle70PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableSingle70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle80PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableSingle80PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Single80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle80PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle80PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableSingle80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableSingle90PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableSingle90PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Single90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableSingle90PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableSingle90PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableSingle90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestNewEnumerableDoubleIncrementedNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDoubleIncrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.IncrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleIncrementedAverage()
        {
            Console.WriteLine("TestNewEnumerableDoubleIncrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.IncrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleDecrementedNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDoubleDecrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.DecrementedNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleDecrementedAverage()
        {
            Console.WriteLine("TestNewEnumerableDoubleDecrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.DecrementedDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleUpAndDownNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDoubleUpAndDownNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.UpAndDownNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleUpAndDownAverage()
        {
            Console.WriteLine("TestNewEnumerableDoubleUpAndDownAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.UpAndDownDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleShuffledNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDoubleShuffledNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.ShuffledNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleShuffledAverage()
        {
            Console.WriteLine("TestNewEnumerableDoubleShuffledAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.ShuffledDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleSolitaireNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDoubleSolitaireNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.SolitaireNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleSolitaireAverage()
        {
            Console.WriteLine("TestNewEnumerableDoubleSolitaireAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.SolitaireDouble);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDoubleEmptyNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDoubleEmptyNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.EmptyNullableDouble);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDoubleEmptyAverage()
        {
            Console.WriteLine("TestNewEnumerableDoubleEmptyAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Average(SourceEnumerables.EmptyDouble);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableDouble10PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble10PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDouble10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble20PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble20PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDouble20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble30PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble30PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDouble30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble40PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble40PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDouble40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble50PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble50PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDouble50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble60PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble60PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDouble60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble70PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble70PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDouble70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble80PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble80PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDouble80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDouble90PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDouble90PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDouble90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }private static void TestNewEnumerableDouble10PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableDouble10PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Double10PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble10PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble10PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableDouble10PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble20PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableDouble20PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Double20PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble20PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble20PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableDouble20PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble30PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableDouble30PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Double30PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble30PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble30PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableDouble30PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble40PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableDouble40PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Double40PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble40PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble40PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableDouble40PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble50PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableDouble50PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Double50PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble50PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble50PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableDouble50PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble60PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableDouble60PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Double60PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble60PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble60PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableDouble60PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble70PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableDouble70PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Double70PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble70PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble70PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableDouble70PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble80PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableDouble80PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Double80PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble80PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble80PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableDouble80PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableDouble90PercentNaNAverage()
        {
            Console.WriteLine("TestNewEnumerableDouble90PercentNaNAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.Double90PercentNaN);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
        private static void TestNewEnumerableNullableDouble90PercentNaNOrNullAverage()
        {
            Console.WriteLine("TestNewEnumerableNullableDouble90PercentNaNOrNullAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
            for(var i = 0; i != 100000; ++i)
                NewEnumerable.Average(SourceEnumerables.NullableDouble90PercentNaNOrNull);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                        private static void TestNewEnumerableDecimalIncrementedNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDecimalIncrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.IncrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalIncrementedAverage()
        {
            Console.WriteLine("TestNewEnumerableDecimalIncrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.IncrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalDecrementedNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDecimalDecrementedNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.DecrementedNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalDecrementedAverage()
        {
            Console.WriteLine("TestNewEnumerableDecimalDecrementedAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.DecrementedDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalUpAndDownNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDecimalUpAndDownNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.UpAndDownNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalUpAndDownAverage()
        {
            Console.WriteLine("TestNewEnumerableDecimalUpAndDownAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.UpAndDownDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalShuffledNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDecimalShuffledNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.ShuffledNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalShuffledAverage()
        {
            Console.WriteLine("TestNewEnumerableDecimalShuffledAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.ShuffledDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalSolitaireNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDecimalSolitaireNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.SolitaireNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalSolitaireAverage()
        {
            Console.WriteLine("TestNewEnumerableDecimalSolitaireAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.SolitaireDecimal);
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
                private static void TestNewEnumerableDecimalEmptyNullableAverage()
                {
                    Console.WriteLine("TestNewEnumerableDecimalEmptyNullableAverage");
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 100000; ++i)
                        NewEnumerable.Average(SourceEnumerables.EmptyNullableDecimal);
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }        private static void TestNewEnumerableDecimalEmptyAverage()
        {
            Console.WriteLine("TestNewEnumerableDecimalEmptyAverage");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            var sw = Stopwatch.StartNew();
                                        for(var i = 0; i != 100000; ++i)
                    {
                        try{
                        NewEnumerable.Average(SourceEnumerables.EmptyDecimal);
                        }catch{}
                    }
                                sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
            private static void TestNewEnumerableNullableDecimal10PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal10PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDecimal10PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal20PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal20PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDecimal20PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal30PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal30PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDecimal30PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal40PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal40PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDecimal40PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal50PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal50PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDecimal50PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal60PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal60PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDecimal60PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal70PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal70PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDecimal70PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal80PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal80PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDecimal80PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }            private static void TestNewEnumerableNullableDecimal90PercentNulledAverage()
            {
                Console.WriteLine("TestNewEnumerableNullableDecimal90PercentNulledAverage");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                var sw = Stopwatch.StartNew();
                for(var i = 0; i != 100000; ++i)
                    NewEnumerable.Average(SourceEnumerables.NullableDecimal90PercentNulled);
                sw.Stop();
                Console.WriteLine(sw.ElapsedTicks);
            }      public static void DoTests()
        {
            TestOldEnumerableInt32IncrementedNullableAverage();
            TestOldEnumerableInt32IncrementedAverage();
            TestOldEnumerableInt32DecrementedNullableAverage();
            TestOldEnumerableInt32DecrementedAverage();
            TestOldEnumerableInt32UpAndDownNullableAverage();
            TestOldEnumerableInt32UpAndDownAverage();
            TestOldEnumerableInt32ShuffledNullableAverage();
            TestOldEnumerableInt32ShuffledAverage();
            TestOldEnumerableInt32SolitaireNullableAverage();
            TestOldEnumerableInt32SolitaireAverage();
            TestOldEnumerableInt32EmptyNullableAverage();
            TestOldEnumerableInt32EmptyAverage();
            TestOldEnumerableNullableInt3210PercentNulledAverage();
            TestOldEnumerableNullableInt3220PercentNulledAverage();
            TestOldEnumerableNullableInt3230PercentNulledAverage();
            TestOldEnumerableNullableInt3240PercentNulledAverage();
            TestOldEnumerableNullableInt3250PercentNulledAverage();
            TestOldEnumerableNullableInt3260PercentNulledAverage();
            TestOldEnumerableNullableInt3270PercentNulledAverage();
            TestOldEnumerableNullableInt3280PercentNulledAverage();
            TestOldEnumerableNullableInt3290PercentNulledAverage();
            TestOldEnumerableInt64IncrementedNullableAverage();
            TestOldEnumerableInt64IncrementedAverage();
            TestOldEnumerableInt64DecrementedNullableAverage();
            TestOldEnumerableInt64DecrementedAverage();
            TestOldEnumerableInt64UpAndDownNullableAverage();
            TestOldEnumerableInt64UpAndDownAverage();
            TestOldEnumerableInt64ShuffledNullableAverage();
            TestOldEnumerableInt64ShuffledAverage();
            TestOldEnumerableInt64SolitaireNullableAverage();
            TestOldEnumerableInt64SolitaireAverage();
            TestOldEnumerableInt64EmptyNullableAverage();
            TestOldEnumerableInt64EmptyAverage();
            TestOldEnumerableNullableInt6410PercentNulledAverage();
            TestOldEnumerableNullableInt6420PercentNulledAverage();
            TestOldEnumerableNullableInt6430PercentNulledAverage();
            TestOldEnumerableNullableInt6440PercentNulledAverage();
            TestOldEnumerableNullableInt6450PercentNulledAverage();
            TestOldEnumerableNullableInt6460PercentNulledAverage();
            TestOldEnumerableNullableInt6470PercentNulledAverage();
            TestOldEnumerableNullableInt6480PercentNulledAverage();
            TestOldEnumerableNullableInt6490PercentNulledAverage();
            TestOldEnumerableSingleIncrementedNullableAverage();
            TestOldEnumerableSingleIncrementedAverage();
            TestOldEnumerableSingleDecrementedNullableAverage();
            TestOldEnumerableSingleDecrementedAverage();
            TestOldEnumerableSingleUpAndDownNullableAverage();
            TestOldEnumerableSingleUpAndDownAverage();
            TestOldEnumerableSingleShuffledNullableAverage();
            TestOldEnumerableSingleShuffledAverage();
            TestOldEnumerableSingleSolitaireNullableAverage();
            TestOldEnumerableSingleSolitaireAverage();
            TestOldEnumerableSingleEmptyNullableAverage();
            TestOldEnumerableSingleEmptyAverage();
            TestOldEnumerableNullableSingle10PercentNulledAverage();
            TestOldEnumerableNullableSingle20PercentNulledAverage();
            TestOldEnumerableNullableSingle30PercentNulledAverage();
            TestOldEnumerableNullableSingle40PercentNulledAverage();
            TestOldEnumerableNullableSingle50PercentNulledAverage();
            TestOldEnumerableNullableSingle60PercentNulledAverage();
            TestOldEnumerableNullableSingle70PercentNulledAverage();
            TestOldEnumerableNullableSingle80PercentNulledAverage();
            TestOldEnumerableNullableSingle90PercentNulledAverage();
            TestOldEnumerableSingle10PercentNaNAverage();
            TestOldEnumerableNullableSingle10PercentNaNOrNullAverage();
            TestOldEnumerableSingle20PercentNaNAverage();
            TestOldEnumerableNullableSingle20PercentNaNOrNullAverage();
            TestOldEnumerableSingle30PercentNaNAverage();
            TestOldEnumerableNullableSingle30PercentNaNOrNullAverage();
            TestOldEnumerableSingle40PercentNaNAverage();
            TestOldEnumerableNullableSingle40PercentNaNOrNullAverage();
            TestOldEnumerableSingle50PercentNaNAverage();
            TestOldEnumerableNullableSingle50PercentNaNOrNullAverage();
            TestOldEnumerableSingle60PercentNaNAverage();
            TestOldEnumerableNullableSingle60PercentNaNOrNullAverage();
            TestOldEnumerableSingle70PercentNaNAverage();
            TestOldEnumerableNullableSingle70PercentNaNOrNullAverage();
            TestOldEnumerableSingle80PercentNaNAverage();
            TestOldEnumerableNullableSingle80PercentNaNOrNullAverage();
            TestOldEnumerableSingle90PercentNaNAverage();
            TestOldEnumerableNullableSingle90PercentNaNOrNullAverage();
            TestOldEnumerableDoubleIncrementedNullableAverage();
            TestOldEnumerableDoubleIncrementedAverage();
            TestOldEnumerableDoubleDecrementedNullableAverage();
            TestOldEnumerableDoubleDecrementedAverage();
            TestOldEnumerableDoubleUpAndDownNullableAverage();
            TestOldEnumerableDoubleUpAndDownAverage();
            TestOldEnumerableDoubleShuffledNullableAverage();
            TestOldEnumerableDoubleShuffledAverage();
            TestOldEnumerableDoubleSolitaireNullableAverage();
            TestOldEnumerableDoubleSolitaireAverage();
            TestOldEnumerableDoubleEmptyNullableAverage();
            TestOldEnumerableDoubleEmptyAverage();
            TestOldEnumerableNullableDouble10PercentNulledAverage();
            TestOldEnumerableNullableDouble20PercentNulledAverage();
            TestOldEnumerableNullableDouble30PercentNulledAverage();
            TestOldEnumerableNullableDouble40PercentNulledAverage();
            TestOldEnumerableNullableDouble50PercentNulledAverage();
            TestOldEnumerableNullableDouble60PercentNulledAverage();
            TestOldEnumerableNullableDouble70PercentNulledAverage();
            TestOldEnumerableNullableDouble80PercentNulledAverage();
            TestOldEnumerableNullableDouble90PercentNulledAverage();
            TestOldEnumerableDouble10PercentNaNAverage();
            TestOldEnumerableNullableDouble10PercentNaNOrNullAverage();
            TestOldEnumerableDouble20PercentNaNAverage();
            TestOldEnumerableNullableDouble20PercentNaNOrNullAverage();
            TestOldEnumerableDouble30PercentNaNAverage();
            TestOldEnumerableNullableDouble30PercentNaNOrNullAverage();
            TestOldEnumerableDouble40PercentNaNAverage();
            TestOldEnumerableNullableDouble40PercentNaNOrNullAverage();
            TestOldEnumerableDouble50PercentNaNAverage();
            TestOldEnumerableNullableDouble50PercentNaNOrNullAverage();
            TestOldEnumerableDouble60PercentNaNAverage();
            TestOldEnumerableNullableDouble60PercentNaNOrNullAverage();
            TestOldEnumerableDouble70PercentNaNAverage();
            TestOldEnumerableNullableDouble70PercentNaNOrNullAverage();
            TestOldEnumerableDouble80PercentNaNAverage();
            TestOldEnumerableNullableDouble80PercentNaNOrNullAverage();
            TestOldEnumerableDouble90PercentNaNAverage();
            TestOldEnumerableNullableDouble90PercentNaNOrNullAverage();
            TestOldEnumerableDecimalIncrementedNullableAverage();
            TestOldEnumerableDecimalIncrementedAverage();
            TestOldEnumerableDecimalDecrementedNullableAverage();
            TestOldEnumerableDecimalDecrementedAverage();
            TestOldEnumerableDecimalUpAndDownNullableAverage();
            TestOldEnumerableDecimalUpAndDownAverage();
            TestOldEnumerableDecimalShuffledNullableAverage();
            TestOldEnumerableDecimalShuffledAverage();
            TestOldEnumerableDecimalSolitaireNullableAverage();
            TestOldEnumerableDecimalSolitaireAverage();
            TestOldEnumerableDecimalEmptyNullableAverage();
            TestOldEnumerableDecimalEmptyAverage();
            TestOldEnumerableNullableDecimal10PercentNulledAverage();
            TestOldEnumerableNullableDecimal20PercentNulledAverage();
            TestOldEnumerableNullableDecimal30PercentNulledAverage();
            TestOldEnumerableNullableDecimal40PercentNulledAverage();
            TestOldEnumerableNullableDecimal50PercentNulledAverage();
            TestOldEnumerableNullableDecimal60PercentNulledAverage();
            TestOldEnumerableNullableDecimal70PercentNulledAverage();
            TestOldEnumerableNullableDecimal80PercentNulledAverage();
            TestOldEnumerableNullableDecimal90PercentNulledAverage();
            TestNewEnumerableInt32IncrementedNullableAverage();
            TestNewEnumerableInt32IncrementedAverage();
            TestNewEnumerableInt32DecrementedNullableAverage();
            TestNewEnumerableInt32DecrementedAverage();
            TestNewEnumerableInt32UpAndDownNullableAverage();
            TestNewEnumerableInt32UpAndDownAverage();
            TestNewEnumerableInt32ShuffledNullableAverage();
            TestNewEnumerableInt32ShuffledAverage();
            TestNewEnumerableInt32SolitaireNullableAverage();
            TestNewEnumerableInt32SolitaireAverage();
            TestNewEnumerableInt32EmptyNullableAverage();
            TestNewEnumerableInt32EmptyAverage();
            TestNewEnumerableNullableInt3210PercentNulledAverage();
            TestNewEnumerableNullableInt3220PercentNulledAverage();
            TestNewEnumerableNullableInt3230PercentNulledAverage();
            TestNewEnumerableNullableInt3240PercentNulledAverage();
            TestNewEnumerableNullableInt3250PercentNulledAverage();
            TestNewEnumerableNullableInt3260PercentNulledAverage();
            TestNewEnumerableNullableInt3270PercentNulledAverage();
            TestNewEnumerableNullableInt3280PercentNulledAverage();
            TestNewEnumerableNullableInt3290PercentNulledAverage();
            TestNewEnumerableInt64IncrementedNullableAverage();
            TestNewEnumerableInt64IncrementedAverage();
            TestNewEnumerableInt64DecrementedNullableAverage();
            TestNewEnumerableInt64DecrementedAverage();
            TestNewEnumerableInt64UpAndDownNullableAverage();
            TestNewEnumerableInt64UpAndDownAverage();
            TestNewEnumerableInt64ShuffledNullableAverage();
            TestNewEnumerableInt64ShuffledAverage();
            TestNewEnumerableInt64SolitaireNullableAverage();
            TestNewEnumerableInt64SolitaireAverage();
            TestNewEnumerableInt64EmptyNullableAverage();
            TestNewEnumerableInt64EmptyAverage();
            TestNewEnumerableNullableInt6410PercentNulledAverage();
            TestNewEnumerableNullableInt6420PercentNulledAverage();
            TestNewEnumerableNullableInt6430PercentNulledAverage();
            TestNewEnumerableNullableInt6440PercentNulledAverage();
            TestNewEnumerableNullableInt6450PercentNulledAverage();
            TestNewEnumerableNullableInt6460PercentNulledAverage();
            TestNewEnumerableNullableInt6470PercentNulledAverage();
            TestNewEnumerableNullableInt6480PercentNulledAverage();
            TestNewEnumerableNullableInt6490PercentNulledAverage();
            TestNewEnumerableSingleIncrementedNullableAverage();
            TestNewEnumerableSingleIncrementedAverage();
            TestNewEnumerableSingleDecrementedNullableAverage();
            TestNewEnumerableSingleDecrementedAverage();
            TestNewEnumerableSingleUpAndDownNullableAverage();
            TestNewEnumerableSingleUpAndDownAverage();
            TestNewEnumerableSingleShuffledNullableAverage();
            TestNewEnumerableSingleShuffledAverage();
            TestNewEnumerableSingleSolitaireNullableAverage();
            TestNewEnumerableSingleSolitaireAverage();
            TestNewEnumerableSingleEmptyNullableAverage();
            TestNewEnumerableSingleEmptyAverage();
            TestNewEnumerableNullableSingle10PercentNulledAverage();
            TestNewEnumerableNullableSingle20PercentNulledAverage();
            TestNewEnumerableNullableSingle30PercentNulledAverage();
            TestNewEnumerableNullableSingle40PercentNulledAverage();
            TestNewEnumerableNullableSingle50PercentNulledAverage();
            TestNewEnumerableNullableSingle60PercentNulledAverage();
            TestNewEnumerableNullableSingle70PercentNulledAverage();
            TestNewEnumerableNullableSingle80PercentNulledAverage();
            TestNewEnumerableNullableSingle90PercentNulledAverage();
            TestNewEnumerableSingle10PercentNaNAverage();
            TestNewEnumerableNullableSingle10PercentNaNOrNullAverage();
            TestNewEnumerableSingle20PercentNaNAverage();
            TestNewEnumerableNullableSingle20PercentNaNOrNullAverage();
            TestNewEnumerableSingle30PercentNaNAverage();
            TestNewEnumerableNullableSingle30PercentNaNOrNullAverage();
            TestNewEnumerableSingle40PercentNaNAverage();
            TestNewEnumerableNullableSingle40PercentNaNOrNullAverage();
            TestNewEnumerableSingle50PercentNaNAverage();
            TestNewEnumerableNullableSingle50PercentNaNOrNullAverage();
            TestNewEnumerableSingle60PercentNaNAverage();
            TestNewEnumerableNullableSingle60PercentNaNOrNullAverage();
            TestNewEnumerableSingle70PercentNaNAverage();
            TestNewEnumerableNullableSingle70PercentNaNOrNullAverage();
            TestNewEnumerableSingle80PercentNaNAverage();
            TestNewEnumerableNullableSingle80PercentNaNOrNullAverage();
            TestNewEnumerableSingle90PercentNaNAverage();
            TestNewEnumerableNullableSingle90PercentNaNOrNullAverage();
            TestNewEnumerableDoubleIncrementedNullableAverage();
            TestNewEnumerableDoubleIncrementedAverage();
            TestNewEnumerableDoubleDecrementedNullableAverage();
            TestNewEnumerableDoubleDecrementedAverage();
            TestNewEnumerableDoubleUpAndDownNullableAverage();
            TestNewEnumerableDoubleUpAndDownAverage();
            TestNewEnumerableDoubleShuffledNullableAverage();
            TestNewEnumerableDoubleShuffledAverage();
            TestNewEnumerableDoubleSolitaireNullableAverage();
            TestNewEnumerableDoubleSolitaireAverage();
            TestNewEnumerableDoubleEmptyNullableAverage();
            TestNewEnumerableDoubleEmptyAverage();
            TestNewEnumerableNullableDouble10PercentNulledAverage();
            TestNewEnumerableNullableDouble20PercentNulledAverage();
            TestNewEnumerableNullableDouble30PercentNulledAverage();
            TestNewEnumerableNullableDouble40PercentNulledAverage();
            TestNewEnumerableNullableDouble50PercentNulledAverage();
            TestNewEnumerableNullableDouble60PercentNulledAverage();
            TestNewEnumerableNullableDouble70PercentNulledAverage();
            TestNewEnumerableNullableDouble80PercentNulledAverage();
            TestNewEnumerableNullableDouble90PercentNulledAverage();
            TestNewEnumerableDouble10PercentNaNAverage();
            TestNewEnumerableNullableDouble10PercentNaNOrNullAverage();
            TestNewEnumerableDouble20PercentNaNAverage();
            TestNewEnumerableNullableDouble20PercentNaNOrNullAverage();
            TestNewEnumerableDouble30PercentNaNAverage();
            TestNewEnumerableNullableDouble30PercentNaNOrNullAverage();
            TestNewEnumerableDouble40PercentNaNAverage();
            TestNewEnumerableNullableDouble40PercentNaNOrNullAverage();
            TestNewEnumerableDouble50PercentNaNAverage();
            TestNewEnumerableNullableDouble50PercentNaNOrNullAverage();
            TestNewEnumerableDouble60PercentNaNAverage();
            TestNewEnumerableNullableDouble60PercentNaNOrNullAverage();
            TestNewEnumerableDouble70PercentNaNAverage();
            TestNewEnumerableNullableDouble70PercentNaNOrNullAverage();
            TestNewEnumerableDouble80PercentNaNAverage();
            TestNewEnumerableNullableDouble80PercentNaNOrNullAverage();
            TestNewEnumerableDouble90PercentNaNAverage();
            TestNewEnumerableNullableDouble90PercentNaNOrNullAverage();
            TestNewEnumerableDecimalIncrementedNullableAverage();
            TestNewEnumerableDecimalIncrementedAverage();
            TestNewEnumerableDecimalDecrementedNullableAverage();
            TestNewEnumerableDecimalDecrementedAverage();
            TestNewEnumerableDecimalUpAndDownNullableAverage();
            TestNewEnumerableDecimalUpAndDownAverage();
            TestNewEnumerableDecimalShuffledNullableAverage();
            TestNewEnumerableDecimalShuffledAverage();
            TestNewEnumerableDecimalSolitaireNullableAverage();
            TestNewEnumerableDecimalSolitaireAverage();
            TestNewEnumerableDecimalEmptyNullableAverage();
            TestNewEnumerableDecimalEmptyAverage();
            TestNewEnumerableNullableDecimal10PercentNulledAverage();
            TestNewEnumerableNullableDecimal20PercentNulledAverage();
            TestNewEnumerableNullableDecimal30PercentNulledAverage();
            TestNewEnumerableNullableDecimal40PercentNulledAverage();
            TestNewEnumerableNullableDecimal50PercentNulledAverage();
            TestNewEnumerableNullableDecimal60PercentNulledAverage();
            TestNewEnumerableNullableDecimal70PercentNulledAverage();
            TestNewEnumerableNullableDecimal80PercentNulledAverage();
            TestNewEnumerableNullableDecimal90PercentNulledAverage();
        }
    }
}