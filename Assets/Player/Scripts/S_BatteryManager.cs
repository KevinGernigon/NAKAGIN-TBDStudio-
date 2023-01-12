using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class S_BatteryManager : MonoBehaviour
{


    [Header("Battery")]
    [SerializeField]
    public float _nbrBattery;
    [SerializeField]
    public float _nbrMaxBattery = 3 ;
    [SerializeField]
    private float _nbrMinBattery = 0;
    [SerializeField]
    private float _nbrBatteryFind = 0;

    [SerializeField]
    public bool _overdrive = false;

    


    public void UseOneBattery()
    {
        if( _nbrBattery >= 1)
        {
            _nbrBattery -= 1;
        }
        else
        {
            //UI si batterie vide 
        }

    }

    public void UseTwoBattery()
    {
        if (_nbrBattery >= 2)
        {
            _nbrBattery -= 2;
        }
        else
        {
            //UI si batterie vide 
        }

    }

    public void UseThreeBattery()
    {
        if (_nbrBattery >= 3)
        {
            _nbrBattery -= 3;
        }
        else
        {
            //UI si batterie vide 
        }

    }

    public void UseAllBattery()
    {
        if (_nbrBattery >= _nbrMaxBattery)
        {
            _nbrBattery = _nbrMinBattery;
        }
        else
        {
            //UI si batterie vide 
        }

    }

    public void GetOneBattery()
    {
        _nbrBatteryFind = 1;
        if ((_nbrBattery < _nbrMaxBattery) && (_nbrBatteryFind + _nbrBattery) <= _nbrMaxBattery )
        {
            _nbrBattery = _nbrBattery + _nbrBatteryFind;

            if ( _nbrBattery  > _nbrMaxBattery )
            {
                _nbrBattery = _nbrMaxBattery;
            }
        }
        else
        {
            if (!_overdrive)
            {
                _overdrive = true;
            }
            //UI trop de batterie //Overdrive
        }
        
        
    }
    public void GetTwoBattery()
    {
        _nbrBatteryFind = 2;
        if (_nbrBattery < _nbrMaxBattery && (_nbrBatteryFind + _nbrBattery) <= _nbrMaxBattery)
        {
            _nbrBattery = _nbrBattery + _nbrBatteryFind;

            if (_nbrBattery > _nbrMaxBattery)
            {
                _nbrBattery = _nbrMaxBattery;

            }
        }
        else
        {

            if (!_overdrive)
            {
                _overdrive = true;
            }
            //UI trop de batterie //Overdrive
        }

        
    }

    public void GetThreeBattery()
    {
        _nbrBatteryFind = 3;
        if (_nbrBattery < _nbrMaxBattery && (_nbrBatteryFind + _nbrBattery) <= _nbrMaxBattery)
        {
            _nbrBattery = _nbrBattery + _nbrBatteryFind;
            if (_nbrBattery + _nbrBatteryFind > _nbrMaxBattery)
            {
                _nbrBattery = _nbrMaxBattery;

            }
        }
        else
        {

            if (!_overdrive)
            {
                _overdrive = true;
            }
            //UI trop de batterie //Overdrive
        }

    }


    public void UseOverdrive()
    {
        if(_overdrive)
        {
            _overdrive = false;

        }
    }


}
