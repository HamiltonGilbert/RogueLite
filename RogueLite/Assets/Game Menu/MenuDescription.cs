using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuDescription : MonoBehaviour
{
    [SerializeField] new Text name;
    [SerializeField] Text description;
    [SerializeField] Text area1;
    [SerializeField] Text area2;
    [SerializeField] Text area3;
    [SerializeField] Text area4;
    [SerializeField] Text area5;
    [SerializeField] Text area6;
    [SerializeField] Text area7;
    public void SetDescription(ShipBase ship)
    {
        name.text = ship.Name;
        description.text = ship.Description;
        area1.text = "HP: " + ship.MaxHP;
        area2.text = "Shield Multiplier: " + ship.ShieldMultiplier * 100 + "%";
        area3.text = "Damage: " + ship.Damage;
        area4.text = "Rate of Fire: " + ship.AttacksPerSecond * 60;
        area5.text = "Thrusters: " + ship.MoveSpeed * 10;
        area6.text = "Size: " + ship.SizeMultiplier * 100;
        area7.text = "Mass: " + ship.Mass;
    }
    public void SetDescription(ShieldBase shield)
    {
        name.text = shield.Name;
        description.text = shield.Description;
        area1.text = "Shield: " + shield.MaxShield;
        area2.text = "HP: " + shield.HPMultiplier * 100 + "%";
        area3.text = "Cooldown Time: " + shield.Cooldown;
        area4.text = "Damage: " + shield.DamageMultiplier;
        area5.text = "Thrusters: " + shield.SpeedMultiplier * 100 + "%";
        area6.text = "Size: " + shield.SizeMultiplier * 100 + "%";
        area7.text = "Mass: " + shield.MassMultiplier * 100 + "%";
    }
}
