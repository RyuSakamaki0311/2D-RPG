using UnityEngine;

/// <summary>
/// �Q�[���̏��������s���N���X
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
            // �Z�b�g�A�b�v���I�����Ă�����^�C�g���V�[���̃��[�h
            GameManager.Instance.ChangeState(GameState.Title);
        }
    }
}
