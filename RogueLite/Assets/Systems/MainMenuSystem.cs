using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSystem : MonoBehaviour
{
    [SerializeField] new GameObject camera;
    public void OpenMenu()
    {
        camera.SetActive(true);
    }
    public void CloseMenu()
    {
        camera.SetActive(false);
    }
}
