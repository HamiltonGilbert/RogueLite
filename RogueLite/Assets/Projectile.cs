using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] SpriteRenderer spriteRenderer;
    float speed = 0;
    Vector2 targetVelocity;

    public void Create(float speed, Vector2 target, Vector2 startPos, float rotationMod, Sprite sprite)
    {
        transform.position = startPos;
        spriteRenderer.sprite = sprite;
        this.speed = speed * 50;
        transform.up = (new Vector2(target.x, target.y) - new Vector2(transform.position.x, transform.position.y)).normalized;
        //Vector2 initialVector = (new Vector2(target.x, target.y) - new Vector2(transform.position.x, transform.position.y)).normalized;
        // tan ( arctan(currentVector) + rotationMod ) = new vector as a float: y/x (i.e. y/1)
        //float yValue = Mathf.Tan(Mathf.Atan(initialVector.y / initialVector.x));
        //transform.up = new Vector2(1, yValue).normalized;
        transform.Rotate(Vector3.forward * rotationMod);
        //transform.rotation = Quaternion.Euler(rotation);
        //Vector2 rotation = transform.rotation.eulerAngles + Vector3.up * rotationMod;
        //rigidbody.rotation = rotation.y;
        targetVelocity = transform.up;
        Move(targetVelocity);
        Destroy(gameObject, 5);
    }

    void Move(Vector3 targetVelocity)
    {
        rigidbody.velocity += speed * Time.fixedDeltaTime * new Vector2(targetVelocity.x, targetVelocity.y);
    }
}
