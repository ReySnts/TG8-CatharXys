public interface IPlayer : ICharacter
{
    public abstract IInput IInput { get; }

    public abstract IWeapon IWeapon { get; }
}