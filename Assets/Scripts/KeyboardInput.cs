using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    private PlayerMovement _movement;

    private void Start()
    {
        _movement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _movement.IsGrounded)
        {
            _movement.ChangeVelocityByYAxis();
        }
    }
}