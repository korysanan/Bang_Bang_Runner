using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky : MonoBehaviour
{
    public float moveSpeed = 5f; // Ground의 이동 속도

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -21.79f) {
            transform.position += new Vector3(51.29f, 0, 0);
        }
    }
}
