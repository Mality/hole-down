using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Swipe : MonoBehaviour, IBeginDragHandler, IDragHandler
{

    public Transform player;
    public float dragSpeed = 0.1f;
    private float playerXBound = 4.5f;

    //just_for_fun
    private float playerYBound = 9f;
    
    public void OnBeginDrag(PointerEventData eventData) {
        
    }

    public void OnDrag(PointerEventData eventData) {
        
        
        player.Translate(Vector3.right * eventData.delta.x * dragSpeed);

        if (player.position.x > playerXBound) {
            player.position = new Vector3(playerXBound, player.position.y, player.position.z);
        }
        if (player.position.x < -playerXBound) {
            player.position = new Vector3(-playerXBound, player.position.y, player.position.z);
        }


        //just_for_fun
        player.Translate(Vector3.up * eventData.delta.y * dragSpeed);

        if (player.position.y > playerYBound){
            player.position = new Vector3(player.position.x, playerYBound, player.position.z);
        }
        if (player.position.y < -playerYBound){
            player.position = new Vector3(player.position.x, -playerYBound, player.position.z);
        }
    }
}
