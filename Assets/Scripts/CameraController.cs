using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 cameraOffset;

    public void Start()
    {
        // on game start, set a static follow distance for the camera to the player
        cameraOffset = transform.position - player.transform.position;
    }

    public void LateUpdate()
    {

        transform.position = player.transform.position + cameraOffset;
    }


}
