using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] SpriteRenderer spriteRenderer;
    float speed = 0;
    Vector2 targetVelocity;

    private float clock = 0;
    public void Create(float speed, Vector2 target, Vector2 startPos, Sprite sprite)
    {
        transform.position = startPos;
        spriteRenderer.sprite = sprite;
        this.speed = speed * 50;
        transform.up = new Vector2(target.x, target.y) - new Vector2(transform.position.x, transform.position.y);
        targetVelocity = (target - new Vector2(transform.position.x, transform.position.y)).normalized;
        Move(targetVelocity);
    }
    void Update()
    {
        clock += Time.deltaTime;
        if (clock > 10)
        {
            Destroy(this);
        }
    }

    void Move(Vector3 targetVelocity)
    {
        rigidbody.velocity += speed * Time.fixedDeltaTime * new Vector2(targetVelocity.x, targetVelocity.y);
    }
}
