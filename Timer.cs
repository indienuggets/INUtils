using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{

    public float RunEvery = 5;
    public bool RunOnAwake = false;
    public bool Loop = true;
    public UnityEvent OnTimerEnd;

    void OnEnable()
    {
        if (RunOnAwake)
        {
            Invoke("Execute", 0);
        }

        if (Loop)
        {
            InvokeRepeating("Execute", RunEvery, RunEvery);
        }
        else
        {
            Invoke("Execute", RunEvery);
        }
    }

    public void Execute()
    {
        OnTimerEnd.Invoke();
    }
}
