using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;

    public void SpawnTarget(Vector3 position)
    {
        Instantiate(targetPrefab, position, Quaternion.identity);
    }
}