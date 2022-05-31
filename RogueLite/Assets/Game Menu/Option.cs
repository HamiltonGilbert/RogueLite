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

    private Color highlightColor;

    void Start()
    {
        highlightColor = spriteRenderer.color;
        spriteRenderer.color = new Color(highlightColor.r, highlightColor.g, highlightColor.b, 0);
    }

    private void OnMouseEnter()
    {
        spriteRenderer.color = new Color(highlightColor.r, highlightColor.g, highlightColor.b, 1);
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
        spriteRenderer.color = new Color(highlightColor.r, highlightColor.g, highlightColor.b, 0);
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
            systemManager.StartGame();
        }
    }
}
