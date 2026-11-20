using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] CheckPointManager checkPointManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkPointManager.SetCheckPointPosition(other.transform);
            Debug.Log("SetCheckPoint");
        }
    }
}