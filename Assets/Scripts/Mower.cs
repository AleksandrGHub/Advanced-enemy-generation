using UnityEngine;

public class Mower : MonoBehaviour
{
    [SerializeField] private float _speed;

    protected void Mowe(Transform target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * _speed);
    }

    protected void Rotate(Transform target)
    {
        transform.LookAt(target);
    }
}