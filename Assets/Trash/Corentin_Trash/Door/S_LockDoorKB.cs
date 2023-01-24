using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_LockDoorKB : MonoBehaviour
{
    public GameObject[] KeyList;
    private int _nbrKeyFind = 0;


    private void Start()
    {
        Debug.Log("Key Find : " + _nbrKeyFind + "/" + KeyList.Length);
       
    }

    
    private void Update()
    {
        if( _nbrKeyFind == KeyList.Length)
        {
            Destroy(gameObject);
            Debug.Log("Door Open !");
        }

    }

    public void KeyFind(GameObject Key)
    {
        _nbrKeyFind++;
        Destroy(Key);
        Debug.Log("Key find : " + _nbrKeyFind);
    }


}
