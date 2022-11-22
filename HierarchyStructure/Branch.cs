

namespace HierarchyStructure
{
    public class Branch
    {
        public Branch(List<Branch> branches)
        {
            if (branches.Count == 0)
            {
                throw new InvalidOperationException();
            }

            Branches = branches;
        }

        public Branch() { }
        public List<Branch> Branches { get; set; }

    }
}
