using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] CheckPointManager checkPointManager;
    [SerializeField] Transform player;
    private Rigidbody rb;
    private void Start()
    {
        rb =player.GetComponent<Rigidbody>();
    }
    public void Die()
    {
        // 速度をリセット
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        //プレイヤーを移動
        player.transform.position = checkPointManager.checkPoint; 
        player.rotation = Quaternion.identity;
    }
}
