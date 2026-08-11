public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var length = 26;
        var counter = new int[length];

        for (int i = 0; i < s.Length; i++)
        {
            counter[s[i] - 'a']++;
            counter[t[i] - 'a']--;
        }

        for (int i = 0; i < length; i++) 
            if (counter[i] != 0) return false;

        return true;
    }
}
