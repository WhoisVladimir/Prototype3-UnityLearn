using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    PlayerController playerController;
    public float speed;
    float leftBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.isGameOver == false) transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) Destroy(gameObject);
    }
}
