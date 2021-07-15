using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] Image progressBar;

    [SerializeField] float seconds;
    float secondLeft;

    // Start is called before the first frame update
    void Start()
    {
        secondLeft = seconds;
    }

    // Update is called once per frame
    void Update()
    {
        if (secondLeft > 0)
        {
            secondLeft -= Time.deltaTime;
            progressBar.fillAmount = 1 - (secondLeft / seconds);
        }
    }
}
