using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    private bool _isAlive = true;
    private bool _isJump = false;

    public bool IsJump => _isJump;
    public bool IsAlive => _isAlive;

    public void IsDeath()
    {
        _isAlive = false;
    }

    public void IsRun()
    {
        _isJump = false;
    }

    public void IsJumping()
    {
        _isJump = true;
    }
}
