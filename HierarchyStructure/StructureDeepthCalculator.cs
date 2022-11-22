namespace HierarchyStructure
{
    public class StructureDeepthCalculator : IStructureDeepthCalculator
    {
        public int GetDepth(List<Branch> branches, int depth = 1)
        {
            if (branches == null)
                return depth;

            depth++;

            var result = branches.Select(branch => GetDepth(branch.Branches, depth)).ToList();

            return result.Max();
        }
    }
}
