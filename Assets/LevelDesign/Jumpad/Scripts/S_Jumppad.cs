using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Jumppad : MonoBehaviour
{
    [SerializeField]
    Rigidbody _player;
    [SerializeField]
    private float _addforceHauteur = 10f;
    [SerializeField]
    private float _addforceLongueur = 10f;
    void Start()
    {
        //_player = GetComponent<Rigidbody>();   
    }
    private void Jumpadbump()
    {
        _player.velocity = new Vector3(_player.velocity.x * (_addforceLongueur), _addforceHauteur, _player.velocity.z);

        _player.AddForce(transform.up, ForceMode.Impulse);
    }

    public void OnTriggerEnter()
    {
        Jumpadbump();
    }

}
