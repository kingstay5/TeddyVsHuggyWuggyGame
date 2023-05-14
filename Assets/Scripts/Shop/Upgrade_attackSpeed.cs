using UnityEngine;

public class Upgrade_attackSpeed : Upgrade
{
    private void Update()
    {
        ImprovedValueText.text = RocketSpawn.instance.AttackSpeed.ToString("F1");
        PriceText.text = Notation(UpgradePrice, "F1");
        LevelText.text = Level.ToString();
        PriceCheck();
    }
    public void AttackSpeedUpgrade()
    {
        if (MoneyEarn.Money >= UpgradePrice)
        {
            UpdateUpgrade();
            RocketSpawn.instance.AttackSpeed = PlayerPrefs.GetFloat(UpgradeName);
            PlayerPrefs.SetFloat(UpgradeName, RocketSpawn.instance.AttackSpeed * UpgradeMultiply);
        }
    }

    public void StatsUpdate()
    {
        RocketSpawn.instance.AttackSpeed = PlayerPrefs.GetFloat("Attack speed");
    }

    private void PriceCheck()
    {
        if (MoneyEarn.instance.Money >= UpgradePrice)
        {
            BuyButton.interactable = true;
        }
        else { BuyButton.interactable = false; }
    }
}
