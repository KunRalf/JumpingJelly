using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SawMovement : MonoBehaviour
{
    [SerializeField] private float _speedControl;
    private Rigidbody2D _rgbSaw;
    private float _speed;
    

    private void Start()
    {
        _rgbSaw = GetComponent<Rigidbody2D>();
        _speed = _speedControl;
    }

    private void Update()
    {
        _rgbSaw.velocity = new Vector2(_speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LeftObstacle leftObstacle = collision.gameObject.GetComponent<LeftObstacle>();
        RightObstacle rightObstacle = collision.gameObject.GetComponent<RightObstacle>();
        HeroController hero = collision.gameObject.GetComponent<HeroController>();

        if (hero != null)
        {
            Debug.Log("hero");
            hero.IsDeath();
        }


        if (leftObstacle != null)
        {
            _speed = _speedControl;
        }

        if (rightObstacle != null)
        {
            _speed = -_speedControl;
        }
    }



}
