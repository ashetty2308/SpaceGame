using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Drop_Enemies : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update

    public GameObject planet;
    public GameObject planet_clone;
    public GameObject planet_clone2;
    public GameObject planet_clone3;

    int enemy_counter;
    public int numLaunched;
    PhotonView view; 

    void Start()
    {
        enemy_counter = 0;
        InvokeRepeating("DropEnemies", 1, 3f);
        view = GetComponent<PhotonView>();
           
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void DropEnemies()
    {
        int random_x = Random.Range(260, 325);

        transform.position = new Vector3(random_x, 100, -759.949f);
        Vector3 second = new Vector3(random_x, 95, -759.949f);
        Vector3 third = new Vector3(random_x, 90, -759.949f);

        planet_clone = (GameObject) Instantiate(planet, transform.position, transform.rotation) ;
        planet_clone2 = (GameObject) Instantiate(planet, second, transform.rotation);
        planet_clone3 = (GameObject) Instantiate(planet, third, transform.rotation) ;

        Rigidbody rb_clone = planet_clone.GetComponent<Rigidbody>();
        Rigidbody rb_clone2 = planet_clone.GetComponent<Rigidbody>();
        Rigidbody rb_clone3 = planet_clone.GetComponent<Rigidbody>();

        rb_clone.AddForce((-50f * Time.deltaTime * transform.up));
        rb_clone2.AddForce((-50f * Time.deltaTime * transform.up));
        rb_clone3.AddForce((-50f * Time.deltaTime * transform.up));
    }

}