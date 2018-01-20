public interface GameNumber<T> : GameModel<T>
{
    T GetMin();
    T GetMax();
    void Plus(T value);
    void Minus(T value);
    void Multiply(T value);
    void Divide(T value);
}