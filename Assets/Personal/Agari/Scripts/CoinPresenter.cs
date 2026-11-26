using R3;
using UnityEngine;

public class CoinPresenter : MonoBehaviour
{
    [SerializeField] private CoinView coinView;

    private CoinModel model;

    private void Start()
    {
        model = new CoinModel();
        model.Count.Subscribe(coinView.SetCount);
    }

    public void AddCoin(int amount)
    {
        model.Add(amount);
    }
}
