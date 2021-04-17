using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpObstacle : MonoBehaviour {
    public float speed = 5f;
    private const float Y_BOUND = 11f;

    private void Update() {
        transform.Translate(Vector3.up * (Time.deltaTime * speed));

        if (transform.position.y > Y_BOUND) {
            Destroy(gameObject);
        }
    }
}
