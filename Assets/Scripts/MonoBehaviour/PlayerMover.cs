using UnityEngine;

/// <summary>
/// PlayerÇÃà⁄ìÆÇêßå‰Ç∑ÇÈÉNÉâÉX
/// </summary>
public class PlayerMover : MonoBehaviour
{
    [SerializeField]
    private float _walkSpeed;

    [SerializeField]
    private Rigidbody2D _rb2d;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _rb2d.gravityScale = 0f;
    }

    void Start()
    {

    }

    void Update()
    {
        Walk();
    }

    /// <summary>
    /// ï‡Ç≠
    /// </summary>
    private void Walk()
    {
        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");
        var dir = h * Vector2.right + v * Vector2.up;

        if (dir != Vector2.zero)
        {
            var velo = dir * _walkSpeed;
            _rb2d.velocity = velo;
        }
        else
        {
            _rb2d.velocity = Vector2.zero;
        }
    }
}
