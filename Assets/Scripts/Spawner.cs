using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Golem _prefab;
    [SerializeField] private Transform _target;

    private int _numberEnamy = 3;

    private void Start()
    {
        StartCoroutine(Countdown());
    }

    private void Spawn()
    {
        var clone = Instantiate(_prefab, transform.position, Quaternion.identity);
        clone.AssignTarget(_target);
    }

    private IEnumerator Countdown()
    {
        int delay = 4;

        for (int i = 0; i < _numberEnamy; i++)
        {
            Spawn();
            yield return new WaitForSeconds(delay);
        }
    }
}