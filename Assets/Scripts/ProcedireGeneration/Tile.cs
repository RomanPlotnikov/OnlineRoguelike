using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Sprite _currentSprite;

    [SerializeField] private List<Tile> _availableTopTiles;
    [SerializeField] private List<Tile> _availableRightTiles;
    [SerializeField] private List<Tile> _availableDownTiles;
    [SerializeField] private List<Tile> _availableLeftTiles;

    public List<Tile> GetAvailableTopTiles => _availableTopTiles;
    public List<Tile> GetAvailableRightTiles => _availableRightTiles;
    public List<Tile> GetAvailableDownTiles => _availableDownTiles;
    public List<Tile> GetAvailableLeftTiles => _availableLeftTiles;

    private void Start()
    {
        if (_currentSprite == null)
        {
            Debug.Log($"Field CurrentSprite in {this} is empty");
            _currentSprite = GetComponent<SpriteRenderer>().sprite;
            _currentSprite = GetComponentInChildren<SpriteRenderer>().sprite;
        }
    }
}
