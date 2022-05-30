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

    void Update()
    {
        if (gameRunning)
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
            }
            else
            {
                thrusters.SetActive(false);
            }
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