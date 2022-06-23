using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class CreateAndJoin : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;

    public static bool hasCreated = false;
    public static bool hasJoined = false;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);
        hasCreated = true;
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
        hasJoined = true;
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
