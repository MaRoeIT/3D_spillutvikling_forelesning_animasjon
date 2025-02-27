using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    // Need refferance to animator component
    private Animator animator;

    [SerializeField] public PlayerMovment player;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(player.IsWalking() == true)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }

    // Need a refferance to our player to look for input

    // On every frame we wan't to se if something is pressed

    // If no button is pressed, set isWalking to false
    // If WASD is pressed, set isWalking to true
}
