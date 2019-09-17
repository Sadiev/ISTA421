namespace ConsoleApp6
{
    class IntegerAddition : IMonoid<IntegerAddition>
    {
        private IntegerAddition(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public IntegerAddition Mempty => Pack(0);

        public IntegerAddition Mappend(IntegerAddition other)
            => Pack(Value + other.Value);

        public static IntegerAddition Pack(int i)
            => new IntegerAddition(i);
    }
}
