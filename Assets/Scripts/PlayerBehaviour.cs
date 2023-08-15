using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] PlayerMovement _playerMovement;
    [SerializeField] PreFinishBehaviour _preFinishBehaviour;
    [SerializeField] Animator _animator;

    void Start()
    {
        _playerMovement.enabled = false;
        _preFinishBehaviour.enabled = false;
    }

    public void Play()
    {
        _playerMovement.enabled = true;
    }

    public void StartPreFinishBehaviour()
    {
        _playerMovement.enabled = false;
        _preFinishBehaviour.enabled = true;
    }

    public void StartFinishBehaviour()
    {
        _preFinishBehaviour.enabled = false;
        _animator.SetTrigger("Dance");

    }

}
