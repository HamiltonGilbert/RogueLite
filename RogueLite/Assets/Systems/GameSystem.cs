using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    [SerializeField] new GameObject camera;
    [SerializeField] PlayerController player;
    public void StartGame(ShipBase ship)
    {
        camera.SetActive(true);
        player.ChooseShip(ship);
    }
    public void EndGame()
    {
        camera.SetActive(false);
        player.EndGame();
    }
}
