using UnityEngine;

public class Golem : Mower
{
    private Transform _target;

    private void Update()
    {
        Mowe(_target);
        Rotate(_target);
    }

    public void AssignTarget(Transform target)
    {
        _target = target;
    }
}