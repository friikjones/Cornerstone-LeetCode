/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public var val: Int
 *     public var left: TreeNode?
 *     public var right: TreeNode?
 *     public init(_ val: Int) {
 *         self.val = val
 *         self.left = nil
 *         self.right = nil
 *     }
 * }
 */
class Solution {
    var array = [Int]()
    func preorderTraversal(_ root: TreeNode?) -> [Int] {
        if let value = root?.val {
            array.append(value)
            preorderTraversal(root?.left)
            preorderTraversal(root?.right)
        }
        return array
    }
}