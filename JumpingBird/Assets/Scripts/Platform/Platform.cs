using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private int _platformNumber;
    public int PlatformNumber => _platformNumber;

    public void SetPlatformNumber(int number)
    {
        _platformNumber = number;
    }
}
