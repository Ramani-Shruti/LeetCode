class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        HashMap<Integer,Integer> map = new HashMap<>();
        for(int i : nums)
        {
            map.put(i,map.getOrDefault(i,0)+1);
        }
        List<Integer>[] bucket = new List[nums.length+1];
        for(int key : map.keySet())
        {
            int f = map.get(key);
            if(bucket[f] == null)
                bucket[f] = new ArrayList<>();
            bucket[f].add(key);
        }
        // top k frequent number
        int[] result = new int[k];
        int index = 0;
        for(int i = bucket.length-1;i>=1 && index < k;i--)
        {
            if(bucket[i] !=null)
            {
                for(int num : bucket[i])
                {
                    result[index] = num;
                    index++;
                    if(index==k)
                    {
                        break;
                    }
                }
            }
        }
        return result;
    }
}