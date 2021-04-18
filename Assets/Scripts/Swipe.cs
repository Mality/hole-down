using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe : MonoBehaviour, IBeginDragHandler, IDragHandler
{

    public Transform player;
    private float speed = 0.05f;
    private float playerXBound = 4.5f;
    private const float maxSpeed = 0.5f;

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
    }
}
