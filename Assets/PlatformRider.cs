using UnityEngine;

public class PlatformRider : MonoBehaviour
{
    Rigidbody rider;
    Vector3 lastPosition;

    void Start() { lastPosition = transform.position; }

    void FixedUpdate()
    {
        Vector3 delta = transform.position - lastPosition;
        if (rider != null) rider.position += delta;
        lastPosition = transform.position;
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Player")) rider = c.rigidbody;
    }

    void OnCollisionExit(Collision c)
    {
        if (c.gameObject.CompareTag("Player")) rider = null;
    }
}
