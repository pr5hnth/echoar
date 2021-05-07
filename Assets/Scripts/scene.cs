using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using Debug = UnityEngine.Debug;
using UnityEngine.UI;
public class scene : MonoBehaviour
{
    public void sceneload(Button btn)
    {
        SceneManager.LoadScene("Test Ar", LoadSceneMode.Single);
        echoAR.eid = btn.name;

    }
}
