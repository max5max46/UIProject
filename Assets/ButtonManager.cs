using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI adobeButtonText;
    public TextMeshProUGUI subtractMoneyButtonText;
    public GameObject settingMenu;

    double money;

    bool isSettingMenuOpen;
    bool isAdobeModeOn;

    private void Start()
    {
        money = 7923160.72;
        moneyText.text = "Money: " + money.ToString("F2") + "$";
        isSettingMenuOpen = false;
        isAdobeModeOn = false;
        settingMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void SettingMenu()
    {
        if (isSettingMenuOpen)
        {
            settingMenu.SetActive(false);
            isSettingMenuOpen = false;
        }
        else
        {
            if (!isSettingMenuOpen)
            {
                settingMenu.SetActive(true);
                isSettingMenuOpen = true;
            }
        }
    }

    public void AdobeMode()
    {
        if (!isAdobeModeOn)
        {
            isAdobeModeOn = true;
            adobeButtonText.text = "What Adobe Thinks Mode (On)";
            subtractMoneyButtonText.text = "Work on making the price for Adobe Products the same world wide (-???$)";
        }
        else
        {
            if (isAdobeModeOn)
            {
                isAdobeModeOn = false;
                adobeButtonText.text = "What Adobe Thinks Mode (Off)";
                subtractMoneyButtonText.text = "Work on making the price for Adobe Products the same world wide (-0.01$)";
            }
        }
    }

    public void AddMoney()
    {
        money += 5;
        moneyText.text = "Money: " + money.ToString("F2") + "$";
    }

    public void SubtractMoney()
    {
        if (!isAdobeModeOn)
            money -= 0.01;

        if (isAdobeModeOn)
            money -= 9999999;

        if (money < 0) money = 0;
        moneyText.text = "Money: " + money.ToString("F2") + "$";
    }
}
