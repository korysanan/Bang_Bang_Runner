using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f; // Ground의 이동 속도

    [SerializeField]
    private float hp = 1f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -14.43f) {
            Destroy(gameObject);
        }
    }
}
