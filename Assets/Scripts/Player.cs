using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        if ("Obstacle".Equals(other.gameObject.tag)) {
            Debug.Log("Dead");
            SceneManager.LoadScene(0);
        }
    }
}
