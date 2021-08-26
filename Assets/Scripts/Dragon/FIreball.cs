using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIreball : MonoBehaviour
{
    [SerializeField] private float attackSpeed;
    [SerializeField] private float attackTime;
    [SerializeField] private int damage;

    void Start()
    {
        StartCoroutine(FireTime());
    }

    void FixedUpdate()
    {
        FireballAttack();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<HeroLife>())
        {
            HeroLife.ChangeLife(damage);
            Destroy(this.gameObject);
        }
    }
    private void FireballAttack()
    {
        Vector2 pos = this.transform.position;

        pos.x += attackSpeed * Time.fixedDeltaTime;

        this.transform.position = pos;
    }

    private IEnumerator FireTime()
    {
        yield return new WaitForSeconds(attackTime);

        Destroy(this.gameObject);
    }
}
