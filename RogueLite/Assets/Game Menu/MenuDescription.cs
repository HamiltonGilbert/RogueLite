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
        attackSpeed.text = "Attack Speed: " + ship.AttacksPerSecond * 60;
        moveSpeed.text = "Move Speed: " + ship.MoveSpeed * 10;
        size.text = "size: " + ship.SizeMultiplier * 100;
    }
}
