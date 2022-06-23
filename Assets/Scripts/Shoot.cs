using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Shoot : MonoBehaviour
{
    public GameObject laser;
    public ParticleSystem ps;
    public ParticleSystem clone_ps;
    PhotonView view;


    
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                clone_ps = Instantiate(ps, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), Quaternion.identity) as ParticleSystem;
                GameObject laser_clone = Instantiate(laser, transform.position, Quaternion.identity) as GameObject;
                Rigidbody rb_clone = laser_clone.GetComponent<Rigidbody>();
                Rigidbody clone_ps_rb = clone_ps.GetComponent<Rigidbody>();

                clone_ps_rb.AddForce(3000 * transform.forward);
                rb_clone.AddForce(3000 * transform.forward);
            }
        }
    }
}
