using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : Singleton<Move>
{
    public float speed = 10f;

    public void MoveObject(GameObject obj, Vector3 direction)
    {
        obj.transform.Translate(direction * speed * Time.deltaTime);
    }
}
