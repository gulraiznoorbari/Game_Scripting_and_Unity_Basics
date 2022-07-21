using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private CharacterAnimationController _animationController;

    // Start is called before the first frame update
    void Start()
    {
        _animationController = new CharacterAnimationController(_animator);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            _animationController.PlayAnimation(AnimationType.Idle);
        }
        else if (Input.GetKey(KeyCode.S)){
            _animationController.PlayAnimation(AnimationType.Taunt);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)){
            _animationController.PlayAnimation(AnimationType.TurnLeft);
        }
        else if (Input.GetKey(KeyCode.D)){
            _animationController.PlayAnimation(AnimationType.Walk);
        }
        else if (Input.GetKey(KeyCode.F)){
            _animationController.PlayAnimation(AnimationType.Attack);
        }
        else if (Input.GetKey(KeyCode.RightArrow)){
            _animationController.PlayAnimation(AnimationType.TurnRight);
        }
        else if (Input.GetKey(KeyCode.G)){
            _animationController.PlayAnimation(AnimationType.Crouch);
        }
    }
}
