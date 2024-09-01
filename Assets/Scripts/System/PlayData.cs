using System;

[Serializable]
public class PlayData
{
    public PlayData(string name, string createTime)
    {
        Name = name;
        CreateTime = createTime;
    }

    // 名前
    public string Name;
    // 作成した時間
    public string CreateTime;
    // セーブした時間
    public string lastSaveTime;
}
