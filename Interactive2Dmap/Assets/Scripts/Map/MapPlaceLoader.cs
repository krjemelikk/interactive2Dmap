using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPlaceLoader : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private MapControl _mapControl;
    [SerializeField] private GameObject _currentTilemap;

    public void LoadPlace(Transform spawnpoint, GameObject Place)
    {
        _player.transform.position = spawnpoint.position;

        if (_currentTilemap != null)
            _currentTilemap.SetActive(false);

        _currentTilemap = Place;
        Place.SetActive(true);

        _mapControl.CloseMap();

    }
}
