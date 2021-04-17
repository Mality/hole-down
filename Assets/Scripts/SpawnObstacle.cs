using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnObstacle : MonoBehaviour {

    private float spawnDelay = 1f;
    public GameObject[] obstacles;
    private const float yStartPosition = -10f;
    private const float zStartPosition = -1f;
    private const float xRange = 4f;

    private void Start() {
        StartCoroutine(SpawnObject());
    }

    private void CreateObstacle() {
        var num = Random.Range(0, 1);
        var xPos = Random.Range(-xRange, xRange);
        Instantiate(obstacles[num], new Vector3(xPos, yStartPosition, zStartPosition), Quaternion.identity);
    }

    private IEnumerator SpawnObject() {
        while (true) {
            CreateObstacle();
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
