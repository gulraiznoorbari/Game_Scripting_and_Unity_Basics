using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    MasterInput _controls;

    private void Awake()
    {
        _controls = new MasterInput();
        _controls.Player.Shoot.performed += context => Shoot();
        _controls.Player.Movement.performed += context => Movement(context.ReadValue<Vector2>());
    }

    private void Update()
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        if (kb.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Someone pressed Spacebae?!?!");
        }
    }

    private void Movement(Vector2 direction)
    {
        Debug.Log("Player Moves at:" + direction);
    }

    private void Shoot()
    {
        Debug.Log("We shot the enemy!");
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }
}
