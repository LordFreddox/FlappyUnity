using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public float width=6f;
    public float speed=1f;
    public SpriteRenderer spriteRenderer;
    public Vector2 startSize;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startSize = new Vector2(spriteRenderer.size.x, spriteRenderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.size = new Vector2(spriteRenderer.size.x + speed * Time.deltaTime, spriteRenderer.size.y);
        if (spriteRenderer.size.x > width)
        {
            spriteRenderer.size = startSize;
        }
    }
}
