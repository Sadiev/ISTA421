namespace ConsoleApp6
{
    class StringMonoid : IMonoid<StringMonoid>
    {
        private StringMonoid(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public StringMonoid Mempty => Pack("");

        public StringMonoid Mappend(StringMonoid other)
            => Pack(Value + other.Value);

        public static StringMonoid Pack(string s)
            => new StringMonoid(s);
    }
}
