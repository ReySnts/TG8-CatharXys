using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [Header("Scene Index")]
    [SerializeField] private int menuIndex = 0;

    [Header("Panels")]
    [SerializeField] private GameObject PausePanel;
    [SerializeField] private GameObject OptionsPanel;
    [SerializeField] private GameObject SavePanel;
    [SerializeField] private GameObject LoadPanel;

    [Header("Buttons")]
    public Button Pause; 
    public Button Resume;   
    public Button Options;
    public Button OptionsQuit; 
    public Button Menu;
    public Button Save;
    public Button SaveQuit; 
    public Button Load; 
    public Button LoadQuit;
    public Button Quit; 

    void Start()
    {
        PausePanel.SetActive(false);
        OptionsPanel.SetActive(false);
        SavePanel.SetActive(false);
        LoadPanel.SetActive(false);

        Pause.onClick.AddListener(ClockCheck);
        Resume.onClick.AddListener(ClockCheck);
        Options.onClick.AddListener(Setting);
        OptionsQuit.onClick.AddListener(QuitSetting);
        Save.onClick.AddListener(Savef);
        SaveQuit.onClick.AddListener(QuitSave);
        Load.onClick.AddListener(Loadf);
        LoadQuit.onClick.AddListener(QuitLoad);
        Quit.onClick.AddListener(QuitApp);
        Menu.onClick.AddListener(() => GameManager.instance.ChangeScene(menuIndex));
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            ClockCheck();
        }
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

    private void Savef()
    {
        SavePanel.SetActive(true);
    }

    private void QuitSave()
    {
        SavePanel.SetActive(false);
    }

    private void Loadf()
    {
        LoadPanel.SetActive(true);
    }

    private void QuitLoad()
    {
        LoadPanel.SetActive(false);
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