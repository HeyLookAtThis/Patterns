using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour
{
    [SerializeField] private CharacterConfig _config;

    private CharacterController _characterController;

    public CharacterController CharacterController => _characterController;
    public CharacterConfig Config => _config;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }
}
