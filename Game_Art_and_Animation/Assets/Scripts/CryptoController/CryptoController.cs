using UnityEngine;
using DG.Tweening;

public class CryptoController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    private CryptoAnimationController _cryptoAnimationController;
    private Sequence _sequence;

    // Start is called before the first frame update
    void Start()
    {
        _cryptoAnimationController = new CryptoAnimationController(_animator);
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
            .AppendCallback(PlayCryptoWalkAnimation)
            .Join(transform.DOMove(_endPoint.position, 3f))
            .AppendCallback(PlayRunToRollingAnimation)
            .AppendCallback(PlayCryptoAttackAnimation)
            .Join(transform.DORotateQuaternion(_endPoint.rotation, 1f));

    }
    private void PlayCryptoWalkAnimation() => _cryptoAnimationController.PlayAnimation(AnimationType.CryptoWalk);
    private void PlayBodyBlowAnimation() => _cryptoAnimationController.PlayAnimation(AnimationType.BodyBlow);
    private void PlayFlipKickAnimation() => _cryptoAnimationController.PlayAnimation(AnimationType.FlipKick);
    private void PlayCryptoIdleAnimation() => _cryptoAnimationController.PlayAnimation(AnimationType.CryptoIdle);
    private void PlayDropKickAnimation() => _cryptoAnimationController.PlayAnimation(AnimationType.DropKick);
    private void PlayRunToRollingAnimation() => _cryptoAnimationController.PlayAnimation(AnimationType.RunToRolling);
    private void PlayCryptoAttackAnimation() => _cryptoAnimationController.PlayAnimation(AnimationType.CryptoAttack);

}

