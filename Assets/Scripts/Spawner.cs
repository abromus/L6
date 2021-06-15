using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnerPoint> _spawnerPoints;

    private const float _callTime = 2f;
    private int _index;

    private void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        while(true)
        {
            _spawnerPoints[_index].Create();
            _index = (_index + 1) % _spawnerPoints.Count;

            yield return new WaitForSeconds(_callTime);
        }
    }
}
