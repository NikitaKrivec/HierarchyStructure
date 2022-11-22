namespace HierarchyStructure
{
    public interface IStructureDeepthCalculator
    {
        int GetDepth(List<Branch> branches, int depth = 1);
    }
}