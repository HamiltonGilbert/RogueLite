using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] ShipBase shipBase;
    [SerializeField] GameObject hull;
    [SerializeField] GameObject shield;
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] GameObject thrusters;

    private float moveSpeed;

    private Vector2 input;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;

        Color tempColor = shield.GetComponent<SpriteRenderer>().color;
        tempColor.a = .2f;
        shield.GetComponent<SpriteRenderer>().color = tempColor;
        // comment out later
        ChooseShip(shipBase);
    }

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = new Vector3(mousePosition.x, mousePosition.y, 0) - transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Move(mousePosition));
        }
        if (isMoving)
        {
            thrusters.SetActive(true);
        } else
        {
            thrusters.SetActive(false);
        }
    }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;
        isMoving = false;
    }

    // for other script to reference
    public void ChooseShip(ShipBase ship)
    {
        shipBase = ship;
        hull.GetComponent<SpriteRenderer>().sprite = shipBase.ShipSprite;
        transform.localScale *= shipBase.SizeMultiplier;
        moveSpeed = shipBase.MoveSpeed;
    }
}

/*
 public Transform CharacterTransform;
    public float RotationSmoothingCoef = 0.01f;

    private Quaternion targetRotation;

    void Update()
    {
        var groundPlane = new Plane(Vector3.up, -CharacterTransform.position.y);
        var mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDistance;

        if (groundPlane.Raycast(mouseRay, out hitDistance))
        {
            var lookAtPosition = mouseRay.GetPoint(hitDistance);
            targetRotation = Quaternion.LookRotation(lookAtPosition - CharacterTransform.position, Vector3.up);
        }
    }

    void FixedUpdate()
    {
        var rotation = Quaternion.Lerp(CharacterTransform.rotation, targetRotation, RotationSmoothingCoef);
        CharacterTransform.rotation = rotation;
    }
 */