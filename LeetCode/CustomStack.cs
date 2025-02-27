using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode
{
    public class CustomStack
    {

        private int[] stackArray;
        int top = -1;
        int size = 0;

        public CustomStack(int maxSize)
        {
            stackArray = new int[maxSize];
            size = maxSize;
        }

        public void Push(int x)
        {
            if (CheckIfStachIsFull()) {
                Console.WriteLine("Stck is full");
            }
            else
            {                
                stackArray[++top] = x;
                Console.WriteLine($"Pushed {x} onto the stack.");
               
            }
           
        }

        public int Pop()
        {
            if(top == -1) {
                Console.WriteLine("Stck is empty");
                return -1;
            }
            else
            {
            return stackArray[top];
            }
            
        }

        public void Increment(int k, int val)
        {
            int limit = Math.Min(k, top + 1);
           
            for (int i = 0; i < limit; i++)
            {
              stackArray[i] = stackArray[i] +val;
                
            }
        }

        public bool CheckIfStachIsFull()
        {
            if (top == size - 1) 
            {
                return true;
            }
            return false;
    }

    }

   

    }
    

//1381.Design a Stack With Increment Operation
    //Medium
    //Topics
    //Companies
    //Hint

    //Design a stack that supports increment operations on its elements.

    //Implement the CustomStack class:

    //    CustomStack(int maxSize) Initializes the object with maxSize which is the maximum number of elements in the stack.
    //    void push(int x) Adds x to the top of the stack if the stack has not reached the maxSize.
    //    int pop() Pops and returns the top of the stack or -1 if the stack is empty.
    //    void inc(int k, int val) Increments the bottom k elements of the stack by val.If there are less than k elements in the stack, increment all the elements in the stack.



    //Example 1:

    //Input
    //["CustomStack", "push", "push", "pop", "push", "push", "push", "increment", "increment", "pop", "pop", "pop", "pop"]
    //[[3], [1], [2], [], [2], [3], [4], [5, 100], [2, 100], [], [], [], []]
    //Output
    //[null, null, null, 2, null, null, null, null, null, 103, 202, 201, -1]
    //Explanation
    //CustomStack stk = new CustomStack(3); // Stack is Empty []
    //stk.push(1);                          // stack becomes [1]
    //stk.push(2);                          // stack becomes [1, 2]
    //stk.pop();                            // return 2 --> Return top of the stack 2, stack becomes [1]
    //stk.push(2);                          // stack becomes [1, 2]
    //stk.push(3);                          // stack becomes [1, 2, 3]
    //stk.push(4);                          // stack still [1, 2, 3], Do not add another elements as size is 4
    //stk.increment(5, 100);                // stack becomes [101, 102, 103]
    //stk.increment(2, 100);                // stack becomes [201, 202, 103]
    //stk.pop();                            // return 103 --> Return top of the stack 103, stack becomes [201, 202]
    //stk.pop();                            // return 202 --> Return top of the stack 202, stack becomes [201]
    //stk.pop();                            // return 201 --> Return top of the stack 201, stack becomes []
    //stk.pop();                            // return -1 --> Stack is empty return -1.



    //Constraints:

    //1 <= maxSize, x, k <= 1000
    //    0 <= val <= 100
    //    At most 1000 calls will be made to each method of increment, push and pop each separately.


    //https://leetcode.com/problems/design-a-stack-with-increment-operation/description/?envType=daily-question&envId=2024-09-30