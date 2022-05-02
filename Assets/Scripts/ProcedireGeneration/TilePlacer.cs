using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePlacer : MonoBehaviour
{
    [SerializeField] private List<Tile> _allTiles;
    public Vector2Int MapSize = new Vector2Int(10, 10);
    private Tile[,] _spawnedTiles;

    private void Start()
    {
        _spawnedTiles = new Tile[MapSize.x, MapSize.y];
        StartCoroutine(GenerateLevel());
    }

    private void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopAllCoroutines();

            foreach (Tile spawnedTile in _spawnedTiles)
                if (spawnedTile != null) Destroy(spawnedTile.gameObject);
        }
        */
    }

    public IEnumerator GenerateLevel()
    {
        for (int y = 1; y < MapSize.y - 1; y++)
            for (int x = 1; x < MapSize.x - 1; x++)
            {
                Debug.Log("x" + x);
                Debug.Log("y" + y);
                PlaceTile(x, y);
                yield return new WaitForSeconds(0.02f);
            }
    }

    private void PlaceTile(int x, int y)
    {
        List<Tile> availableTiles;

        if (_spawnedTiles[x - 1, y] == null && _spawnedTiles[x, y - 1] == null)
            availableTiles = _allTiles;
        else
            availableTiles = _spawnedTiles[x - 1, y].GetAvailableRightTiles;

        if (availableTiles == null) return;

        Tile selectedTile = availableTiles[Random.Range(0, availableTiles.Count - 1)];

        Debug.Log(_spawnedTiles.Length);
        // _spawnedTiles[1, 1] = 
        Instantiate(selectedTile, new Vector3(x, y, 0), Quaternion.identity);

    }
}

