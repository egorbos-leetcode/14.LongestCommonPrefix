namespace Solution;

public static class Solution
{
    public static string LongestCommonPrefix(string[] strs) {
        var result = new List<char>();
        var flag = true;
        var charIdx = 0;
        while (flag)
        {
            for (var strIdx = 0; strIdx < strs.Length; strIdx++)
            {
                var current = strs[strIdx];

                if (current.Length == charIdx)
                {
                    if (strIdx > 0)
                    {
                        result.RemoveAt(charIdx);
                    }
                    flag = false;
                    break;
                }
                else if (result.Count == charIdx)
                {
                    result.Add(current[charIdx]);
                }
                else if (result[charIdx] != current[charIdx])
                {
                    result.RemoveAt(charIdx);
                    flag = false;
                    break;
                }
            }
            charIdx++;
        }
        return string.Join(string.Empty, result);
    }
}