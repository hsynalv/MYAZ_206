using System;

namespace LinkedListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var node1 = new SinglyLinkedListNode<char>('a');
            var node2 = new SinglyLinkedListNode<char>('c');
            var node3 = new SinglyLinkedListNode<char>('b');
            var node4 = new SinglyLinkedListNode<char>('d');

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            SinglyLinkedListNode<char>.AddFirst('z', ref node1);
            SinglyLinkedListNode<char>.AddLast('T', node1);

            SinglyLinkedListNode<char>.Traverse(node1);
        }
    }

    public class SinglyLinkedListNode<T>
    {
        public T Value { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }

        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }

        public static void Traverse<T>(SinglyLinkedListNode<T> Head)
        {
            if (Head is null) 
                throw new ArgumentNullException(nameof(Head));


            var current = Head;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Next;
            }
        }

        public static void AddFirst<T>(T value, ref SinglyLinkedListNode<T> Head)
        {
            if (Head is null) 
                throw new ArgumentNullException(nameof(Head));

            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public static void AddLast<T>(T value, SinglyLinkedListNode<T> Head)
        {
            if (Head is null)
                throw new ArgumentNullException(nameof(Head));

            var newNode = new SinglyLinkedListNode<T>(value);
            while (Head.Next != null)
            {
                Head = Head.Next;
            }
            Head.Next = newNode;
        }

        public override string ToString() => $"{Value}";
    }
}