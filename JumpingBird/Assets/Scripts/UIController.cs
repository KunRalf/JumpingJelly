using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text _coinsCount;
    [SerializeField] private Text _platforms;
    [SerializeField] private HeroCollector _heroCollector;
    [SerializeField] private GameObject _loseScreen;

    private void Update()
    {
        _coinsCount.text = $"{_heroCollector.GetCoinsCount()}";
        _platforms.text = $"{_heroCollector.PlatformCount}";
        if (!_heroCollector.gameObject.GetComponent<HeroController>().IsAlive)
        {
            _loseScreen.SetActive(true);
        }
    }

    
}
