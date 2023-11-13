using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRenderer;
    public float speed;
    public int directionX;
    public int directionY;
    void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + speed * directionX * Time.deltaTime, _compTransform.position.y + speed * directionY * Time.deltaTime);

        if (_compTransform.position.x > 10.26 && directionX == 1)
        {
            directionX = -1;
            _compSpriteRenderer.flipX = true;
        }
        else if (_compTransform.position.x < -10.26 && directionX == -1)
        {
            directionX = 1;
            _compSpriteRenderer.flipX = false;
        }

        if (_compTransform.position.y > 2.26 && directionY == 1)
        {
            directionY = -1;
            _compSpriteRenderer.flipY = true;
        }
        else if (_compTransform.position.y < -2.26 && directionY == -1)
        {
            directionY = 1;
            _compSpriteRenderer.flipY = false;
        }
    }
}
