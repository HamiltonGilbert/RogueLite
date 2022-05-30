using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuDescription : MonoBehaviour
{
    [SerializeField] new Text name;
    [SerializeField] Text description;
    [SerializeField] Text hp;
    [SerializeField] Text shield;
    [SerializeField] Text damage;
    [SerializeField] Text attackSpeed;
    [SerializeField] Text moveSpeed;
    [SerializeField] Text size;
    public void SetDescription(ShipBase ship)
    {
        name.text = ship.Name;
        description.text = ship.Description;
        hp.text = "HP: " + ship.MaxHP;
        shield.text = "Shield: " + ship.MaxShield;
        damage.text = "Damage: " + ship.Damage;
        attackSpeed.text = "Rate of Fire: " + ship.AttacksPerSecond * 60;
        moveSpeed.text = "Thrusters: " + ship.MoveSpeed * 10;
        size.text = "size: " + ship.SizeMultiplier * 100;
    }
    public void SetDescription(ShieldBase shield)
    {
        name.text = shield.Name;
        description.text = shield.Description;
        hp.text = "HP: " + shield.MaxHP;
        this.shield.text = "Shield: " + shield.MaxShield;
        damage.text = "Damage: " + shield.Damage;
        attackSpeed.text = "Rate of Fire: " + shield.AttacksPerSecond * 60;
        moveSpeed.text = "Thrusters: " + shield.MoveSpeed * 10;
        size.text = "size: " + shield.SizeMultiplier * 100;
    }
}
