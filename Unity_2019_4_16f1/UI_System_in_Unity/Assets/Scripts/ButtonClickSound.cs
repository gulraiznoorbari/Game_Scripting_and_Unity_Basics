using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ButtonClickSound : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private AudioSource _audio;

    private void OnEnable()
    {
        _button.onClick.AddListener(onClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(onClick);
    }

    private void onClick()
    {
        Debug.Log("PLay Click Sound.");
        _audio.Play();
    }
}
