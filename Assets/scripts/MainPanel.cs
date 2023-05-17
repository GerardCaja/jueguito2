using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class MainPanel : MonoBehaviour
{
   [Header("Panels")]
   public GameObject mainPanel;
   public GameObject optionsPanel;
   public GameObject levelSelectPanel;

   public void OpenPanel(GameObject panel)
   {
    mainPanel.SetActive(false);
    optionsPanel.SetActive(false);
    levelSelectPanel.SetActive(false);

    panel.SetActive(true);
   }

   public void PlayerLevel(string samplesceneName)
   {
    SceneManager.LoadScene(samplesceneName);
   }
   
}
