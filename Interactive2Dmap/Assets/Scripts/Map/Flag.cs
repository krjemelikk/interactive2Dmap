using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Flag : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Color _color;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _color = new Color(170, 0, 0);

    }

    private void OnEnable()
    {
        _spriteRenderer.color = Color.white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlaceParameters>(out PlaceParameters placeParameters))
        {
            _spriteRenderer.color = _color;
        }
    }
}
