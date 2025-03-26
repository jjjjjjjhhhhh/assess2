using System;
using UnityEngine;
public class Rotate : Singleton<Rotate>
{
    public float speed = 10f;

    public void RotateObject(GameObject obj, Vector3 axis, float angle)
    {
        obj.transform.Rotate(axis, angle * speed * Time.deltaTime);
    }
}