using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float speed ;

    private PlayerInput inputActions;
    private Vector2 moveInput;

    [SerializeField]
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created



    // Update is called once per frame
    void Update()
    {
        MovimentPlayer();
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void MoveTeste()
    {


    }


    void MovimentPlayer()

    {

        Vector2 movement = new Vector2(moveInput.x, moveInput.y);
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);



    }




}
