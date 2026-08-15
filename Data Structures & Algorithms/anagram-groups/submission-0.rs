impl Solution {
    pub fn group_anagrams(strs: Vec<String>) -> Vec<Vec<String>> {
        let mut map: HashMap<String, Vec<String>> = HashMap::new();
        for word in strs {
            let mut chars: Vec<char> = word.chars().collect();
            chars.sort_unstable();
            let key: String = chars.into_iter().collect();
            map.entry(key).or_default().push(word);
        }
        map.into_values().collect()
    }
}
