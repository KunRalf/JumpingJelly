using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HeroController hero = collision.gameObject.GetComponent<HeroController>();
        if (hero != null)
        {
            hero.IsDeath();
            Debug.Log("staticl");
        }
    }
}
