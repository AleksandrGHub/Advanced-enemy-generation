using UnityEngine;

public class Golem : Mower
{
    private Transform _target;

    private void Update()
    {
        Mowe(_target);
        Rotate(_target);
    }

    public Transform AssignTarget(Transform target)
    {
        return _target = target;
    }
}