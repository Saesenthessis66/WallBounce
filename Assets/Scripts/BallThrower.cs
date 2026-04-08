using UnityEngine;

public class BallThrower : MonoBehaviour
{
    public GameObject ballPrefab;
    public float throwForce = 500f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ThrowBall();
        }
    }

    void ThrowBall()
    {
        GameObject ball = Instantiate(ballPrefab, Camera.main.transform.position, Quaternion.identity);

        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(Camera.main.transform.forward * throwForce);
    }
}