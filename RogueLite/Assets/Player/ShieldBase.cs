using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shield", menuName = "Shield")]

public class ShieldBase : ScriptableObject
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite shieldSprite;

    [SerializeField] int maxHP;
    [SerializeField] int maxShield;
    [SerializeField] float damage;
    [SerializeField] float attacksPerSecond;
    [SerializeField] float moveSpeed;
    [SerializeField] float sizeMultiplier;

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
        get { return shieldSprite; }
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
    public float MoveSpeed
    {
        get { return moveSpeed; }
    }
    public float SizeMultiplier
    {
        get { return sizeMultiplier; }
    }

}