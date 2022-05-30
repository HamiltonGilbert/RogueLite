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
    [SerializeField] float friction;

    private float moveSpeed;
    private bool isMoving;
    private bool gameRunning;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        gameRunning = false;
        thrusters.SetActive(false);

        Color tempColor = shield.GetComponent<SpriteRenderer>().color;
        tempColor.a = .2f;
        shield.GetComponent<SpriteRenderer>().color = tempColor;
    }

    void FixedUpdate()
    {
        if (gameRunning)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // rotation
            transform.up = new Vector3(mousePosition.x, mousePosition.y, 0) - transform.position;

            // move ship
            if (Input.GetMouseButton(0))
            {
                Move(mousePosition);
                thrusters.SetActive(true);
            }
            else
            {
                thrusters.SetActive(false);
            }
        }
    }

    void Move(Vector3 targetPos)
    {
        Debug.Log("move");
        rigidbody.velocity += moveSpeed * Time.fixedDeltaTime * new Vector2(targetPos.normalized.x, targetPos.normalized.y);
    }

    // for other scripts to reference
    public void ChooseShip(ShipBase ship)
    {
        shipBase = ship;
        hull.GetComponent<SpriteRenderer>().sprite = shipBase.ShipSprite;
        transform.localScale *= shipBase.SizeMultiplier;
        moveSpeed = shipBase.MoveSpeed;
        StartCoroutine(StartGame(.5f));
    }
    IEnumerator StartGame(float time)
    {
        yield return new WaitForSeconds(time);
        gameRunning = true;
    }
    public void EndGame()
    {
        gameRunning = false;
        thrusters.SetActive(false);
    }
}