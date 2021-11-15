using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private List<SpawnedBlock> _platformPrefab;
    [SerializeField] private int _howMuchPlatforms;
    private int _platformNumber = 2;
    private void Start()
    {
        Vector3 spawnPos = new Vector3(0, 4, 0);
        for (int i = 0; i < _howMuchPlatforms; i++)
        {
            spawnPos.y += 2;
            _platformNumber++;
            SpawnedBlock block = Instantiate(_platformPrefab[Random.Range(0, _platformPrefab.Count)], spawnPos, Quaternion.identity);
            block.GetComponentInChildren<Platform>().SetPlatformNumber(_platformNumber);
        }
    }
}
