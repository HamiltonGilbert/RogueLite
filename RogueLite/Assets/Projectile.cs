using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] SpriteRenderer spriteRenderer;
    float speed = 0;
    Vector2 targetVelocity;

    public void Create(float speed, Vector2 target, Vector2 startPos, Vector3 rotation, Sprite sprite)
    {
        transform.position = startPos;
        spriteRenderer.sprite = sprite;
        this.speed = speed * 50;
        //transform.up = new Vector2(target.x, target.y) - new Vector2(transform.position.x, transform.position.y);
        transform.rotation = Quaternion.Euler(rotation);
        //Vector3 rotation = transform.rotation.eulerAngles + Vector3.forward * rotationMod;
        targetVelocity = (target - new Vector2(transform.position.x, transform.position.y)).normalized;
        Move(targetVelocity);
        Destroy(gameObject, 5);
    }

    void Move(Vector3 targetVelocity)
    {
        rigidbody.velocity += speed * Time.fixedDeltaTime * new Vector2(targetVelocity.x, targetVelocity.y);
    }
}
