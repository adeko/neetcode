public class Solution {
    public bool IsPalindrome(string s) {
        int idxLeft = 0;
        int idxRight = s.Length - 1;

        while(idxLeft < idxRight)
        {
            while (idxLeft < idxRight && !IsValid(s[idxLeft]))
            {
                idxLeft++;

            }
            while (idxRight > idxLeft && !IsValid(s[idxRight]))
            {
                idxRight--;                
            }
            if (char.ToLower(s[idxLeft]) != char.ToLower(s[idxRight]))
            {
                return false;
            }
            idxLeft++;
            idxRight--;
        }
        return true;
    }

    bool IsValid(char c) => 
        c >= 'a' && c <= 'z' ||
        c >= 'A' && c <= 'Z' ||
        c >= '0' && c <= '9' ;
}
