using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using Photon.Pun;

public class UIManager : MonoBehaviourPunCallbacks, IPunObservable
{
    [SerializeField] private TextMeshProUGUI _infoText; //texto del banner
    [SerializeField] private int PlayerNum;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SetPlayerOrEnenemy");
    }

    IEnumerator SetPlayerOrEnemy()
    {
        yield return new WaitForSeconds(4);

        if (photonView.IsMine)
        {
            _infoText.text = "Soy JUGADOR";
        }
        else if (!photonView.IsMine)
        {
            _infoText.text = "Soy ENEMIGO";
        }
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {

    }

 
}
