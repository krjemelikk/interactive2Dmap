using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceParameters : MonoBehaviour
{
    [SerializeField] private Transform _spawnpoint;
    [SerializeField] private GameObject _placeTilemap;
    [SerializeField] private MapPlaceLoader _placeLoader;

    private bool[] _allIn = new bool[2] { false, false }; 


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<MapPlayerMoveController>(out MapPlayerMoveController mapPlayerController))
            _allIn[0] = true;

        if (collision.gameObject.TryGetComponent<Flag>(out Flag flag))
            _allIn[1] = true;

        if(_allIn[0] && _allIn[1]) 
        {
            _placeLoader.LoadPlace(_spawnpoint, _placeTilemap);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<MapPlayerMoveController>(out MapPlayerMoveController mapPlayerController))
            _allIn[0] = false;

        if (collision.gameObject.TryGetComponent<Flag>(out Flag flag))
            _allIn[1] = false;
    }
}