using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Vector3 CameraTarget;
    public Vector3 offset;
    public Vector2 turn;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        CameraTarget = player.transform.position;
        transform.LookAt(CameraTarget);
        //transform.rotation = player.transform.rotation;
        lookControl();   
    }

    void lookControl()
    {
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }

}
