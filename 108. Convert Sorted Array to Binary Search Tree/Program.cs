// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public TreeNode SortedArrayToBST(int[] nums) {
    return Branch(nums,0,nums.Length-1);
}

public static TreeNode Branch(int[] nums, int start, int end)
{
    if(start==end) 
        return new TreeNode(nums[end]);

    int mid = start + (end - start) / 2;
    return new TreeNode(nums[mid], mid==start?null:Branch(nums,start,mid-1), Branch(nums, mid+1,end));
}
