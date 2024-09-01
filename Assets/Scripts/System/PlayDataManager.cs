using UnityEngine;

/// <summary>
/// ゲームのデータを管理するクラス
/// </summary>
public class PlayDataManager
{
    // plafsのキー
    private readonly string SAVE_DATA_KEY = "SaveData";

    /// <summary>
    /// 新規データの作成
    /// </summary>
    public void CreateNewData(string name, string createDate)
    {
        // 新規データのインスタンス
        var data = new PlayData(name, createDate);
        GameManager.Instance.SetData(data);
    }

    /// <summary>
    /// 保存されているセーブデータの取得
    /// </summary>
    public PlayData GetData()
    {
        // データがある
        if (PlayerPrefs.HasKey(SAVE_DATA_KEY))
        {
            var json = PlayerPrefs.GetString(SAVE_DATA_KEY);
            return JsonUtility.FromJson<PlayData>(json);
        }
        else
        {
            Debug.Log("セーブデータ無し");
            return null;
        }
    }

    /// <summary>
    /// データの保存
    /// </summary>
    public void SaveData(PlayData playData)
    {
        var json = JsonUtility.ToJson(playData);
        PlayerPrefs.SetString(SAVE_DATA_KEY, json);
        Debug.Log("データの保存完了");
    }
}