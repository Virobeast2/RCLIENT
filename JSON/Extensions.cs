namespace JSON
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public static class Extensions
    {
        public static T Pop<T>(this List<T> list)
        {
            T local = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return local;
        }
    }
}

