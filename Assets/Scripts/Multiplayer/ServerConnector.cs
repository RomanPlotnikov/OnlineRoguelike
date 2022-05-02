using UnityEngine.SceneManagement;
using UnityEngine;
using Photon.Pun;

public class ServerConnector : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
