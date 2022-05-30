using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] ShipBase shipBase;
    [SerializeField] ShieldBase shieldBase;
    [SerializeField] MenuDescription menuDescription;
    [SerializeField] SystemManager systemManager;

    public bool ship;
    public bool shield;

    private Color color;

    void Start()
    {
        color = spriteRenderer.color;
        spriteRenderer.color = new Color(color.r, color.g, color.b, 0);
    }

    private void OnMouseEnter()
    {
        spriteRenderer.color = new Color(color.r, color.g, color.b, 1);
        if (ship)
        {
            menuDescription.SetDescription(shipBase);
        }
        else
        {
            menuDescription.SetDescription(shieldBase);
        }
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = new Color(color.r, color.g, color.b, 0);
    }
    private void OnMouseDown()
    {
        if (ship)
        {
            systemManager.ChooseShip(shipBase);
        }
        else
        {
            systemManager.ChooseShield(shieldBase);
        }
    }
}
