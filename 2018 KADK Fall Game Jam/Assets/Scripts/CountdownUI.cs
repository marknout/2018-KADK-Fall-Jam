using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownUI : MonoBehaviour
{

    [SerializeField] private Text UIText;
    [SerializeField] private float MainTimer;

    private float Timer;

    void Start()
    {

        Timer = MainTimer;

    }

    void Update()
    {
    
        if (Timer >= 0.0f)
        {
            Timer -= Time.deltaTime;
            UIText.text = Timer.ToString("F");
        }

        else if (Timer <= 0.0f)
        {
            UIText.text = "0.00";
            Timer = 0.0f;
            SceneManager.LoadScene("TestLevel");
        }

    }
}
