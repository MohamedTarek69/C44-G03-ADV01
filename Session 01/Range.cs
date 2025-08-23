using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01
{
    internal class Range<T> where T : IComparable<T>
    {
        #region Properties
        public T Max { get; }

        public T Min { get; }

        #endregion

        #region Constructors
        public Range(T max, T min) {
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
            dynamic max = Max;
            dynamic min = Min;
            return max - min;
        }

        #endregion
    }

}
