using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreate : MonoBehaviour
{
    // Start is called before the first frme update
    private float moveSpeed;

    void Start()
    {
        moveSpeed = 2;
    }
  
    void Update()
    {
        transform.Translate(-1 * Time.deltaTime * moveSpeed, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("WallReset"))
        {
            transform.position = new Vector3(4, Random.Range(1, 4), 0);
        }
    }


}
