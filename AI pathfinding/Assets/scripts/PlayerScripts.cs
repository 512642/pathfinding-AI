using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    public GameObject fakeBall;
    public GameObject ballSpawn;
    public GameObject BallPrefab;
    public Rigidbody playerrb;
    public Rigidbody Ballrb;
    public Vector2 turn;
    GameObject ballInstance;
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {        
        mouseLook();
        Running();
        Throw();
    }
        void mouseLook()
    {
        turn.x += Input.GetAxis("Mouse X");        
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        
    }




    void Running()
    {
        float fv = 20;
        float sv = 20;
        int speedCap = 5;

        anim.SetBool("run",false);

        if(Input.GetKey("w"))
        {
            playerrb.AddForce(transform.forward * fv);
            anim.SetBool("run",true);
        }


        if (Input.GetKey("s"))
        {
           playerrb.AddForce(transform.forward * -fv);
           anim.SetBool("run",true);
        }


        if (Input.GetKey("a"))
        {
            playerrb.AddForce(transform.right * -sv);
            anim.SetBool("run",true);
        }


        if (Input.GetKey("d"))
        {
            playerrb.AddForce(transform.right * sv);
            anim.SetBool("run",true);
        }
 

        playerrb.velocity = Vector3.ClampMagnitude(playerrb.velocity, speedCap);
    }






    public void Throw()
    {
        if(Input.GetKeyDown("x"))
        {
            anim.SetBool("throw", true);
        }
        else
        {
            anim.SetBool("throw", false);
        }

    }


    public void ThrowBall()
    {
        fakeBall.SetActive(false);
        ballInstance = Instantiate(BallPrefab, ballSpawn.transform.position, transform.rotation) as GameObject;     
        ballInstance.GetComponent<Rigidbody>().AddForce(transform.forward*10, ForceMode.Impulse);
        ballInstance.GetComponent<Rigidbody>().AddForce(transform.up*5, ForceMode.Impulse);
    }
}
