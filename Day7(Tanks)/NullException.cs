using System;


namespace Day7_Tanks_
{
    class NullException : Exception
    {
        public NullException() : base("Name could not be null or space") { }
    }
}
