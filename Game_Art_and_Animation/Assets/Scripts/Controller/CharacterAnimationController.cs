﻿using UnityEngine;

public class CharacterAnimationController
{
    private Animator _animator;

    private static int IdleKey = Animator.StringToHash("Idle");
    private static int TauntKey = Animator.StringToHash("Taunt");
    private static int TurnLeftKey = Animator.StringToHash("TurnLeft");
    private static int WalkKey = Animator.StringToHash("Walk");
    private static int TurnRightKey = Animator.StringToHash("TurnRight");
    private static int CrouchKey = Animator.StringToHash("Crouch");
    private static int AttackTypeKey = Animator.StringToHash("AttackType");

    public CharacterAnimationController(Animator animator)
    {
        _animator = animator;
    }

    public void PlayAnimation(AnimationType type)
    {
        switch(type)
        {
            case AnimationType.Idle:
                PlayIdle();
                break;
            case AnimationType.Taunt:
                PlayTaunt();
                break;
            case AnimationType.TurnLeft:
                PlayTurnLeft();
                break;
            case AnimationType.Walk:
                PlayWalk();
                break;
            case AnimationType.TurnRight:
                PlayTurnRight();
                break;
            case AnimationType.Crouch:
                PlayCrouch();
                break;
            case AnimationType.Attack:
                PlayAttack();
                break;
        } 
    }
    private void PlayIdle()
    {
        _animator.SetTrigger(IdleKey);
    }

    private void PlayTaunt()
    {
        _animator.SetTrigger(TauntKey);
    }

    private void PlayTurnLeft()
    {
        _animator.SetTrigger(TurnLeftKey);
    }

    private void PlayWalk()
    {
        _animator.SetTrigger(WalkKey);
    }

    private void PlayTurnRight()
    {
        _animator.SetTrigger(TurnRightKey);
    }

    private void PlayCrouch()
    {
        _animator.SetTrigger(CrouchKey);
    }

    private void PlayAttack()
    {
        _animator.SetInteger(AttackTypeKey, Random.Range(0, 2));
        //_animator.SetTrigger(AttackTypeKey);
    }

}
