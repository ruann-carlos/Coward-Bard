using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonBehavior : MonoBehaviour
{
    [SerializeField] private float dragonSpeed;
    [SerializeField] private Animator animator;


    void Update()
    {
        Move();   
    }

    private void Move() => this.transform.position = new Vector2(this.transform.position.x + dragonSpeed * Time.deltaTime, this.transform.position.y);

}
