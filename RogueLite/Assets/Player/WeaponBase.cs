using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon")]

public class WeaponBase : ScriptableObject
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite weaponSprite;

    [SerializeField] int damage;
    [SerializeField] float attacksPerSecond;
    [SerializeField] float speedMultiplier;
    [SerializeField] float sizeMultiplier;
    [SerializeField] float massMultiplier;
    [SerializeField] float shieldCooldownMultiplier;

    public string Name
    {
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }

    public Sprite WeaponSprite
    {
        get { return weaponSprite; }
    }
    public int Damage
    {
        get { return damage; }
    }
    public float AttacksPerSecond
    {
        get { return attacksPerSecond; }
    }
    public float SpeedMultiplier
    {
        get { return speedMultiplier; }
    }
    public float SizeMultiplier
    {
        get { return sizeMultiplier; }
    }
    public float MassMultiplier
    {
        get { return massMultiplier; }
    }
    public float ShieldCooldownMultiplier
    {
        get { return shieldCooldownMultiplier; }
    }
}