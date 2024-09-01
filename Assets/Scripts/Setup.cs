using UnityEngine;

/// <summary>
/// ゲームの初期化を行うクラス
/// </summary>
public class Setup : MonoBehaviour
{
    [SerializeField]
    private bool _exitSetup = false;

    public bool EndSetup { get; private set; } = false;

    private void Start()
    {
        if (_exitSetup)
        {
            EndSetup = true;
        }
    }

    private void Update()
    {
        if (EndSetup)
        {
            // セットアップが終了していたらタイトルシーンのロード
            GameManager.Instance.ChangeState(GameState.Title);
        }
    }
}
