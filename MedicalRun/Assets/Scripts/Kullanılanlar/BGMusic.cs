using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
  
{
    public static BGMusic backgroundM;
    // Start is called before the first frame update
    void Awake()
    { 
        if(backgroundM==null)
        {
            backgroundM = this;
            DontDestroyOnLoad(backgroundM);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
