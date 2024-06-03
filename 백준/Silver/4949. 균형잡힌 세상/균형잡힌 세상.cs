using System;

namespace Solution {
    class Program {
        static void Main(string[] args) {
            while(true) {
                var str = Console.ReadLine();
            
                if(str.Length == 1) {
                    if(str[0] == '.') break;
                }
            
                var stk = new Stack<char>();
                bool isValid = true;
            
                foreach(var c in str) {
                    if(c == '(' || c == '[') {
                        stk.Push(c);
                    }
                
                    if(c == ')') {
                        if(stk.Count == 0 || stk.Peek() == '[') {
                            isValid = false;
                            break;
                        }
                        stk.Pop();
                    }
                    if(c == ']') {
                        if(stk.Count == 0 || stk.Peek() == '(') {
                            isValid = false;
                            break;
                        }
                        stk.Pop();
                    }
                }
            
                if(stk.Count == 0 && isValid) {
                    Console.WriteLine("yes");
                } else {
                    Console.WriteLine("no");
                }
            }
        }
    }
}