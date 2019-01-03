/* FloatingPtDivisionException.cs
 * A custom exception class designed
 * to be thrown when division is 
 * attempted with a floating point
 * value is zero.

 */
using System;

namespace CustomException
{
    class FloatingPtDivisionException : ApplicationException
    {
        public FloatingPtDivisionException(string exceptionType)
            : base(exceptionType)
        {
        }
    }
}