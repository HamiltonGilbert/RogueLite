using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuDescription : MonoBehaviour
{
    [SerializeField] Text textBox;
    public void SetDescription(ShipBase ship)
    {
        textBox.text = ship.Name;
    }
}
