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
        hull.GetComponent<SpriteRenderer>().sprite = shipBase.ShipSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
