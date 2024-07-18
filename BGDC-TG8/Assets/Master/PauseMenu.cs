using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [Header("Scene Index")]
    [SerializeField] private int menuIndex = 0;
    [SerializeField] private int saveIndex = 0;
    [SerializeField] private int loadIndex = 0;

    [Header("Buttons")]
    public Button Pause;
    [SerializeField] private GameObject PausePanel; 
    public Button Resume;   
    public Button Options;
    [SerializeField] private GameObject OptionsPanel;
    public Button OptionsQuit; 
    public Button Menu;
    public Button Save; 
    public Button Load;
    public Button Quit; 

    void Start()
    {
        PausePanel.SetActive(false);
        OptionsPanel.SetActive(false);

        Pause.onClick.AddListener(ClockCheck);
        Resume.onClick.AddListener(ClockCheck);
        Options.onClick.AddListener(Setting);
        OptionsQuit.onClick.AddListener(QuitSetting);
        Quit.onClick.AddListener(QuitApp);
        Menu.onClick.AddListener(() => GameManager.instance.ChangeScene(menuIndex));
    }

    private void ClockCheck()
    {
        if(GameManager.instance.isPaused)
        {
            GameManager.instance.ResumeGame();
            Pause.gameObject.SetActive(true);
            PausePanel.gameObject.SetActive(false);
        }
        else 
        {
            GameManager.instance.PauseGame();
            Pause.gameObject.SetActive(false);
            PausePanel.gameObject.SetActive(true);
        }
    }

    private void Setting()
    {
        OptionsPanel.SetActive(true);
    }

    private void QuitSetting()
    {
        OptionsPanel.SetActive(false);
    }

    private void QuitApp()
    {
        Application.Quit();
    }

}
