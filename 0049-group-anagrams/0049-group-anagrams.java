class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        List<List<String>> result = new ArrayList<>();
        HashMap<String,List<String>> map = new HashMap<>();
        for(int i =0;i<strs.length;i++)
        {
            int[] count = new int[26];

            for(int k=0;k<strs[i].length();k++)
            {
                count[strs[i].charAt(k) - 'a']++;
            }
            String key = Arrays.toString(count);
            map.computeIfAbsent(key, k -> new ArrayList<>()).add(strs[i]);
        }
        result.addAll(map.values());
        return result;

    }
}