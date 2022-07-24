using UnityEngine;

public class CryptoAnimationController
{
    private Animator _animator;

    private static int CryptoWalkKey = Animator.StringToHash("CryptoWalk");
    private static int BodyBlowKey = Animator.StringToHash("BodyBlow");
    private static int FlipKickKey = Animator.StringToHash("FlipKick");
    private static int CryptoIdleKey = Animator.StringToHash("CryptoIdle");
    private static int DropKickKey = Animator.StringToHash("DropKick");
    private static int RunToRollingKey = Animator.StringToHash("RunToRolling");
    private static int CryptoAttackTypeKey = Animator.StringToHash("CryptoAttackType");

    public CryptoAnimationController(Animator animator)
    {
        _animator = animator;
    }

    public void PlayAnimation(AnimationType type)
    {
        switch (type)
        {
            case AnimationType.CryptoWalk:
                PlayCryptoWalk();
                break;
            case AnimationType.BodyBlow:
                PlayBodyBlow();
                break;
            case AnimationType.FlipKick:
                PlayFlipKick();
                break;
            case AnimationType.CryptoIdle:
                PlayCryptoIdle();
                break;
            case AnimationType.DropKick:
                PlayDropKick();
                break;
            case AnimationType.RunToRolling:
                PlayRunToRolling();
                break;
            case AnimationType.CryptoAttack:
                PlayCryptoAttack();
                break;
        }
    }
    private void PlayCryptoWalk()
    {
        _animator.SetTrigger(CryptoWalkKey);
    }

    private void PlayBodyBlow()
    {
        _animator.SetTrigger(BodyBlowKey);
    }

    private void PlayFlipKick()
    {
        _animator.SetTrigger(FlipKickKey);
    }

    private void PlayCryptoIdle()
    {
        _animator.SetTrigger(CryptoIdleKey);
    }

    private void PlayDropKick()
    {
        _animator.SetTrigger(DropKickKey);
    }

    private void PlayRunToRolling()
    {
        _animator.SetTrigger(RunToRollingKey);
    }

    private void PlayCryptoAttack()
    {
        _animator.SetInteger(CryptoAttackTypeKey, Random.Range(0, 2));
    }
}
