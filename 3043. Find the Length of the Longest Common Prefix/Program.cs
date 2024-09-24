// You are given two arrays with positive integers arr1 and arr2.

// A prefix of a positive integer is an integer formed by one or more of its digits, starting from its leftmost digit. For example, 123 is a prefix of the integer 12345, while 234 is not.

// A common prefix of two integers a and b is an integer c, such that c is a prefix of both a and b. For example, 5655359 and 56554 have a common prefix 565 while 1223 and 43456 do not have a common prefix.

// You need to find the length of the longest common prefix between all pairs of integers (x, y) such that x belongs to arr1 and y belongs to arr2.

// Return the length of the longest common prefix among all pairs. If no common prefix exists among them, return 0.
// public class Solution {
//     public int LongestCommonPrefix(int[] arr1, int[] arr2) {
//         int length =0;
//         for(int i=0;i<arr1.Length;i++){
//             for(int j=0;j<arr2.Length;j++){
//                 int count = 0;
//                 var first = arr1[i].ToString();
//                 var second = arr2[j].ToString();
//                 int l = first.Length<=second.Length?first.Length:second.Length;
//                 for(int k=0;k<l;k++){
//                     if(first[k]==second[k])count++; else break;
//                 }
//                 if(count>length) length = count;
//             }
//         }
//         return length;
//     }
// }
public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        Trie trie = new Trie();
        foreach(int num in arr1) trie.Insert(num);

        int longestPrefix =0;
        foreach(int num in arr2){
            int len = trie.FindLongestPrefix(num);
            longestPrefix = longestPrefix>len?longestPrefix:len;
        }
        return longestPrefix;
    }
    class TrieNode{
        public TrieNode[] children = new TrieNode[10];
    }
    class Trie{
        TrieNode root = new TrieNode();

        public void Insert(int num){
            TrieNode node = root;
            var numStr = num.ToString();
            foreach(char digit in numStr){
                int idx = digit - '0';
                if(node.children[idx]==null){
                    node.children[idx] = new TrieNode();
                }
                node = node.children[idx];
            }
        }

        public int FindLongestPrefix(int num){
            TrieNode node = root;
            var numStr = num.ToString();
            int len =0;

            foreach(char digit in numStr){
                int idx = digit -'0';
                if(node.children[idx]!=null){
                    len++;
                    node = node.children[idx];
                } else break;
            }
            return len;
        }
    }
}