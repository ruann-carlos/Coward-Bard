using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUi : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private HeroLife hero;
    [SerializeField] private GameObject deathScreen;
    private int maxLife;

    private void OnEnable()
    {
        HeroLife.ChangeLife += SetLifeSlider;
        HeroLife.OpenUi += OpenDeathScreen;
        RestartGame.CloseDeathUi += CloseDeathUI;
    }

    private void OnDisable()
    {
        HeroLife.ChangeLife -= SetLifeSlider;
        HeroLife.OpenUi -= OpenDeathScreen;
        RestartGame.CloseDeathUi -= CloseDeathUI;
    }

    private void SetLifeSlider(int life) 
    {
        slider.value -= life;
    }
    
    void Start()
    {
        maxLife = hero.GetLife();
        slider.maxValue = maxLife;
        slider.value = maxLife;
    }

    private void OpenDeathScreen()
    {
        deathScreen.SetActive(true);
        Time.timeScale = 0;
    }

    private void CloseDeathUI()
    {
        deathScreen.SetActive(false);
    }

}
