using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(HeroAnimator))]
[RequireComponent(typeof(HeroController))]
public class MoveHero : MonoBehaviour
{
    [SerializeField] private float _speedControl = 3f;
    [SerializeField] private float _jumpForce = 10f;
    [SerializeField] private int _howMuchJump = 2;

    private float _speed;
    private int _jumpCounter;
    private int _playeObject, _collideObject;
    
    private Rigidbody2D _rgb;
    private HeroAnimator _heroAnimator;
    private HeroController _heroController;

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        EventService.Instance.OnJump -= Jump;
    }

    private void Start()
    {
        _rgb = GetComponent<Rigidbody2D>();
        _heroAnimator = GetComponent<HeroAnimator>();
        _heroController = GetComponent<HeroController>();
        _speed = _speedControl;
        _jumpCounter = _howMuchJump;

        _playeObject = LayerMask.NameToLayer("Player");
        _collideObject = LayerMask.NameToLayer("Collide");
        EventService.Instance.OnJump += Jump;
    }

    private void FixedUpdate()
    {
        if (_heroController.IsAlive && GameController.Instance.IsStartGame)
        {
            _rgb.velocity = new Vector2(_speed, _rgb.velocity.y);
        }
        
        Debug.Log(_jumpCounter);

        if (_rgb.velocity.y > 0)
        {
            Physics2D.IgnoreLayerCollision(_playeObject, _collideObject, true);
        }
        else
        {
            Physics2D.IgnoreLayerCollision(_playeObject, _collideObject, false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        LeftObstacle leftObstacle = collision.gameObject.GetComponent<LeftObstacle>();
        RightObstacle rightObstacle = collision.gameObject.GetComponent<RightObstacle>();
        Platform platform = collision.gameObject.GetComponent<Platform>();

        if (platform != null)
        {
            _heroAnimator.RunningAnimation();
            _jumpCounter = _howMuchJump;
        }

        if (leftObstacle != null)
        {

            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            _speed = _speedControl;
        }

        if (rightObstacle != null)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            _speed = -_speedControl;
        }
    }

    private void Jump()
    {
        if (_jumpCounter > 0 && _heroController.IsAlive)
        {
            _heroAnimator.JumpAnimation();
            _rgb.velocity = Vector2.up * _jumpForce;
            _jumpCounter--;
        }
    }
}
