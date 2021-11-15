using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCollector : MonoBehaviour
{
    [SerializeField] private List<Coin> _coins;
    private int _platformCount;
    public int PlatformCount => _platformCount;

    public int GetCoinsCount()
    {
        return _coins.Count;
    }

    public void AddCoins(Coin coin)
    {
        _coins.Add(coin);
    }

    private void Update()
    {
        Debug.Log("platform" + _platformCount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Platform platform = collision.gameObject.GetComponent<Platform>();
        if (platform != null)
        {
            _platformCount = platform.PlatformNumber;
        }
    }

}
