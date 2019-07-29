using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMove : MonoBehaviour
{
    private float moveSpeed;
    private Vector3 fristPosition;

    void Start()
    {
        fristPosition =transform.position;
        moveSpeed = 2f;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * Time.deltaTime * moveSpeed, 0, 0);
        if (Vector3.Distance(fristPosition, transform.position) > 50)
        {
            SceneManager.LoadScene(0);
        }
    }
}
