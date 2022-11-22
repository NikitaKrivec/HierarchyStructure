using FluentAssertions;
using HierarchyStructure;

namespace HierarchyStructureTests
{
    [TestClass]
    public class HierarchyStructureTests
    {
        private List<Branch> _branches;
        private IStructureDeepthCalculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            _calculator = new StructureDeepthCalculator();
            _branches = new List<Branch>();
        }

        [TestMethod]
        public void HierarchyStructureTests_AddOneBranch_ShouldBeOneBranch()
        {
            //Act
            _branches.Add(new Branch());

            //Assert
            _branches.Count().Should().Be(1);
        }

        [TestMethod]
        public void HierarchyStructureTests_AddFourBranches_ShouldBeFourBranches()
        {
            //Arrange
            _branches = new List<Branch> { new Branch(new List<Branch> { new Branch(new List<Branch> { new Branch ()}) })};

            //Act
            int depth = _calculator.GetDepth(_branches);

            //Assert
            depth.Should().Be(4);
        }

        [TestMethod]
        public void HierarchyStructureTests_InvalidDepth_ThrowInvalidOperationException()
        {
            //Act
            Action act = () => _calculator.GetDepth(new List<Branch>());
            act.Should().Throw<InvalidOperationException>().WithMessage("Sequence contains no elements");
        }
    }
}