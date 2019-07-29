using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject gameController;
    public float power = 20f;
    private AudioSource audioSource;
    public AudioClip birdFly;

    void Start()
    { 
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = birdFly;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)  && !gameController.GetComponent<GameController>().gameOver)
        {
           audioSource.Play();
           GetComponent<Rigidbody2D>().AddForce(new Vector2(0, power));
        }
        if(transform.position.y > 6)
        {
            gameController.GetComponent<GameController>().gameOver = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.GetComponent<GameController>().UpdateScore();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameController.GetComponent<GameController>().GameOver();
    }
}
