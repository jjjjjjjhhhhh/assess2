using System;
using UnityEngine;
public class Scale : Singleton<Scale>
{
    public float speed = 10f;

    public void ScaleObject(GameObject obj, Vector3 scale)
    {
        obj.transform.localScale += scale * speed * Time.deltaTime;
    }
}
