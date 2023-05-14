using UnityEngine;

public class Upgrade_damage : Upgrade
{
    private void Update()
    {
        ImprovedValueText.text = RocketDamage.instance.Damage.ToString("F1");
        PriceText.text = Notation(UpgradePrice, "F1");
        LevelText.text = Level.ToString();
        PriceCheck();
    }
    public void DamageUpgrade()
    {
        if (MoneyEarn.instance.Money >= UpgradePrice)
        {
            UpdateUpgrade();
            PlayerPrefs.SetFloat(UpgradeName, RocketDamage.instance.Damage * UpgradeMultiply);
        }
    }
    public void StatsUpdate()
    {
        RocketDamage.instance.Damage = PlayerPrefs.GetFloat("Hero damage");
    }
    private void PriceCheck()
    {
        if (MoneyEarn.instance.Money >= UpgradePrice)
        {
            BuyButton.interactable = true;
        }
        else { BuyButton.interactable = false;}
    }
}
