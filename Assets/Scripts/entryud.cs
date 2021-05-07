using System.Collections;
using System.Collections.Generic;
using UnityEngine.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;

public class entryud : MonoBehaviour
{
    public ARSession session;

    public void goback()

    {  
        SceneManager.LoadScene("UI", LoadSceneMode.Single);
        echoAR.eid = null; 

    }

}
