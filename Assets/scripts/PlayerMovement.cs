using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float speed =5f;

    private PlayerInput inputActions;
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {

        inputActions = new PlayerInput();
        inputActions.Player.move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        inputActions.Player.move.canceled += ctx => moveInput = Vector2.zero;


    }
    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }



    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(moveInput.x, moveInput.y, 0f);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
