using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        if ("Obstacle".Equals(other.gameObject.tag)) {
            SceneManager.LoadScene(0);
        }
    }
}
