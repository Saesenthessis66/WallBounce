using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public int bounceCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        bounceCount++;
    }
}