using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // This namespace is needed to access SceneManager

public class RestartGame : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the bird
        if (collision.gameObject.CompareTag("Bird"))
        {
            // Restart the game by reloading the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

