using System;

namespace EnumerableTester
{
    public class ExampleReferenceType : IComparable<ExampleReferenceType>
    {
        private readonly int _field;
        public ExampleReferenceType(int field)
        {
            _field = field;
        }
        public int CompareTo(ExampleReferenceType other)
        {
            return _field.CompareTo(other._field);
        }
    }
    public partial class SourceEnumerables
    {
        private static int ConvertToInt32(int num)
        {
            return num;
        }
        private static long ConvertToInt64(int num)
        {
            return num;
        }
        private static float ConvertToSingle(int num)
        {
            return num;
        }
        private static double ConvertToDouble(int num)
        {
            return num;
        }
        private static decimal ConvertToDecimal(int num)
        {
            return num;
        }
        private static string ConvertToString(int num)
        {
            return num.ToString("d4");
        }
        private static DateTime ConvertToDateTime(int num)
        {
            return new DateTime(num + 1, 1, 1).AddDays(num);
        }
        private static ExampleReferenceType ConvertToExampleReferenceType(int num)
        {
            return new ExampleReferenceType(num);
        }
    }
}
