using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class SceneManageHandler : MonoBehaviour

{
    [SerializeField] TextMeshProUGUI buttonText;
   public void LoadMainScene(){
    buttonText.text="Loading";
        SceneManager.LoadScene(1);
    }
}
