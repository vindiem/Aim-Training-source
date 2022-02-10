using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasSwitch : MonoBehaviour
{
    [SerializeField] Canvas main;
    [SerializeField] Canvas scored;

    [SerializeField] PlayerController playerControll;
    [SerializeField] TargetShooter targetShooter;

    private void Start()
    {
        scored.enabled = false;
    }

    public void Switch()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        main.enabled = false;
        playerControll.enabled = false;
        targetShooter.enabled = false;
        scored.enabled = true;
    }
}
