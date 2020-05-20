using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text TimerText;
    public bool play;
    private float time;

    void Update()
    {

        if (play == true)
        {
            time += Time.deltaTime;
            int minutes = Mathf.FloorToInt(time / 60F);
            int seconds = Mathf.FloorToInt(time % 60F);
            TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
        else
        {
            TimerText.text = TimerText.text;
        }
    }

}