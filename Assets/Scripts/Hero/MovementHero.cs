using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementHero : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;
    private Rigidbody2D playerRgbd;
    // Start is called before the first frame update
    void Start()
    {
        playerRgbd = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        playerRgbd.transform.position = new Vector2(playerRgbd.transform.position.x + speed * Time.deltaTime, playerRgbd.position.y);
    }
}
