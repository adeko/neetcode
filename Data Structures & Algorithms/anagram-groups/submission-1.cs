public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        foreach (var word in strs) 
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string charsWord = new string(chars);
            if (!map.ContainsKey(charsWord)) 
            {
                map[charsWord] = new List<string>();
            }
            map[charsWord].Add(word);
        }
        return map.Values.ToList<List<string>>();
    }
}
