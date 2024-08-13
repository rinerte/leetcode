// Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.

// Each number in candidates may only be used once in the combination.

// Note: The solution set must not contain duplicate combinations.
public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
    var set = candidates.Where(c=>c<=target).OrderBy(i=>i).ToArray();
    IList<IList<int>> list = new List<IList<int>>();
    Backtrack(list, new List<int>(), set, target, 0);
    return list;
}
private void Backtrack(IList<IList<int>> answer,List<int> tempList,int[] candidates,int totalLeft,int index) {
    if (totalLeft < 0) return;
    else if (totalLeft == 0) {
        answer.Add(new List<int>(tempList));
    } else {
        for (int i = index;i < candidates.Length && totalLeft >= candidates[i];i++) {
            if (i > index && candidates[i] == candidates[i - 1]) continue;
            tempList.Add(candidates[i]);
            Backtrack(answer,tempList,candidates,totalLeft - candidates[i],i + 1);
            tempList.RemoveAt(tempList.Count - 1);
        }
    }
}