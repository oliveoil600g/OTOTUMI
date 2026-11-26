using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private CoinPresenter coinPresenter;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            coinPresenter.AddCoin(1);
            Destroy(gameObject);
        }
    }
}
