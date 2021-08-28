using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HeroLife : MonoBehaviour
{
    public static Action<int> ChangeLife;
    public static Action DeathAction;
    public static Action OpenUi;
    private bool openedUi = false;
    [SerializeField] private int heroLife;
    private Animator animator;


    private void OnEnable()
    {
        ChangeLife += Damage;   
    }
    private void OnDisable()
    {
        ChangeLife -= Damage;
    }
    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        Death();
    }

    private void Damage(int damage)
    {
        this.heroLife -= damage;
    }

    private void Heal(int heal)
    {
        this.heroLife += heal;
    }

    public int GetLife()
    {
        return this.heroLife;
    }

    private void Death()
    {
        if (heroLife <= 0 && openedUi == false)
        {
            DeathAction();
            Invoke("DeathActionUi", 2f);
        }
    }

    private void DeathActionUi()
    {
        openedUi = true;
        OpenUi();
    }
}
