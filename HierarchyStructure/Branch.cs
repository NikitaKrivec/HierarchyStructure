

namespace HierarchyStructure
{
    public class Branch
    {
        public List<Branch> Branches { get; set; }
        public Branch() { }

        public Branch(List<Branch> branches)
        {
            if (branches.Count == 0)
            {
                throw new InvalidOperationException();
            }

            Branches = branches;
        }
    }
}
