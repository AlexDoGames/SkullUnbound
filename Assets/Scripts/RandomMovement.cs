using UnityEngine;

public class RandomMovement : StateMachineBehaviour
{
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        animator.SetInteger("idleID", Random.Range(0, 5));
    }

}
