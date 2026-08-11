impl Solution {
    pub fn is_anagram(s: String, t: String) -> bool {
        if s.len() != t.len() { return false; }

        let length = 26;
        let mut counter = vec![0;length];

        for (s_byte, t_byte) in s.bytes().zip(t.bytes()) {
            counter[(s_byte - b'a') as usize] += 1;
            counter[(t_byte - b'a') as usize] -= 1;
        }

        counter.iter().all(|&c| c == 0)
    }
}
