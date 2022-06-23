
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            float random_x = Mathf.Clamp(transform.position.x, 260, 325);
            transform.position = new Vector3(random_x, 28, -759.9489f);
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * 45);
                if (transform.rotation.z < 0.15)
                {
                    transform.Rotate(0, 0, 100 * Time.deltaTime);
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * 45);
                if (transform.rotation.z > -0.15)
                {
                    transform.Rotate(0, 0, -55 * Time.deltaTime);
                }
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(-90, 0, 0);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(-90, 0, 0);
            }
        }
    }
}
