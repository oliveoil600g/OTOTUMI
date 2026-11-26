using R3;

public class CoinModel
{
    public ReactiveProperty<int> Count = new ReactiveProperty<int>(0);

    public void Add(int amount)
    {
        Count.Value += amount;
    }
}
