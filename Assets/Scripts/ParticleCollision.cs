using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{

    public int rotz;
    public int mx, my;
    private Rigidbody2D myRigid;
    private ParticleSystem myPart;

    // Use this for initialization 

    public float startTime = 0f;
    void Start()
    {
        startTime = Time.timeSinceLevelLoad;
        myRigid = this.GetComponent<Rigidbody2D>();

        myPart = this.GetComponent<ParticleSystem>();

        this.transform.Rotate(new Vector3(0, 0, rotz));


        myRigid.AddForce(Vector3.up * mx);
        myRigid.AddForce(Vector3.right * mx);
    }

    // Update is called once per frame 

    void Update()
    {

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (startTime + 1f < Time.timeSinceLevelLoad)
            myPart.Play();
    }



    private void OnCollisionExit2D(Collision2D collision)
    {
        if (startTime + 1f < Time.timeSinceLevelLoad)
            myPart.Stop();
    }

}

