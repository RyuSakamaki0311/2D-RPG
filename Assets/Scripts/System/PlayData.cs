using System;

[Serializable]
public class PlayData
{
    public PlayData(string name, string createTime)
    {
        Name = name;
        CreateTime = createTime;
    }

    // ���O
    public string Name;
    // �쐬��������
    public string CreateTime;
    // �Z�[�u��������
    public string lastSaveTime;
}
