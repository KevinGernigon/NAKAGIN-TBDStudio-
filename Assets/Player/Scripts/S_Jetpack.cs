using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Jetpack : MonoBehaviour
{
    [Header("References")]
    public Transform orientation;
    public Transform playerCam;
    private Rigidbody _rb;
    private S_PlayerMovement _pm;

    [Header("Jetpack")]
    [SerializeField] private float _jetpackForce;
    [SerializeField] private float _jetpackUpwardForce;
    private bool _isGravityDisable;

    private Vector3 saveForceToApplyInAir;
    private Vector3 saveForceToApplyOnGround;

    private bool _isTriggerBoxTrue;
    private bool _isMaxForce; 
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _pm = GetComponent<S_PlayerMovement>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
            JetpackFunction();
    }

    public void JetpackFunction()
    {
        Debug.Log("Here");

        Transform forwardT;

        forwardT = orientation;
        
        if(_isTriggerBoxTrue)
        {
            _isMaxForce = true;
            Vector3 forceToApply = forwardT.forward * _jetpackForce + forwardT.up * _jetpackUpwardForce;
            saveForceToApplyInAir = forceToApply;
            StartCoroutine(waitForBoolean());
        }
        else if(!_isTriggerBoxTrue && !_isMaxForce)
        {
            Vector3 forceToApply = (forwardT.forward * _jetpackForce) / 2 + (forwardT.up * _jetpackUpwardForce) / 2;
            saveForceToApplyOnGround = forceToApply;
        }

        if (_isGravityDisable)
            _rb.useGravity = false;


        Invoke(nameof(DelayedJetpackForce), 0.025f);
    }

    private void DelayedJetpackForce() 
    {
        if(_isMaxForce)
        _rb.AddForce(saveForceToApplyInAir, ForceMode.Impulse);
        else
        _rb.AddForce(saveForceToApplyOnGround, ForceMode.Impulse);
    }

    public void BooleanTriggerBoxEnter()
    {
        _isTriggerBoxTrue = true;
        JetpackFunction();
    }

    public void BooleanTriggerBoxExit()
    {
        _isTriggerBoxTrue = false;
    }

    IEnumerator waitForBoolean()
    {
        yield return new WaitForSeconds(2f);
        _isMaxForce = false;
    }
}
