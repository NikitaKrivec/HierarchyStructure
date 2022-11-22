using HierarchyStructure;


var calculator = new StructureDeepthCalculator();

var structure = new Branch 
{
    Branches = new List<Branch> 
    { new Branch(new List<Branch> { new Branch() }),
        new Branch(new List<Branch> { new Branch(new List<Branch> { new Branch(new List<Branch> { new Branch() }) }),
            new Branch(new List<Branch> { new Branch(new List<Branch> { new Branch() }), new Branch() }),
            new Branch() }),new Branch(new List<Branch> { new Branch() }) }
};

var result = calculator.GetDepth(structure.Branches);
Console.WriteLine($"The depth of this structure is: {result}");