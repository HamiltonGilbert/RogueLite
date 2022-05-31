using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] ShipBase shipBase;
    [SerializeField] ShieldBase shieldBase;
    [SerializeField] GameObject hull;
    [SerializeField] GameObject shield;
    [SerializeField] new Rigidbody2D rigidbody;
    [SerializeField] GameObject thrusters;
    [SerializeField] float friction;

    private float currentHP;
    private int currentShield;

    private int maxHP;
    private int maxShield;
    private float damage;
    private float attacksPerSecond;
    private float moveSpeed;
    private float sizeMultiplier;
    private float mass;

    private bool gameRunning;

    // Start is called before the first frame update
    void Start()
    {
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
            Vector2 targetVelocity = mousePosition - new Vector2(transform.position.x,transform.position.y);
            // rotation
            transform.up = new Vector3(mousePosition.x, mousePosition.y, 0) - new Vector3(transform.position.x, transform.position.y, 0);

            // move ship
            if (Input.GetMouseButton(0))
            {
                Move(new Vector2(targetVelocity.normalized.x, targetVelocity.normalized.y));
                thrusters.SetActive(true);
            }
            else
            {
                thrusters.SetActive(false);
            }
        }
    }

    void Move(Vector3 targetVelocity)
    {
        rigidbody.velocity += moveSpeed * Time.fixedDeltaTime * new Vector2(targetVelocity.x, targetVelocity.y);
    }

    // for other scripts to reference
    public void ChooseShip(ShipBase shipBase)
    {
        this.shipBase = shipBase;
        hull.GetComponent<SpriteRenderer>().sprite = this.shipBase.ShipSprite;
    }
    public void ChooseShield(ShieldBase shieldBase)
    {
        this.shieldBase = shieldBase;
        shield.GetComponent<SpriteRenderer>().color = shieldBase.ShieldColor;
    }
    public void StartGame()
    {
        StartCoroutine(StartGame(.5f));
    }
    IEnumerator StartGame(float time)
    {
        maxHP = (int)(shipBase.MaxHP * shieldBase.HPMultiplier);
        maxShield = shieldBase.MaxShield;
        damage = shipBase.Damage * shieldBase.DamageMultiplier;
        attacksPerSecond = shipBase.AttacksPerSecond;
        moveSpeed = shipBase.MoveSpeed * shieldBase.SpeedMultiplier;
        sizeMultiplier = shipBase.SizeMultiplier * shieldBase.SizeMultiplier;
        mass = shipBase.Mass * shieldBase.MassMultiplier;
        print("HP: " + maxHP);
        print("Shields: " + maxShield);
        print("Damage: " + damage);
        print("Attacks Per Second: " + attacksPerSecond);
        print("Move Speed: " + moveSpeed);
        print("Size Modifier: " + sizeMultiplier);
        print("Mass: " + mass);

        currentHP = maxHP;
        currentShield = maxShield;
        transform.localScale *= sizeMultiplier;
        rigidbody.mass = mass;

        yield return new WaitForSeconds(time);
        gameRunning = true;
    }
    public void EndGame()
    {
        gameRunning = false;
        thrusters.SetActive(false);
    }
}