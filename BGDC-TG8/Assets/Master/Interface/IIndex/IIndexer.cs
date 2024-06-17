public interface IIndexer<TReturn, TParam>
{
    public abstract TReturn IndexOf(TParam parameter);
}