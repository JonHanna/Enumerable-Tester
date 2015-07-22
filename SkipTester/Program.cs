using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace SkipTester
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Skip While URI");
            TestSkipsWhile(Enumerable.Range(0, 1000).Select(i => new Uri("http://example.net/" + i)));
            Console.WriteLine("Skip While String");
            TestSkipsWhile(Enumerable.Range(0, 1000).Select(i => i.ToString()));
            Console.WriteLine("Skip While Integer");
            TestSkipsWhile(Enumerable.Range(0, 1000));
            Console.WriteLine("Skip While DateTime");
            TestSkipsWhile(Enumerable.Range(0, 1000).Select(i => new DateTime(i + 1, 1, 1)));
            Console.WriteLine("Skip URI");
            TestSkips(Enumerable.Range(0, 1000).Select(i => new Uri("http://example.net/" + i)));
            Console.WriteLine("Skip String");
            TestSkips(Enumerable.Range(0, 1000).Select(i => i.ToString()));
            Console.WriteLine("Skip Integer");
            TestSkips(Enumerable.Range(0, 1000));
            Console.WriteLine("Skip DateTime");
            TestSkips(Enumerable.Range(0, 1000).Select(i => new DateTime(i + 1, 1, 1)));
        }
        private static void AvoidGCInterference()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
        private static void TestSkips<T>(IEnumerable<T> repeater)
        {
            var sources = new IEnumerable<T>[]{ repeater, repeater.ToList(), repeater.ToArray(), repeater.Select(i => i)};
            foreach(var source in sources)
            {
                for(var skip = 0; skip < 1010; skip += 10)
                {
                    AvoidGCInterference();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipOld(source, 10);
                        foreach(var item in skipped)
                        {
                        }
                    }
                    sw.Stop();
                    Console.Write(sw.ElapsedTicks);
                    Console.Write(',');
                    AvoidGCInterference();
                    sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipNew(source, skip);
                        foreach(var item in skipped)
                        {
                        }
                    }
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                    AvoidGCInterference();
                    sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipOld(source, skip);
                        skipped.FirstOrDefault();
                    }
                    sw.Stop();
                    Console.Write(sw.ElapsedTicks);
                    Console.Write(',');
                    AvoidGCInterference();
                    sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipNew(source, skip);
                        skipped.FirstOrDefault();
                    }
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }
            }
        }
        private static void TestSkipsWhile<T>(IEnumerable<T> repeater)
        {
            var sources = new IEnumerable<T>[]{ repeater, repeater.ToList(), repeater.ToArray(), repeater.Select(i => i)};
            foreach(var source in sources)
            {
                for(var skip = 0; skip < 1010; skip += 10)
                {
                    T skipItem = sources[1].ElementAtOrDefault(skip);
                    AvoidGCInterference();
                    var sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipWhileOld(source, (el, ix) => ix < skip);
                        foreach(var item in skipped)
                        {
                        }
                    }
                    sw.Stop();
                    Console.Write(sw.ElapsedTicks);
                    Console.Write(',');
                    AvoidGCInterference();
                    sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipWhile(source, (el, ix) => ix < skip);
                        foreach(var item in skipped)
                        {
                        }
                    }
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                    AvoidGCInterference();
                    sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipWhileOld(source, (el, ix) => ix < skip);
                        skipped.FirstOrDefault();
                    }
                    sw.Stop();
                    Console.Write(sw.ElapsedTicks);
                    Console.Write(',');
                    AvoidGCInterference();
                    sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipWhile(source, (el, ix) => ix < skip);
                        skipped.FirstOrDefault();
                    }
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                    AvoidGCInterference();
                    sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipWhileOld(source, el => !el.Equals(skipItem));
                        foreach(var item in skipped)
                        {
                        }
                    }
                    sw.Stop();
                    Console.Write(sw.ElapsedTicks);
                    Console.Write(',');
                    AvoidGCInterference();
                    sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipWhile(source, el => !el.Equals(skipItem));
                        foreach(var item in skipped)
                        {
                        }
                    }
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                    AvoidGCInterference();
                    sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipWhileOld(source, el => !el.Equals(skipItem));
                        skipped.FirstOrDefault();
                    }
                    sw.Stop();
                    Console.Write(sw.ElapsedTicks);
                    Console.Write(',');
                    AvoidGCInterference();
                    sw = Stopwatch.StartNew();
                    for(var i = 0; i != 1000; ++i)
                    {
                        var skipped = SkipWhile(source, el => !el.Equals(skipItem));
                        skipped.FirstOrDefault();
                    }
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedTicks);
                }
            }
        }

        public static IEnumerable<TSource> SkipOld<TSource>(IEnumerable<TSource> source, int count)
        {
            if (source == null) throw Error.ArgumentNull("source");
            return SkipIteratorOld<TSource>(source, count);
        }

        private static IEnumerable<TSource> SkipIteratorOld<TSource>(IEnumerable<TSource> source, int count)
        {
            using (IEnumerator<TSource> e = source.GetEnumerator())
            {
                while (count > 0 && e.MoveNext()) count--;
                if (count <= 0)
                {
                    while (e.MoveNext()) yield return e.Current;
                }
            }
        }

        // Just in case somebody does something weird with the ordering of enumerator
        // disposal, this wraps an enumerator that has been used, but not disposed,
        // and disposes it when this is.
        // If an exception had been found while skipping, this
        // throws it on MoveNext.
        private sealed class DeadEnumeratorWrapper<TSource> : IEnumerator<TSource>
        {
            private readonly IEnumerator<TSource> _corpse;
            private ExceptionDispatchInfo _exception;

            internal DeadEnumeratorWrapper(IEnumerator<TSource> corpse)
                : this(corpse, null)
            {
            }

            internal DeadEnumeratorWrapper(IEnumerator<TSource> corpse, ExceptionDispatchInfo exception)
            {
                _corpse = corpse;
                _exception = exception;
            }

            public TSource Current
            {
                get { return default(TSource); }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public bool MoveNext()
            {
                if(_exception != null)
                {
                    ExceptionDispatchInfo ex = _exception;
                    _exception = null;
                    ex.Throw();
                }
                return false;
            }

            public void Dispose()
            {
                _corpse.Dispose();
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }
        }

        public static IEnumerable<TSource> SkipNew<TSource>(IEnumerable<TSource> source, int count)
        {
            if (source == null) throw Error.ArgumentNull("source");
            return new SkipIterator<TSource>(source, count);
        }

        private sealed class SkipIterator<TSource> : IEnumerable<TSource>
        {
            private readonly IEnumerable<TSource> _source;
            private readonly int _count;

            public SkipIterator(IEnumerable<TSource> source, int count)
            {
                _source = source;
                _count = count > 0 ? count : 0;
            }

            public IEnumerator<TSource> GetEnumerator()
            {
                IEnumerator<TSource> sourceEnumerator = _source.GetEnumerator();
                try
                {
                    for (int count = _count; count != 0; --count)
                    {
                        // It should be harmless to have the recipient call MoveNext again.
                        // but we guard against strange behaviour from shortcuts in the enumerator
                        // It should also be harmless to dispose the enumerator here if we've
                        // exhausted it, but we guard against strange behaviour in either the
                        // enumerator or the caller.
                        if (!sourceEnumerator.MoveNext()) return new DeadEnumeratorWrapper<TSource>(sourceEnumerator);
                    }
                    return sourceEnumerator;
                }
                catch(Exception ex)
                {
                    // Force the exception to happen on a MovedNext from the caller, rather than
                    // here.
                    return new DeadEnumeratorWrapper<TSource>(sourceEnumerator, ExceptionDispatchInfo.Capture(ex));
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        public static IEnumerable<TSource> SkipWhile<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null) throw Error.ArgumentNull("source");
            if (predicate == null) throw Error.ArgumentNull("predicate");
            return new SkipWhileIterator<TSource>(source, predicate);
        }

        public static IEnumerable<TSource> SkipWhile<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            if (source == null) throw Error.ArgumentNull("source");
            if (predicate == null) throw Error.ArgumentNull("predicate");
            return new SkipWhileWithIndexIterator<TSource>(source, predicate);
        }

        public static IEnumerable<TSource> SkipWhileOld<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            if (source == null) throw Error.ArgumentNull("source");
            if (predicate == null) throw Error.ArgumentNull("predicate");
            return SkipWhileIteratorOld<TSource>(source, predicate);
        }

        private static IEnumerable<TSource> SkipWhileIteratorOld<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
        {
            int index = -1;
            bool yielding = false;
            foreach (TSource element in source)
            {
                checked { index++; }
                if (!yielding && !predicate(element, index)) yielding = true;
                if (yielding) yield return element;
            }
        }

        public static IEnumerable<TSource> SkipWhileOld<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null) throw Error.ArgumentNull("source");
            if (predicate == null) throw Error.ArgumentNull("predicate");
            return SkipWhileIteratorOld<TSource>(source, predicate);
        }

        private static IEnumerable<TSource> SkipWhileIteratorOld<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            bool yielding = false;
            foreach (TSource element in source)
            {
                if (!yielding && !predicate(element)) yielding = true;
                if (yielding) yield return element;
            }
        }

        private sealed class SkipWhileIterator<TSource> : IEnumerable<TSource>, IEnumerator<TSource>
        {
            private readonly IEnumerable<TSource> _source;
            private readonly Func<TSource, bool> _predicate;
            private readonly int _threadId = Environment.CurrentManagedThreadId;
            private IEnumerator<TSource> _enumerator;
            private int _state;
            private TSource _current;

            internal SkipWhileIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
            {
                _source = source;
                _predicate = predicate;
            }
            public IEnumerator<TSource> GetEnumerator()
            {
                // Don't short-circuit. These are almost always both true, so don't "save"
                // time by branching after a very likely case.
                var ret = _state == 0 & _threadId == Environment.CurrentManagedThreadId
                    ? this : new SkipWhileIterator<TSource>(_source, _predicate);
                ret._state = 1;
                return ret;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
            public TSource Current
            {
                get { return _current; }
            }
            object IEnumerator.Current
            {
                get { return _current; }
            }
            public bool MoveNext()
            {
                switch (_state)
                {
                    case 1:
                        _enumerator = _source.GetEnumerator();
                        while (_enumerator.MoveNext())
                        {
                            TSource item = _enumerator.Current;
                            if (!_predicate(item))
                            {
                                _current = item;
                                _state = 2;
                                return true;
                            }
                        }
                        break;
                    case 2:
                        if (_enumerator.MoveNext())
                        {
                            _current  = _enumerator.Current;
                            return true;
                        }
                        break;
                }
                _state = -1;
                return false;
            }
            public void Dispose()
            {
                if (_enumerator != null) _enumerator.Dispose();
                _enumerator = null;
            }
            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }
        }
        private sealed class SkipWhileWithIndexIterator<TSource> : IEnumerable<TSource>, IEnumerator<TSource>
        {
            private readonly IEnumerable<TSource> _source;
            private readonly Func<TSource, int, bool> _predicate;
            private readonly int _threadId = Environment.CurrentManagedThreadId;
            private IEnumerator<TSource> _enumerator;
            private int _state;
            private TSource _current;

            public SkipWhileWithIndexIterator(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
            {
                _source = source;
                _predicate = predicate;
            }
            public IEnumerator<TSource> GetEnumerator()
            {
                // Don't short-circuit. These are almost always both true, so don't "save"
                // time by branching after a very likely case.
                var ret = _state == 0 & _threadId == Environment.CurrentManagedThreadId
                    ? this : new SkipWhileWithIndexIterator<TSource>(_source, _predicate);
                ret._state = 1;
                return ret;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
            public TSource Current
            {
                get { return _current; }
            }
            object IEnumerator.Current
            {
                get { return _current; }
            }
            public bool MoveNext()
            {
                switch (_state)
                {
                    case 1:
                        _enumerator = _source.GetEnumerator();
                        int index = -1;
                        while (_enumerator.MoveNext())
                        {
                            TSource item = _enumerator.Current;
                            if (!_predicate(item, checked(++index)))
                            {
                                _current = item;
                                _state = 2;
                                return true;
                            }
                        }
                        break;
                    case 2:
                        if (_enumerator.MoveNext())
                        {
                            _current  = _enumerator.Current;
                            return true;
                        }
                        break;
                }
                _state = -1;
                return false;
            }
            public void Dispose()
            {
                if (_enumerator != null) _enumerator.Dispose();
                _enumerator = null;
            }
            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
    internal static class Error
    {
        public static ArgumentNullException ArgumentNull(string paramName)
        {
            return new ArgumentNullException(paramName);
        }
    }
}