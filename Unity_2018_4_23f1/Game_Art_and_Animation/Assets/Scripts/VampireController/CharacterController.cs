using UnityEngine;
using DG.Tweening;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    private CharacterAnimationController _animationController;
    private Sequence _sequence;

    // Start is called before the first frame update
    void Start()
    {
        _animationController = new CharacterAnimationController(_animator);
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            PlayCharacterSequence();
        }
        //if (Input.GetKey(KeyCode.A)){
        //    _animationController.PlayAnimation(AnimationType.Idle);
        //}
        //else if (Input.GetKey(KeyCode.S)){
        //    _animationController.PlayAnimation(AnimationType.Taunt);
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow)){
        //    _animationController.PlayAnimation(AnimationType.TurnLeft);
        //}
        //else if (Input.GetKey(KeyCode.D)){
        //    _animationController.PlayAnimation(AnimationType.Walk);
        //}
        //else if (Input.GetKey(KeyCode.F)){
        //    _animationController.PlayAnimation(AnimationType.Attack);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow)){
        //    _animationController.PlayAnimation(AnimationType.TurnRight);
        //}
        //else if (Input.GetKey(KeyCode.G)){
        //    _animationController.PlayAnimation(AnimationType.Crouch);
        //}
    }
    private void PlayCharacterSequence()
    {
        transform.position = _startPoint.position;
        transform.rotation = _startPoint.rotation;
        _sequence?.Kill();
        _sequence = DOTween.Sequence()
            .AppendCallback(PlayWalkAnimation)
            .Join(transform.DOMove(_endPoint.position, 3f))
            .AppendCallback(PlayTauntAnimation)
            .AppendCallback(PlayAttackAnimation)
            .Join(transform.DORotateQuaternion(_endPoint.rotation, 1f));

    }
    private void PlayIdleAnimation() => _animationController.PlayAnimation(AnimationType.Idle);
    private void PlayTauntAnimation() => _animationController.PlayAnimation(AnimationType.Taunt);
    private void PlayTurnLeftAnimation() => _animationController.PlayAnimation(AnimationType.TurnLeft);
    private void PlayWalkAnimation() => _animationController.PlayAnimation(AnimationType.Walk);
    private void PlayTurnRightAnimation() => _animationController.PlayAnimation(AnimationType.TurnRight);
    private void PlayCrouchAnimation() => _animationController.PlayAnimation(AnimationType.Crouch);
    private void PlayAttackAnimation() => _animationController.PlayAnimation(AnimationType.Attack);
}
