using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    [DllImport("__Internal")]
    public static extern void SetToLeaderboard(int value);
    public static HighScore instance;
    [SerializeField] private int _score;
    [SerializeField] private int _highScore;
    [SerializeField] private TextMeshProUGUI _highScoreText;
    private void Awake()
    {
        instance = this;
        _highScore = Progress.instance.PlayerInfo.HighestScore;
        _highScoreText.text = _highScore.ToString();
    }

    public void AddScore()
    {
        _score++;
    }

    public void AddHighScore()
    {
        if (_score > Progress.instance.PlayerInfo.HighestScore)
        {
            Progress.instance.PlayerInfo.HighestScore = _score;
            SetToLeaderboard(Progress.instance.PlayerInfo.HighestScore);
            _highScoreText.text = Progress.instance.PlayerInfo.HighestScore.ToString();
            Progress.instance.Save();
        }
    }
}
