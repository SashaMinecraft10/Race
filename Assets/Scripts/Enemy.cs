using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed;
    public Rigidbody SelfRigibody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveForward = transform.right * Speed;
        moveForward.y = SelfRigibody.velocity.y;
        SelfRigibody.velocity = moveForward;
    }
}
