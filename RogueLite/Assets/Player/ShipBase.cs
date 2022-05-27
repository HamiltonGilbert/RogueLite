using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ship", menuName = "Ship")]

public class ShipBase : ScriptableObject
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite shipSprite;

    [SerializeField] int maxHP;
    [SerializeField] int maxShield;
    [SerializeField] float damage;
    [SerializeField] float attacksPerSecond;
    [SerializeField] int moveSpeed;

    public string Name
    {
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }

    public Sprite ShipSprite
    {
        get { return shipSprite; }
    }

    public int MaxHP
    {
        get { return maxHP; }
    }
    public int MaxShield
    {
        get { return maxShield; }
    }
    public float Damage
    {
        get { return damage; }
    }
    public float AttacksPerSecond
    {
        get { return attacksPerSecond; }
    }
    public int MoveSpeed
    {
        get { return moveSpeed; }
    }


}