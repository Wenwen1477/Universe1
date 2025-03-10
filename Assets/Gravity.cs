using UnityEngine;

public class Gravity : MonoBehaviour
{
    Rigidbody rb;
    const float G = 0.00674f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //All Attract
    }

    void Attract(GravityA other)
    {
        Rigidbody rbOther = GetComponent<Rigidbody>();
        Vector3 direction = rb.position - other.rb.position;
        float distance = direction.magnitude;
        if (distance == 0) { return; }

        float forceMagnitude = G * (rb.mass * other.rbOther.mass) / Mathf.Pow(distance, 2);
        Vector3 force = forceMagnitude * direction.normalized;
    }
}
}
