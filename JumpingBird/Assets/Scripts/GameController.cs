using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    private GameController()
    {
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private bool _isStartGame = false;
    public bool IsStartGame => _isStartGame;

    public void StartGame()
    {
        _isStartGame = true;
    }
}
