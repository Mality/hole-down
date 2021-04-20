using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPlaneDeformation : MonoBehaviour {

    private MeshFilter meshFilter;
    private Mesh mesh;
    private Vector3[] vertices;

    [SerializeField] private float radius;
    [SerializeField] private float power;

    private void Start() {
        meshFilter = GetComponent<MeshFilter>();
        mesh = meshFilter.mesh;
        vertices = mesh.vertices;
    }

    public void PerformDeformation(Vector3 position) {
        Debug.Log(position);
        position = transform.InverseTransformPoint(position);

        for (int i = 0; i < vertices.Length; i++) {
            float dist = (vertices[i] - position).sqrMagnitude;

            if (dist <= radius) {
                vertices[i] -= Vector3.up * power;
            }
        }

        mesh.vertices = vertices;
    } 
    
}
