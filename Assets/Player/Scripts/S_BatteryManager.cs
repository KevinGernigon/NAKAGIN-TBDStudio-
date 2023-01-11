using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class S_BatteryManager : MonoBehaviour
{


    [Header("Battery")]
    [SerializeField]
    private float _nbrBattery;
    [SerializeField]
    private float _nbrMaxBattery = 3 ;
    [SerializeField]
    private float _nbrMinBattery = 0;
    [SerializeField]
    private float _nbrBatteryFind = 1;

    [SerializeField]
    private bool _overdrive = false;

    


    private void UseOneBattery()
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

    private void UseTwoBattery()
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

    private void UseTreeBattery()
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

    private void UseAllBattery()
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

    private void GetOneBattery()
    {
        _nbrBatteryFind = 1;
        if (_nbrBattery < _nbrMaxBattery && (_nbrBatteryFind + _nbrBattery) <= _nbrMaxBattery )
        {
            _nbrBattery = _nbrBattery + _nbrBatteryFind;

            if ( _nbrBattery + _nbrBatteryFind > _nbrMaxBattery )
            {
                _nbrBattery = _nbrMaxBattery;

                if(_overdrive!)
                {
                    _overdrive = true;
                }
                
            }
        }
        else
        {
            //UI trop de batterie //Overdrive
        }
        
        
    }
    private void GetTwoBattery()
    {
        _nbrBatteryFind = 2;
        if (_nbrBattery < _nbrMaxBattery && (_nbrBatteryFind + _nbrBattery) <= _nbrMaxBattery)
        {
            _nbrBattery = _nbrBattery + _nbrBatteryFind;

            if (_nbrBattery > _nbrMaxBattery)
            {
                _nbrBattery = _nbrMaxBattery;

                if (_overdrive!)
                {
                    _overdrive = true;
                }
            }
        }
        else
        {
            //UI trop de batterie //Overdrive
        }

        
    }

    private void GetTreeBattery()
    {
        _nbrBatteryFind = 3;
        if (_nbrBattery < _nbrMaxBattery && (_nbrBatteryFind + _nbrBattery) <= _nbrMaxBattery)
        {
            _nbrBattery = _nbrBattery + _nbrBatteryFind;
            if (_nbrBattery + _nbrBatteryFind > _nbrMaxBattery)
            {
                _nbrBattery = _nbrMaxBattery;

                if (_overdrive!)
                {
                    _overdrive = true;
                }
            }
        }
        else
        {
            //UI trop de batterie //Overdrive
        }

    }


    private void UseOverdrive()
    {
        if(_overdrive)
        {
            _overdrive = false;

        }
    }


}
