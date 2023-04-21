public class Solution {
    public int LongestPalindrome(string s) {
        int[] charCounts = new int[128]; // array to store the counts of each character in the input string
        int maxLength = 0;
        bool hasOddCount = false; // flag to indicate if there is a character with an odd count
        foreach (char c in s) {
            charCounts[c]++; // increment the count of the current character
        }
        foreach (int count in charCounts) {
            maxLength += count / 2 * 2; // add the even count of the current character to the maximum length
            if (count % 2 == 1) { // if the count of the current character is odd
                hasOddCount = true; // set the odd count flag to true
            }
        }
        if (hasOddCount) { // if there is a character with an odd count
            maxLength++; // add one to the maximum length
        }
        return maxLength;
    }
}