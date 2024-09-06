public interface IFactory<TParam>
{
    public abstract IProduct<TParam> GetProduct(TParam parameter);
}