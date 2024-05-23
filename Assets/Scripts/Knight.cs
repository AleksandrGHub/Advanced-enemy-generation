using UnityEngine;

public class Knight : Mower
{
    [SerializeField] private Transform[] _waypoints;

    private int _currentWaypoint = 0;

    private void Update()
    {
        if (transform.position == _waypoints[_currentWaypoint].position)
        {
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Length;
        }

        Mowe(_waypoints[_currentWaypoint]);
        Rotate(_waypoints[_currentWaypoint]);
    }
}