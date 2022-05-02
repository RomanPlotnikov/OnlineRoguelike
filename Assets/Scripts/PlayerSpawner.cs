using UnityEngine;
using Photon.Pun;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private Vector2 _minimumSpawnpoint;
    [SerializeField] private Vector2 _maximumSpawnpoint;
 
    private void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(_minimumSpawnpoint.x, _maximumSpawnpoint.x),
            Random.Range(_minimumSpawnpoint.y, _maximumSpawnpoint.y));
        PhotonNetwork.Instantiate(_playerPrefab.name, randomPosition, Quaternion.identity);
    }
}
