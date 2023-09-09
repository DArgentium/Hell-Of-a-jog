using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundTarget : MonoBehaviour
{
    public Transform Target;
    public Vector3 Axis;
    public float Speed;

    void Update()
    {
        transform.RotateAround(Target.position, Axis, Speed * Time.deltaTime);
    }
}
