using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Session_01
{
    internal class Range<T> where T : IComparable<T> , INumber<T>
    {
        #region Properties
        public T Max { get; }

        public T Min { get; }

        #endregion

        #region Constructors
        public Range(T min, T max) {
            Max = max;
            Min = min;
        }

        #endregion

        #region Methods
        public bool IsInRange(T value) 
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public T Length()
        {
            return Max - Min;
        }

        #endregion
    }

}
