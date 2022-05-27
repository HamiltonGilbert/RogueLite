using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] ShipBase shipBase;
    [SerializeField] GameObject hull;
    [SerializeField] GameObject shield;


    // Start is called before the first frame update
    void Start()
    {
        Color tempColor = shield.GetComponent<SpriteRenderer>().color;
        tempColor.a = .2f;
        shield.GetComponent<SpriteRenderer>().color = tempColor;
        // comment out later
        hull.GetComponent<SpriteRenderer>().sprite = shipBase.ShipSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // for other script to reference
    public void ChooseShip(ShipBase ship)
    {
        shipBase = ship;
        hull.GetComponent<SpriteRenderer>().sprite = shipBase.ShipSprite;
    }
}
