using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redirection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int left_or_right = getNum();
        InvokeRepeating("Redirect", 1, 1f);
    }


    // Update is called once per frame
    void Update()
    {

     

    }
    void Redirect()
    {
        Rigidbody rb = transform.GetComponent<Rigidbody>();

        if (transform.transform.position.y <= 50)
        {
            if (getNum() % 2 == 0)
            {
                rb.velocity = transform.right * 15;
            }
            else
            {
                rb.velocity = transform.right * -15;
            }
        }
    }
    public int getNum()
    {
        var random_x = Random.Range(1, 300);
        return random_x;
    }
}
