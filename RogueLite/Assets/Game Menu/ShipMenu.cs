using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMenu : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] ShipBase shipBase;
    [SerializeField] MenuDescription menuDescription;
    [SerializeField] SystemManager systemManager;

    private Color color;

    void Start()
    {
        color = spriteRenderer.color;
        spriteRenderer.color = new Color(color.r, color.g, color.b, 0);
    }

    private void OnMouseEnter()
    {
        spriteRenderer.color = new Color(color.r, color.g, color.b, 1);
        menuDescription.SetDescription(shipBase);
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = new Color(color.r, color.g, color.b, 0);
    }
    private void OnMouseDown()
    {
        systemManager.ChooseShip(shipBase);
    }
}
