using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    [SerializeField] MainMenuSystem mainMenuSystem;
    [SerializeField] GameSystem gameSystem;

    private ShipBase ship;

    void Start()
    {
        gameSystem.EndGame();
        mainMenuSystem.OpenMenu();

    }
    public void ChooseShip(ShipBase shipBase)
    {
        ship = shipBase;
        mainMenuSystem.CloseMenu();
        gameSystem.StartGame(ship);
    }
    public void ChooseShield(ShieldBase shieldBase)
    {

    }

    private void Update()
    {
        if (Input.GetButtonDown("Menu"))
        {
            gameSystem.EndGame();
            mainMenuSystem.OpenMenu();
        }
    }
}
