using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CharacterUpgrade : MonoBehaviour
{
    [Header("Character Upgrade")]

    [Header("References")]
    [SerializeField] private S_PlayerMovement pm;

    [Header("Boolean")]
    private bool _isSpeedUpgradable;

    private void Start()
    {
        _isSpeedUpgradable = true;
    }
    private void Update()
    {
        InputManager();
    }

    private void InputManager()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isSpeedUpgradable)
        {
            _isSpeedUpgradable = false;
            SpeedUpgrade();
            StartCoroutine(upgradeSpeed());
        }

        if (Input.GetKeyDown(KeyCode.F))
            DashUpgrade();
    }

    private void SpeedUpgrade()
    {
        pm.SpeedValueUpgrade();
    }

    private void DashUpgrade()
    {
        pm.DashValueUpgrade();
    }

    IEnumerator upgradeSpeed()
    {
        yield return new WaitForSeconds(2f);
        _isSpeedUpgradable = true;
    }
}
