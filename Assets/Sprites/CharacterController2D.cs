using UnityEngine;
using UnityEngine.InputSystem;
public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D RB2D;
    private float xDirection;
    private float yDirection;
    [SerializeField] private float speed;
    private void Awake()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }
    public void XDirection(InputAction.CallbackContext context)
    {
        xDirection = context.ReadValue<float>();
    }
    public void YDirection(InputAction.CallbackContext context)
    {
        yDirection = context.ReadValue<float>();
    }
    private void FixedUpdate()
    {
        RB2D.velocity = new Vector2(xDirection * speed, yDirection * speed);
    }
}
