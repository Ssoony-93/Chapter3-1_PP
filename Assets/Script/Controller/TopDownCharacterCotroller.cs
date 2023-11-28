using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TopDownCharacterCotroller : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector3> OnLookEvent;


    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}


    ////[SerializeField] private float speed = 10f;

    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    // drag, Ctrl + K C 주석  // K U  주석풀기
    //    //float x = Input.GetAxisRaw("Horizontal");
    //    //float y = Input.GetAxisRaw("Vertical");

    //    //transform.position += new Vector3(x, y) * speed* Time.deltaTime;
    //}

