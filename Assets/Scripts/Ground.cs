using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float moveSpeed = 5f; // Ground의 이동 속도

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -14.43f) {
            Destroy(gameObject);
        }
    }
}
