impl Solution {
    pub fn has_duplicate(nums: Vec<i32>) -> bool {
        let mut hs = HashSet::new();
        nums.iter().any(|&n| !hs.insert(n))
    }
}
