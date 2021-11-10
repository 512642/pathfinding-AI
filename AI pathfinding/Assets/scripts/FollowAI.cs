using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject robot;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = robot.transform.position + offset;
    }
}
