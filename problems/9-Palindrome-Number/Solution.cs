public class Solution {
    public bool IsPalindrome(int x) {
        string str = x.ToString();
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars) == x.ToString();
    }
}
