using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    public GameObject ballSpawn;
    public GameObject BallPrefab;
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Throw();
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
        BallPrefab.useGravity(true);
    }

    public void CreateBall()
    {
        Instantiate(BallPrefab);
    }
}
