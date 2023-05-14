using System.Runtime.InteropServices;
using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
    public int HighestScore;
}

public class Progress : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void SaveExtern(string date);
    [DllImport("__Internal")]
    private static extern void LoadExtern();

    public static Progress instance;
    public PlayerInfo PlayerInfo;
    private void Awake()
    {
        if (instance == null)
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            instance = this;
            LoadExtern();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Save()
    {
        string jsonString = JsonUtility.ToJson(PlayerInfo);
        SaveExtern(jsonString);
    }
    public void SetPlayerInfo(string value)
    {
        PlayerInfo = JsonUtility.FromJson<PlayerInfo>(value);
    }
}
