// Definition for singly-linked list.
// #[derive(PartialEq, Eq, Clone, Debug)]
// pub struct ListNode {
//     pub val: i32,
//     pub next: Option<Box<ListNode>>,
// }
//
// impl ListNode {
//     #[inline]
//     pub fn new(val: i32) -> Self {
//         ListNode { next: None, val }
//     }
// }

impl Solution {
    pub fn merge_two_lists(mut list1: Option<Box<ListNode>>, mut list2: Option<Box<ListNode>>) -> Option<Box<ListNode>> {
        let mut list3 = ListNode::new(0);
        let mut current = &mut list3;
        while let (Some(l1), Some(l2)) = (list1.as_mut(), list2.as_mut()) {
            if l1.val <= l2.val {
                let next = l1.next.take();
                current.next = list1;
                list1 = next;
            } else {
                let next = l2.next.take();
                current.next = list2;
                list2 = next;
            }
            current = current.next.as_mut().unwrap();
        }
        current.next = list1.or(list2);
        list3.next
    }
}
