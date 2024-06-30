using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void StartBtn()
    {
        switch(this.gameObject.name)
        {
            case "Button":
                SceneManager.LoadScene("start1");
                break;
        }
    }
}
