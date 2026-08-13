public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = [];
        foreach(var c in s)
        {
            switch (c)
            {
                case '[': 
                    stack.Push(']'); 
                    break;
                case '{': 
                    stack.Push('}'); 
                    break;
                case '(': 
                    stack.Push(')'); 
                    break;                
                case ']': 
                case '}': 
                case ')':
                    if (stack.Count == 0 || stack.Pop() != c) { 
                        return false; 
                    }
                    break;                
                default: 
                    continue;
            }
        }
        return stack.Count == 0;
    }
}
