using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSystem : MonoBehaviour
{
    [SerializeField] new GameObject camera;
    [SerializeField] GameObject shipSelection;
    [SerializeField] GameObject shieldSelection;
    public void OpenMenu()
    {
        camera.SetActive(true);
        ShipSelection();
    }
    public void CloseMenu()
    {
        camera.SetActive(false);
    }
    public void ShipSelection()
    {
        shipSelection.SetActive(true);
        shieldSelection.SetActive(false);
    }
    public void ShieldSelection()
    {
        shieldSelection.SetActive(true);
        shipSelection.SetActive(false);
    }
}
