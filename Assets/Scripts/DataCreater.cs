using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �V�K�f�[�^���쐬����N���X
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
    /// ������
    /// </summary>
    private void Init()
    {
        _dataMana = new PlayDataManager();

        if (_submitButton)
        {
            // ����{�^��
            _submitButton.onClick.AddListener(() =>
            {
                // �ۑ��f�[�^���Ȃ�
                if (_inputField.text.Length >= 1)
                {
                    var name = _inputField.text;
                    var date = DateTime.Now.ToString();
                    _dataMana.CreateNewData(name, date);
                    Debug.Log($"�V�K�f�[�^�쐬 time:{date}");
                }
                else
                {
                    Debug.Log("����������Ȃ�");
                }
            });
        }
    }
}
