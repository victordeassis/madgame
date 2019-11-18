using UnityEngine;


public class FinishLevel : MonoBehaviour
{
    
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // Shuts down the player to avoid it falling after concluding a level
            other.gameObject.SetActive(false);
            gameManager.FinishLevel();
        }
    }
}
