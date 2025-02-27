using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField]
    private float movmentSpeed = 5f;

    private PlayerInput playerInput;
    void Awake()
    {
        playerInput = new PlayerInput();   
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }
    private void OnMove()
    {
       
    }

    void Update()
    {
        Vector2 inputVector = playerInput.MainControls.Move.ReadValue<Vector2>();
        Vector3 movmentVector = new Vector3(inputVector.x, 0f, inputVector.y).normalized;

        transform.Translate(movmentVector * movmentSpeed * Time.deltaTime);
    }
}
