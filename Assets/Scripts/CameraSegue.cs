using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    public Transform player;

    public float offsetX, offsetY;



    private void LateUpdate()
    {
       transform.position = new Vector3(transform.position.x + offsetX, player.position.y + offsetY, -10);
            
    }
}

