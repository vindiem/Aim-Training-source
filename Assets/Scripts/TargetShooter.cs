using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TargetShooter : MonoBehaviour
{
    [SerializeField] Camera cam;

    [SerializeField] float score;
    [SerializeField] float misses;

    [SerializeField] Text scoreText;
    [SerializeField] Text score1Text;
    [SerializeField] Text missesText;
    [SerializeField] Text misses1Text;

    [SerializeField] Image timeBar;
    [SerializeField] public Sensetivy sens;
    float timeLeft;

    [SerializeField] canvasSwitch canvasswitch;

    private void Start()
    {
        timeLeft = sens.secs;
    }

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            scoreText.text = score.ToString();
            missesText.text = misses.ToString();

            score1Text.text = score.ToString();
            misses1Text.text = misses.ToString();



            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();
                score++;
                if (target != null)
                {
                    target.Hit();
                }
            }
            else
            {
                misses++;
            }
        }*/

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / sens.secs;
        }

        else
        {
            canvasswitch.Switch();
        }
    }

    public void exitscoreandgametomainmenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Fire()
    {
        scoreText.text = score.ToString();
        missesText.text = misses.ToString();

        score1Text.text = score.ToString();
        misses1Text.text = misses.ToString();



        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Target target = hit.collider.gameObject.GetComponent<Target>();
            score++;
            if (target != null)
            {
                target.Hit();
            }
        }
        else
        {
            misses++;
        }
    }

}
