using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 新規データを作成するクラス
/// </summary>
public class DataCreater : MonoBehaviour
{
    [SerializeField]
    private InputField _inputField;

    [SerializeField]
    private Button _submitButton;

    private PlayDataManager _dataMana;

    void Start()
    {
        Init();
    }

    /// <summary>
    /// 初期化
    /// </summary>
    private void Init()
    {
        _dataMana = new PlayDataManager();

        if (_submitButton)
        {
            // 決定ボタン
            _submitButton.onClick.AddListener(() =>
            {
                // 保存データがない
                if (_inputField.text.Length >= 1)
                {
                    var name = _inputField.text;
                    var date = DateTime.Now.ToString();
                    _dataMana.CreateNewData(name, date);
                    Debug.Log($"新規データ作成 time:{date}");
                }
                else
                {
                    Debug.Log("文字が足りない");
                }
            });
        }
    }
}
