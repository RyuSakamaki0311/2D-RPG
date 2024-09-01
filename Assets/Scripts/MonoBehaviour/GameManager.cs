using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    // �Q�[���X�e�[�g
    public GameState State { get; private set; } = GameState.None;
    // �v���C�f�\�^
    public PlayData PlayData { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (Instance != this)
            {
                Destroy(gameObject);
                return;
            }
        }

        State = GameState.Setup;
    }

    /// <summary>
    /// �X�e�[�g�̕ύX������
    /// </summary>
    /// <param name="next"></param>
    public void ChangeState(GameState next)
    {
        switch (next)
        {
            case GameState.None:
                break;
            case GameState.Setup:
                break;
            case GameState.Title:
                ChangeScene("Title");
                break;
            case GameState.Main:
                break;
        }

        State = next;
    }

    /// <summary>
    /// �V�[���̃��[�h
    /// </summary>
    private void ChangeScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

    /// <summary>
    /// �Z�[�u�f�[�^�̃Z�b�g
    /// </summary>
    public void SetData(PlayData playData)
    {
        PlayData = playData;
    }
}
