using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownCharacterCotroller _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterCotroller>();
    }


    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirecrtion)
    {
        RotateArm(newAimDirecrtion);
    }

    private void RotateArm(Vector2 direcrtion)
    {
        float rotZ = Mathf.Atan2(direcrtion.y, direcrtion.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
