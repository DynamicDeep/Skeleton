using System;

namespace Testing2.Testing2
{
    internal class Gender
    {
        public static implicit operator string(Gender v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Gender(string v)
        {
            throw new NotImplementedException();
        }
    }
}