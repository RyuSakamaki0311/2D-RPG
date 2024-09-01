using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    // ゲームステート
    public GameState State { get; private set; } = GameState.None;
    // プレイデ―タ
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
    /// ステートの変更をする
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
    /// シーンのロード
    /// </summary>
    private void ChangeScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

    /// <summary>
    /// セーブデータのセット
    /// </summary>
    public void SetData(PlayData playData)
    {
        PlayData = playData;
    }
}
