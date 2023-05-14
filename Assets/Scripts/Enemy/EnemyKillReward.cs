using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKillReward : MonoBehaviour
{
    public static EnemyKillReward instance;

    public float KillReward;

    private void Awake()
    {
        instance = this;
        KillReward = PlayerPrefs.GetFloat("Enemy reward");
    }
}
