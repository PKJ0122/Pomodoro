using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float time = 1500f;
    bool pomodoro = false;

    [SerializeField] Text time_Text;
    [SerializeField] Button reset_Button;
    [SerializeField] GameObject pomodoroAnim;
    // Start is called before the first frame update
    void Start()
    {
        reset_Button.gameObject.SetActive(false);
        reset_Button.onClick.AddListener(PomodoroReset);

        pomodoroAnim.SetActive(false);

        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Application.runInBackground = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (pomodoro)
            return;

        time -= Time.deltaTime;
        time_Text.text = $"{(int)time / 60:00}:{(int)time % 60:00}";

        if (time <= 0)
        {
            PomodoroTime();
        }
    }

    void PomodoroTime()
    {
        if (pomodoro)
            return;

        pomodoro = true;
        pomodoroAnim.SetActive(true);
        reset_Button.gameObject.SetActive(true);
    }

    void PomodoroReset()
    {
        if (!pomodoro)
            return;

        time = 1500f;
        pomodoro = false;
        pomodoroAnim.SetActive(false);
        reset_Button.gameObject.SetActive(false);
    }
}
