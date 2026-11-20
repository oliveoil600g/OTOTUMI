using UnityEngine;

public class FallDeath: MonoBehaviour
{
    [SerializeField] private float deathY = -10f;
    [SerializeField] Transform player;

    private PlayerDeath playerDeath;
    private bool hasFallen;

    private void Start()
    {
        playerDeath = GetComponent<PlayerDeath>();
    }
    void Update()
    {
        if (player.transform.position.y<=deathY&&!hasFallen)
        {
            hasFallen = true;
            playerDeath.Die();
            Debug.Log("PlayerDeath");
        }
        //•œŠˆ‚µ‚ÄŽ€–S”»’è‚æ‚èã‚És‚Á‚½‚çÄ”»’è‰Â”\‚É‚·‚é
        if (player.transform.position.y> deathY)
        {
            hasFallen = false;
        }
    }
}
