using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpObstacle : MonoBehaviour {
    private float speed = 300f;
    private const float Y_BOUND = 11f;
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        rb.velocity = Vector3.up * (Time.deltaTime * speed);
        if (transform.position.y > Y_BOUND) {
            Destroy(gameObject);
        }
    }
}
