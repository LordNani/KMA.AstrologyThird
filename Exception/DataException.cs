using System;


namespace CSharp_lab2.DataException
{
  class AgeExceededException : ArgumentException
  {
    public int Value { get; }
    public AgeExceededException(string message, int val)
      : base(message)
    {
      Value = val;
    }
  }
  // FOR EMAIL THERE IS FORMAT EXCEPTION, CHECK DATAPROCESSOR
  class AgeFutureException : Exception
  {
    public AgeFutureException(string message)
      : base(message)
    {}
  }

}
