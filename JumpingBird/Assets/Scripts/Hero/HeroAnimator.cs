using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnimator : MonoBehaviour
{
    private Animator _animator;
    private HeroController _heroController;
    private bool _isJump = false;
    private const string IS_JUMP = "_isJump";
    private const string IS_DEATH = "_isDeath";
    private const string IS_START_GAME = "_isStartGame";

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _heroController = GetComponent<HeroController>();
    }

    public void JumpAnimation()
    {
        _animator.SetBool(IS_JUMP, true);
    }

    public void RunningAnimation()
    {
        _animator.SetBool(IS_JUMP, false);
    }

    private void DeathAnimation()
    {
        _animator.SetBool(IS_DEATH, true);
    }

    private void Update()
    {
        if (!_heroController.IsAlive)
        {
            DeathAnimation();
        }
        if (GameController.Instance.IsStartGame)
        {
            _animator.SetBool(IS_START_GAME, true);
        }
    }
}
