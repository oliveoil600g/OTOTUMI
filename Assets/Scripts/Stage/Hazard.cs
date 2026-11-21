using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField] private PlayerDeath playerDeath;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerDeath.Die();
        }
    }
}
