Console.WriteLine("Hello, Two Sum!");
var t = TwoSum(new int[]{2,7,11,15},9);
Console.WriteLine("{0}:{1}",t[0],t[1]);

static int[] TwoSum(int[] nums, int target) {
    
    int[] answer = new int[0]{};
    Dictionary<int,int> indexes = new(); 

    for(int i=0;i<nums.Length;i++){
        if(indexes.ContainsKey(target-nums[i]) && indexes[target-nums[i]]!=i){
            answer = new int[]{i,indexes[target-nums[i]]};
            break;
        }
        indexes[nums[i]] = i;
    }

    return answer;
}
