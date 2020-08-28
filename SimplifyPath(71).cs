public class Solution {
    public string SimplifyPath(string path) {
        
        if(path == "")
            return "/";
        
        string[] p = path.Split('/');
        Stack<string> stack = new Stack<string>();
        
        for(int i = 0; i < p.Length; i++)
        {
            if(p[i] == "" || p[i] == ".")
                continue;
            else if(p[i] == "..")
            {
                if(stack.Count > 0)
                {
                    stack.Pop();
                    continue;
                }
            }
            else
                stack.Push(p[i]);
        }
        
        StringBuilder sb = new StringBuilder();
        while(stack.Count > 0)
        {
            sb.Insert(0, "/" + stack.Pop());
        }
        
        return sb.Length == 0? "/" : sb.ToString();
    }
}