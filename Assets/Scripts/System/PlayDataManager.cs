using UnityEngine;

/// <summary>
/// �Q�[���̃f�[�^���Ǘ�����N���X
/// </summary>
public class PlayDataManager
{
    // plafs�̃L�[
    private readonly string SAVE_DATA_KEY = "SaveData";

    /// <summary>
    /// �V�K�f�[�^�̍쐬
    /// </summary>
    public void CreateNewData(string name, string createDate)
    {
        // �V�K�f�[�^�̃C���X�^���X
        var data = new PlayData(name, createDate);
        GameManager.Instance.SetData(data);
    }

    /// <summary>
    /// �ۑ�����Ă���Z�[�u�f�[�^�̎擾
    /// </summary>
    public PlayData GetData()
    {
        // �f�[�^������
        if (PlayerPrefs.HasKey(SAVE_DATA_KEY))
        {
            var json = PlayerPrefs.GetString(SAVE_DATA_KEY);
            return JsonUtility.FromJson<PlayData>(json);
        }
        else
        {
            Debug.Log("�Z�[�u�f�[�^����");
            return null;
        }
    }

    /// <summary>
    /// �f�[�^�̕ۑ�
    /// </summary>
    public void SaveData(PlayData playData)
    {
        var json = JsonUtility.ToJson(playData);
        PlayerPrefs.SetString(SAVE_DATA_KEY, json);
        Debug.Log("�f�[�^�̕ۑ�����");
    }
}