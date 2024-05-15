using UnityEngine;

public class Mower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotation;
    [SerializeField] private Transform[] _waypoints;

    private int _currentWaypoint = 0;

    private void Start()
    {
        //transform.position = _waypoints[0].transform.position;
    }

    void Update()
    {
        if (transform.position == _waypoints[_currentWaypoint].position)
        {
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Length;
        }

        transform.LookAt(_waypoints[_currentWaypoint].position);
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.LookRotation(_waypoints[_currentWaypoint].position),Time.deltaTime*_speedRotation);
        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, Time.deltaTime * _speed);
    }
}