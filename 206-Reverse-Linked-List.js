function ListNode(val, next) {
  this.val = (val === undefined ? 0 : val)
  this.next = (next === undefined ? null : next)
}

var reverseList = function (head) {
  let curr = head, prev = null

  while (curr) {
    const next = curr.next
    curr.next = prev
    prev = curr
    curr = next
  }

  return prev
};