// using System.Collections.Generic;
// using UnityEngine;

// public class TileGenerator : MonoBehaviour
// {
//     [SerializeField] private Tile _firstTile;
//     [SerializeField] private Vector2 _tileSise;
//     [SerializeField] private Transform _parentTransform;
// 
//     private void Start()
//     {
//         if (_firstTile == null)
//         {
//             Debug.Log($"FirstTile field is empty in {this}");
//         }
//         GenerateLevel(10, 10);
//     }

//     public void GenerateLevel(int horizontalTiles, int verticalTiles)
//     {
//         Instantiate(_firstTile, _parentTransform);
//         for (int i = 0; i < horizontalTiles; i++)
//         {
//             Instantiate(_firstTile.GetAvailableRightSprites[Random.Range(0, _firstTile.GetAvailableRightSprites.Count)],
//             (Vector2)_parentTransform.position + Vector2.right * i, Quaternion.identity);

//             for (int k = 1; i < verticalTiles; k++)
//                 Instantiate(_firstTile.GetAvailableRightSprites[Random.Range(0, _firstTile.GetAvailableRightSprites.Count)],
//             (Vector2)_parentTransform.position + Vector2.down * k, Quaternion.identity);
//         }
//     }
// }
