using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class RedController : MonoBehaviourPunCallbacks
{

    #region VARIABLES
    [SerializeField] private TextMeshProUGUI _informationText; //texto para la informacion de pantalla
    public static RedController InstanceRed; //praa conectarse al servidor al instanciar este script

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

   public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        _informationText.text = "Conectando al servidor";
        print(_informationText.text);
        Debug.Log("CONECTADO AL MASTER");
        _informationText.text = "Conectado al Master";
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 4 }, TypedLobby.Default);
    }
}
