using System;

namespace SortingAlgorithms
{
    public abstract class Sortmetrics<T> : ISorting<T>
        where T : IComparable
    {
        public T[] sort(T[] data)
        {
            throw new NotImplementedException();
        }
    }
}