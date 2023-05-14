using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : Notations
{
    [Space]
    [SerializeField] protected Button BuyButton;
    [Space]
    [SerializeField] protected string UpgradeName;
    [Space]
    [SerializeField] protected float UpgradeMultiply;
    [SerializeField] protected float PriceMultiply;
    [SerializeField] protected float UpgradePrice;
    [Space]
    protected int Level = 1;
    [Space]
    [SerializeField] protected AudioSource PurchaseSFX;
    [Space]
    [SerializeField] protected MoneyEarn MoneyEarn;
    [Space]
    [SerializeField] protected TextMeshProUGUI ImprovedValueText;
    [SerializeField] protected TextMeshProUGUI PriceText;
    [SerializeField] protected TextMeshProUGUI LevelText;

    private void Start()
    {
        BuyButton = GetComponent<Button>();
        MoneyEarn = FindObjectOfType<MoneyEarn>();
    }
    public void UpdateUpgrade()
    {
        PurchaseSFX.Play();
        MoneyEarn.instance.Money -= UpgradePrice;
        UpgradePrice *= PriceMultiply;
        Level++;
    }
}
