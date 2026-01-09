using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimations : MonoBehaviour
{
    public InputActionAsset sillyPlayerAction;
    public Animator sillyAnimator;
    
    
    // Update is called once per frame
    void Update()
    {
        if (sillyAnimator.FindAction("AniW").IsPressed())
        {
            sillyAnimator.SetBool("Walk, true");
        }
        else
            sillyAnimator.SetBool("Walk, false");
    }
}
