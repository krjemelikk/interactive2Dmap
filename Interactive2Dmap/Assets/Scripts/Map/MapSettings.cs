using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSettings : MonoBehaviour
{
    private Vector2 _topLeft, _bottomRight;
    private SpriteRenderer _spriteRenderer;

    public Vector2 topLeft => _topLeft;
    public Vector2 bottomRight => _bottomRight;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        FindCorners(_spriteRenderer);
    }

    private void FindCorners(SpriteRenderer renderer)
    {
        _bottomRight = renderer.transform.TransformPoint(new Vector3(renderer.sprite.bounds.max.x, renderer.sprite.bounds.min.y, 0));
        _topLeft = renderer.transform.TransformPoint(new Vector3(renderer.sprite.bounds.min.x, renderer.sprite.bounds.max.y, 0));

    }

}
