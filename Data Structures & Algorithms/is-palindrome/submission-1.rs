impl Solution {
    pub fn is_palindrome(s: String) -> bool {
        let mut chars = s.char_indices();
        let mut front = chars.next();
        let mut back = chars.next_back();

        while let (Some((i,f)), Some((j,b))) = (front, back) {
            if i >= j { break; }
            if !f.is_alphanumeric() {
                front = chars.next();
                continue;
            }
            if !b.is_alphanumeric() {
                back = chars.next_back();
                continue;
            }
            if f.to_ascii_lowercase() != b.to_ascii_lowercase() {
                return false;
            }
            front = chars.next();
            back = chars.next_back();
        }
        
        true
    }
}
