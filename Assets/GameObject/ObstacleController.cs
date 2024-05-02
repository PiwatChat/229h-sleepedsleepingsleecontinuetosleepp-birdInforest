using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public int damage = 10; 

    GameManager gameManager; 

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); 
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bird")) 
        {
            gameManager.DecreaseHP(damage); 
        }
        if (col.CompareTag("Bullet")) 
        {
            Destroy(gameObject);
            gameManager.DecreaseHP(damage);
        }
    }


}
