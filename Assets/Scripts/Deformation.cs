using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Deformation : MonoBehaviour {

    private Camera camera;

    private void Start() {
        camera = Camera.main;
    }

    private void FixedUpdate() {
        if (Input.GetMouseButton(0)) {
            Deform();
        }
    }

    private void Deform() {
        Debug.Log("Deform");
        
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // if (Physics.Raycast(ray, out hit, Mathf.Infinity, (1 << 7))) {
        if (Physics.Raycast(ray, out hit)) {
            LevelPlaneDeformation deformPlane = hit.collider.GetComponent<LevelPlaneDeformation>();
            deformPlane.PerformDeformation(hit.point);
        }
    }
}  
