ListNode test = new(4,new ListNode(2,new ListNode(4,new ListNode(1))));
Console.WriteLine(string.Join(" ",NodesBetweenCriticalPoints(test)));


int[] NodesBetweenCriticalPoints(ListNode head) {
    List<int> cPoints = new();
    int index = 0;
    int prev = (int)head?.val;
    while(head!=null){
        if(head.next!=null && index>0 && (prev<head.val && head.next?.val < head.val) || (prev>head.val && head.next?.val >head.val))
        {
            cPoints.Add(index);
        };
        index++;
        prev = head.val;
        head = head.next;

    }
    foreach(int point in cPoints) Console.WriteLine(point);
    if(cPoints.Count()<=1) return new[]{-1,-1};
    int max = cPoints[^1]-cPoints[0], min = int.MaxValue;
    for(int i=1;i<cPoints.Count();i++){
        if(cPoints[i]-cPoints[i-1]<min) min = cPoints[i]-cPoints[i-1];
    }
    return new int[]{min,max};
}

class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}