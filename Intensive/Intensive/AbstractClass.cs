namespace Intensive
{
    public class AbstractClass
    {
        #region Variables

        #endregion

        #region Constructors

        public AbstractClass()
        {
        }

        public AbstractClass(int count, string name)
            : this()
        {
            Count = count;
            Name = name;
        }

        #endregion

        #region Properties

        public int Count { get; set; }

        public string Name { get; set; }

        #endregion

        #region Public methods

        #endregion

        #region Protected methods

        #endregion

        #region Private methods

        #endregion   
    }
}