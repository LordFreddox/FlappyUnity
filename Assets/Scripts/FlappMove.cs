using UnityEngine;
using UnityEngine.InputSystem;

public class FlappMove : MonoBehaviour
{
    public float velocity=1.5f, rotationSpeed=10f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rb.velocity.y*rotationSpeed);
    }
}
