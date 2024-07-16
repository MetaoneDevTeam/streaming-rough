using UnityEditor.Animations;
using UnityEngine;
using Unity.Mathematics;

public class MoveState : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float3 _inputDirection;

        _inputDirection = CameraManager.instance.transform.forward * InputManager.instance.lVertical +
                          CameraManager.instance.transform.right * InputManager.instance.lHorizontal;
        
        //_inputDirection.x = InputManager.instance.lNormalized.x;
        //_inputDirection.z = InputManager.instance.lNormalized.y;
        //_inputDirection.y = 0f;

        float _previousForwardSpeed = animator.GetFloat("ForwardSpeed");
        float _forwardSpeed;

        float _previousTurnSpeed = animator.GetFloat("TurnSpeed");
        
        _forwardSpeed = math.length(_inputDirection);

        _inputDirection = math.normalizesafe(_inputDirection, CameraManager.instance.transform.forward);

        float3 _playerForward = animator.transform.forward;
        float3 _playerRight = animator.transform.right;

        // getting linear dot value

        float _dot = math.dot(_inputDirection, _playerForward);
        //Debug.Log("PRE : " + _dot);
        //float _dotSign = math.sign(_dot);

        //_dot = _dot * _dot;  // turns negative value positive
        //Debug.Log("MID : " + _dot);

        _dot = math.angle(quaternion.LookRotation(_inputDirection, math.up()),
            Quaternion.LookRotation(_playerForward, math.up()));
        /*
        if (_dotSign > 0f) _dot += 1f;
        
        _dot = 1f - (_dot - 1.0f) * 0.5f;
        Debug.Log("POST : " + _dot);
*/
        float _sign = math.sign(math.dot(_inputDirection, _playerRight));
        float _turnSpeed = _sign * _dot;

        _forwardSpeed = math.lerp(_previousForwardSpeed, _forwardSpeed, Time.deltaTime * 10f);
        _turnSpeed = math.lerp(_previousTurnSpeed, _turnSpeed, Time.deltaTime * 5f);
        
        animator.SetFloat("ForwardSpeed", _forwardSpeed);
        animator.SetFloat("TurnSpeed", _turnSpeed);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.position += animator.deltaPosition;
        animator.transform.rotation *= animator.deltaRotation;

        CameraManager.instance.transform.position = animator.transform.position;

        //InputManager.instance.lNormalized.x 
        //    // Implement code that processes and affects root motion
    }

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
