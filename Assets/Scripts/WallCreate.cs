using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreate : MonoBehaviour
{
    // Start is called before the first frme update
    private float moveSpeed = 2;
    private float oldPosition = 4;
    private Vector3 fristPosition;

    void Start()
    {
        fristPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(-1 * Time.deltaTime * moveSpeed, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("WallReset"))
        {
            transform.position = new Vector3(oldPosition, Random.Range(1, 4), 0);
        }
    }


}
