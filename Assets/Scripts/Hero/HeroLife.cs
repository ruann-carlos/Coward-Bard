using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HeroLife : MonoBehaviour
{
    public static Action<int> ChangeLife;
    [SerializeField] private int heroLife;

    private void OnEnable()
    {
        ChangeLife += Damage;   
    }
    private void OnDisable()
    {
        ChangeLife -= Damage;
    }

    private void Damage(int damage)
    {
        this.heroLife -= damage;
    }

    private void Heal(int heal)
    {
        this.heroLife += heal;
    }
}
