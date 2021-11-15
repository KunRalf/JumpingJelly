using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HeroCollector heroCollector = collision.gameObject.GetComponent<HeroCollector>();
        if (heroCollector != null)
        {
            heroCollector.AddCoins(this);
            Destroy(gameObject);    
        }
    }
}
