using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public Transform player;
   
    private void LateUpdate()
    {
        float camX = Mathf.Lerp(0,player.position.x,1f);
        float camY = Mathf.Lerp(0,player.position.y,1f) ; 
        transform.position = new Vector3(camX,camY, -10); // Camera follows the player but 6 to the right

    }
}
