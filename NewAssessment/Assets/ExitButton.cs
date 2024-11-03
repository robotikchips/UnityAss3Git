using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public void ExitButtonClickEvent() {
        SceneManager.LoadScene("StartScene2");
    }
}
