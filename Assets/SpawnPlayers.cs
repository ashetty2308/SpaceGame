using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public static float minX, maxX;

    public void Start()
    {
        minX = 250;
        maxX = 335;

        if(CreateAndJoin.hasCreated == true)
        {
            Debug.Log("created room!");
            Vector3 pPosition = new Vector3(250, 28, -759.9489f);
            PhotonNetwork.Instantiate(player1.name, pPosition, Quaternion.Euler(new Vector3(-90, 0, 0)));
            CreateAndJoin.hasCreated = false;
        }

        if (CreateAndJoin.hasJoined == true)
        {
            Debug.Log("joined room!");
            Vector3 pPosition = new Vector3(300, 28, -759.9489f);
            PhotonNetwork.Instantiate(player2.name, pPosition, Quaternion.Euler(new Vector3(-90, 0, 0)));
            CreateAndJoin.hasJoined = false;
        }
    }
}
