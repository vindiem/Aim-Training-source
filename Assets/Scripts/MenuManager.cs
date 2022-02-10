using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Slider SensetivySlider;
    public Slider SecsSlider;
    public Slider TargetsSlider;

    [SerializeField] public Sensetivy sens;

    [SerializeField] Text sensText;
    [SerializeField] Text secsText;
    [SerializeField] Text targetsText;

    public void Update()
    {
        sensText.text = sens.mouseSensitive.ToString();
        secsText.text = sens.secs.ToString();
        targetsText.text = sens.TargetValue.ToString();

        sens.mouseSensitive = SensetivySlider.value;
        sens.secs = (int) SecsSlider.value;
        sens.TargetValue = (int) TargetsSlider.value;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
