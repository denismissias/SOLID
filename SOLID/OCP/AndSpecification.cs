namespace SOLID.OCP
{
    public class AndSpecification<T> : Specification<T>
    {
        private readonly Specification<T> first;
        private readonly Specification<T> second;

        public AndSpecification(Specification<T> first, Specification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public override bool IsSatisfied(T item)
        {
            return first.IsSatisfied(item) && second.IsSatisfied(item);
        }
    }
}
