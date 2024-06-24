using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float gravity;
    [SerializeField] private Vector2 velocity;
    [SerializeField] private float jumpVelocity = 20f;

    private readonly float _groundHeight = 10f;

    public bool IsGrounded { get; private set; } = false;

    public void ChangeVelocityByYAxis()
    {
        IsGrounded = false;
        velocity.y = jumpVelocity;
    }

    private void FixedUpdate()
    {
        Vector2 position = transform.position;

        if (!IsGrounded)
        {
            position.y += velocity.y * Time.fixedDeltaTime;
            velocity.y += gravity * Time.fixedDeltaTime;

            if (position.y <= _groundHeight)
            {
                position.y = _groundHeight;
                IsGrounded = true;
            }
        }

        transform.position = position;
    }
}
