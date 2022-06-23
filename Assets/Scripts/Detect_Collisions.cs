using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Detect_Collisions : MonoBehaviour
{
    // Start is called before the first frame update
 
    public ParticleSystem ps;
    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > 130)
        {
            Destroy(gameObject);
        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        ParticleSystem smoke = Instantiate(ps, transform.position, Quaternion.identity) as ParticleSystem;
        smoke.Play();

        GameObject psOther = GameObject.FindWithTag("fire");
        ParticleSystem ps_to_destroy = psOther.GetComponent<Shoot>().clone_ps;

        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name.Substring(0, 3).Equals("Ene"))
        {
            Debug.Log("removing..................");
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            Destroy(ps_to_destroy);
            GameManagerScript.IncrementScore();
        }
        if (collision.gameObject.name.Equals("Magic fire 1(Clone"))
        {
            Destroy(collision.collider.gameObject);
        }

        
    }

}
