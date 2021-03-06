using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructers.LinkedList.Doubly
{
    public class DbNode<T>
    {
        public T Value { get; set; }
        public DbNode<T> Prev { get; set; }
        public DbNode<T> Next { get; set; }

        public DbNode(T item)
        {
            Value = item;
        }

        public override string ToString() => $"{Value}";
    }
}
