using Photon.Realtime; 
using UnityEngine;
using Photon.Pun;
using TMPro;

public class MainMenu : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField _createRoomInputField;
    [SerializeField] private TMP_InputField _joinRoomInputField;

    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(_createRoomInputField.text, roomOptions);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(_joinRoomInputField.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
