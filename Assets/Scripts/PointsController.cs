using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class PointsController : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField _localVariableInput;
    [SerializeField] private TextMeshProUGUI _localVariableText;
    [SerializeField] private TextMeshProUGUI _redVariableText;

    public string TakeRivalData = "0";

    public void CambiarValor()
    {
        string value = _localVariableInput.text; //se coge el valor del cuadro de texto
        _localVariableText.text = value; //se le asigna la variable al jugador local

        //cambiamos al otro jugador
        photonView.RPC(nameof(CambiarValorEnRed), RpcTarget.OthersBuffered, value);
    }

    void CambiarValorEnRed(string variable)
    {
        _redVariableText.text = variable ; //cambiamos el texto del otro jugador
    }



    
}
