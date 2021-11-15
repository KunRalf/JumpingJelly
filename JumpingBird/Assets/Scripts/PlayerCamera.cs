using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private MoveHero _player;

    private float _lerpSpeed = 2f;
    private Vector3 toPosition;
    public Vector3 _offset;

    private void Start()
    {
        _player = FindObjectOfType<MoveHero>();
        _offset = _player.transform.position - transform.position;
    }

    private void FixedUpdate()
    {
        toPosition = _player.transform.position - _offset;
        transform.position = Vector3.Lerp(transform.position, new Vector3(0, _player.transform.position.y, -10), _lerpSpeed * Time.deltaTime);
    }

}
