namespace Intensive
{
    public struct AbstractStructure
    {

        public AbstractStructure(int count, string name)
        {
            Count = count;
            Name = name;
        }

        public int Count;

        public string Name;

        public void Update()
        {
            Count *= 2;
            Name = "Clone struct";
        }
    }
}