using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControl : MonoBehaviour
{
    [SerializeField] private Flag _flag;

    public void OpenMap()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void CloseMap()
    {
        _flag.gameObject.SetActive(false);
        
        transform.GetChild(0).gameObject.SetActive(false);

    }

}
