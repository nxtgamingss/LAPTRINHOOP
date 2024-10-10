using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2th2
{
    internal class Program
    {
        public class Stack
        {
            private int[] data;
            private int top;
            private int capacity;

            public Stack(int n)
            {
                data = new int[n];
                top = -1;
                capacity = n;
            }

            public bool IsEmpty()
            {
                return top == -1;
            }

            public bool IsFull()
            {
                return top == capacity - 1;
            }

            public void Push(int item)
            {
                if (IsFull())
                {
                    Console.WriteLine("Stack Overflow");
                    return;
                }
                top++;
                data[top] = item;
            }

            public int Pop()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack Underflow");
                    return -1; 
                }
                int item = data[top];
                top--;
                return item;
            }
            public void PrintStackUsingFor()
            {
                int[] tempArray = new int[top + 1]; // Tạo mảng tạm có kích thước bằng với số lượng phần tử trong stack
                int j = 0;

                // Copy các phần tử từ stack vào mảng tạm
                for (int i = top; i >= 0; i--)
                {
                    tempArray[j++] = data[i];
                }

                // In ra các phần tử trong mảng tạm
                for (int i = 0; i < tempArray.Length; i++)
                {
                    Console.Write(tempArray[i] + " ");
                }
            }
            static void Main(string[] args)
            {
                Stack myStack = new Stack(5);

               
                myStack.Push(1);
                myStack.Push(2);
                myStack.Push(3);
                myStack.Push(4);
                myStack.PrintStackUsingFor();
               
                //Console.WriteLine(myStack.Pop()); 
                //Console.WriteLine(myStack.IsEmpty());
                //myStack.Push(4);
                //while (!myStack.IsEmpty())
                //{
                //    Console.WriteLine(myStack.Pop());
                //}
                Console.ReadKey();
            }
            
        }
    }
}
