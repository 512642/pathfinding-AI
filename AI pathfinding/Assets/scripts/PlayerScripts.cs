using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    public GameObject ballSpawn;
    public GameObject BallPrefab;
    public Rigidbody playerrb;
    public Rigidbody Ballrb;
    GameObject ballInstance;
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Running();
        Throw();
    }

    void Running()
    {
        float xv = 0.5f;
        float zv = 0.5f;

        if(Input.GetKeyDown("w"))
        {
            playerrb.velocity = new Vector3(xv, 0, 0);
        }


        if (Input.GetKeyDown("s"))
        {
           playerrb.velocity = new Vector3(-xv, 0, 0);
        }


        if (Input.GetKeyDown("a"))
        {
            playerrb.velocity = new Vector3(0, 0, -zv);
        }


        if (Input.GetKeyDown("d"))
        {
            playerrb.velocity = new Vector3(0, 0, zv);
        }
    }






    public void Throw()
    {
        if(Input.GetKeyDown("x"))
        {
            anim.SetBool("IsThrowing", true);
        }
        else
        {
            anim.SetBool("IsThrowing", false);
        }

    }
    public void ReleaseBall()
    {
        print("throw");
        ballInstance.GetComponent<Rigidbody>().AddForce(0, 10, 20);
    }

    public void CreateBall()
    { 
        ballInstance = Instantiate(BallPrefab, ballSpawn.transform.position, ballSpawn.transform.rotation) as GameObject;     
    }
}
