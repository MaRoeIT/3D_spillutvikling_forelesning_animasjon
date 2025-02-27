using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    private float distanceToGround;
    private bool isWalking = false;

    private void Start()
    {
       
    }

    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        

        inputVector = inputVector.normalized;
        Vector3 movementVector = new Vector3(inputVector.x, 0f, inputVector.y);

        if (movementVector == Vector3.zero)
        {
            isWalking = false;
        }
        else
        {
            isWalking = true;
        }

        // Roterer karakteren v�r
        //transform.forward = Vector3.Slerp(transform.forward, movementVector, Time.deltaTime * rotationSpeed);

        transform.position += movementVector * movementSpeed * Time.deltaTime;
    }

    public bool IsWalking()
    {
        return isWalking;
    }   
}
