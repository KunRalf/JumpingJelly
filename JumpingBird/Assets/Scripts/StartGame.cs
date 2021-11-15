using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartGame : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _hud;

    public void OnPointerClick(PointerEventData eventData)
    {
        _hud.SetActive(true);
        gameObject.SetActive(false);
        GameController.Instance.StartGame();
    }
}
