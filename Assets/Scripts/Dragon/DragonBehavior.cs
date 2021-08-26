using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonBehavior : MonoBehaviour
{
    [SerializeField] private float dragonSpeed;
    [SerializeField] private Animator animator;
    [SerializeField] private float attackPause;
    [SerializeField] private GameObject fireObject;
    [SerializeField] private float fireDistanceX;
    [SerializeField] private float fireDistanceY;

    private void Start()
    {
        StartCoroutine(Attack());
    }
    void Update()
    {
        Move();
    }

    private void Move() => this.transform.position = new Vector2(this.transform.position.x + dragonSpeed * Time.deltaTime, this.transform.position.y);

    private IEnumerator Attack()
    {
        while (true)
        {
            yield return new WaitForSeconds(attackPause);
            Vector3 pos = new Vector2(transform.position.x + fireDistanceX, transform.position.y - fireDistanceY);
            GameObject fire = Instantiate(fireObject, pos, Quaternion.identity);
            fire.transform.SetParent(this.transform, true);
        }
    }

}
