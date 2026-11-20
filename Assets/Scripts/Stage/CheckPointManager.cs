using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public Vector2 checkPoint;
    [SerializeField] private GameObject player;
    void Start()
    {
        checkPoint = player.transform.position;
    }
    public void SetCheckPointPosition(Transform target)
    {
        checkPoint = target.transform.position;
    }
}
