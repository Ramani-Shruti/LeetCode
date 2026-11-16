class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
       
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
       return new ArrayList<>(map.values());

    }
}