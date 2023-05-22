using UnityEngine;

public class teleport : MonoBehaviour
{
    [SerializeField] private Vector3 teleportPoint;

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportPoint;
    }
}
