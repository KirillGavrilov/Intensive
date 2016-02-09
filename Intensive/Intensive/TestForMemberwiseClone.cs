using System.Data;

namespace Intensive
{
    public class TestForMemberwiseClone
    {
        #region Variables

        #endregion

        #region Constructors

        public TestForMemberwiseClone()
        {
        }

        public TestForMemberwiseClone(int count, string name)
            :this()
        {
            Count = count;
            Name = name;
            AbstractClass = new AbstractClass(1, "Test class");
            AbstractStructure = new AbstractStructure(3, "Test struct");
        }

        #endregion

        #region Properties

        public int Count { get; private set; }

        public string Name { get; private set; }

        public AbstractClass AbstractClass { get; private set; }

        public AbstractStructure AbstractStructure { get; private set; }

        #endregion

        #region Public methods

        public TestForMemberwiseClone GetClone()
        {
            return (TestForMemberwiseClone) MemberwiseClone();
        }

        public void Update()
        {
            Name = "Clone name";
            Count *= 2;
            AbstractClass.Count *= 2;
            AbstractClass.Name = "Clone class";
            AbstractStructure.Update();
        }

        #endregion

        #region Protected methods

        #endregion

        #region Private methods

        #endregion   
       
    }
}