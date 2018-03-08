using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Extensions
{
    public static class CollectionExtensions
    {
        public static void AddRange<T>(this ICollection<T> self, IEnumerable<T> collection)
        {
            if (self == null)
                throw new ArgumentNullException(nameof(self));

            foreach (var item in collection)
            {
                self.Add(item);
            }
        }
    }
}