namespace ConsoleApp6
{
    interface IMonoid<T>
    {
        T Mempty { get; }
        T Mappend(T other);
    }
}
