namespace ConsoleApp6
{
    class IntegerMultiplication : IMonoid<IntegerMultiplication>
    {
        private IntegerMultiplication(int value)
        { 
            Value = value;
        }

        public int Value { get; }

        public IntegerMultiplication Mempty => Pack(1);

        public IntegerMultiplication Mappend(IntegerMultiplication other)
            => Pack(Value * other.Value);

        public static IntegerMultiplication Pack(int i)
            => new IntegerMultiplication(i);
    }
}
