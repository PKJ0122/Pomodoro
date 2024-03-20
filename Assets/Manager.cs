using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject Esc_Panel;
    [SerializeField] Button Esc_YesBT;
    [SerializeField] Button Esc_NoBT;

    // Start is called before the first frame update
    void Start()
    {
        Esc_Panel.SetActive(false);
        Esc_YesBT.onClick.AddListener(ESC_Yes);
        Esc_NoBT.onClick.AddListener(ESC_NO);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Esc_Panel.SetActive(true);
    }
    void ESC_Yes()
    {
        Application.Quit();
    }
    void ESC_NO()
    {
        Esc_Panel.SetActive(false);
    }
}
