using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject joystick;

    private void LoadNextLevel()
    {
        joystick.SetActive(false);
        gameManager.LoadNextLevel();
    }
}
