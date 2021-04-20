using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe : MonoBehaviour
{

   /* public Transform player;
    private float speed = 0.05f;
    private float playerXBound = 4.5f;
    private const float maxSpeed = 0.15f;

    //just_for_fun
    private float playerYBound = 9f;
    
    public void OnBeginDrag(PointerEventData eventData) {
        
    }

    public void OnDrag(PointerEventData eventData) {
        
        player.Translate(Vector3.right * Math.Max(Math.Min(eventData.delta.x * speed, maxSpeed), -maxSpeed));

        if (player.position.x > playerXBound) {
            player.position = new Vector3(playerXBound, player.position.y, player.position.z);
        }
        if (player.position.x < -playerXBound) {
            player.position = new Vector3(-playerXBound, player.position.y, player.position.z);
        }


        // just_for_fun
        player.Translate(Vector3.up * Math.Max(Math.Min(eventData.delta.y * speed, maxSpeed), -maxSpeed));
        
        if (player.position.y > playerYBound){
            player.position = new Vector3(player.position.x, playerYBound, player.position.z);
        }
        if (player.position.y < -playerYBound){
            player.position = new Vector3(player.position.x, -playerYBound, player.position.z);
        }
    }*/
    public Transform player;
    private float speed = 20f;
    void OnMouseDrag () {
        if (!Player.lose) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
            mousePos.x = mousePos.x > 4.5f ? 4.5f : mousePos.x;
            mousePos.x = mousePos.x < -4.5f ? -4.5f : mousePos.x;
            mousePos.y = mousePos.y > 11f ? 11f : mousePos.y;
            mousePos.y = mousePos.y < -11f ? -11f : mousePos.y;
            player.position = Vector3.MoveTowards (player.position, new Vector3 (mousePos.x, mousePos.y, player.position.z), speed * Time.deltaTime);
	
        }	
    }
}
