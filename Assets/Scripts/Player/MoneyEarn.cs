using TMPro;
using UnityEngine;

public class MoneyEarn : Notations
{
    public static MoneyEarn instance;

    [SerializeField] private TextMeshProUGUI _hudMoneyText;
    [SerializeField] private TextMeshProUGUI _shopMoneyText;
    [SerializeField] private AudioSource _enemyDeathSFX;
    [SerializeField] private Animator _anim;
    public float Money;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        _hudMoneyText.text = Notation(Money, "F1");
        _shopMoneyText.text = Notation(Money, "F1");
    }
    public void KillReward()
    {
        _anim.SetTrigger("Shake");
        _enemyDeathSFX.Play();
        Money += EnemyKillReward.instance.KillReward;
        HighScore.instance.AddScore();
        HighScore.instance.AddHighScore();
    }
}
