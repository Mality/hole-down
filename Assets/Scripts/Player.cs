using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public static bool lose = false;
    private void OnTriggerEnter(Collider other) {
        if ("Obstacle".Equals(other.gameObject.tag))
        {
            //lose = true;
            SceneManager.LoadScene(0);
        }
    }
}
