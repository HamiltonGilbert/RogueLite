using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    [SerializeField] MainMenuSystem mainMenuSystem;
    [SerializeField] GameSystem gameSystem;

    private ShipBase ship;
    private ShieldBase shield;

    void Start()
    {
        gameSystem.EndGame();
        mainMenuSystem.OpenMenu();
    }
    public void ChooseShip(ShipBase shipBase)
    {
        ship = shipBase;
        mainMenuSystem.ShieldSelection();
    }
    public void ChooseShield(ShieldBase shieldBase)
    {
        shield = shieldBase;
    }

    public void StartGame()
    {
        mainMenuSystem.CloseMenu();
        gameSystem.StartGame(ship, shield);
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
