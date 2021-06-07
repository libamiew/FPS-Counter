using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    한 프레임을 처리하는데 필요한 시간,
    즉 프레임이 시작되면 해당 프레임에 필요한 연산을 수행하고
    최종 화면에 출력하는데 걸린 총 시간이 얼마인지를 나타내는 값

    Update() 합수에서 사용된 Time.unscaledDeltaTime 은 한 프레임을 처리하는 데 걸린 시간을 의미
    매 프레임마다 처리하는데 걸린 시간과 프레임 수를 축적
    이렇게 값을 축적하는 이유는 평균적인 값을 산출하기 위해서임.
    매 프레임마다 표시하면 눈으로  읽을 수도 없거니와 프레임마다 변동 값이 차이가 클 수 있기 때문에 일정 기간 동안 값을 축적해서 평균 내는 것.
 */

public class FPSCounter : MonoBehaviour
{
    [SerializeField] Text text;
    
    float frames = 0f;
    float timeElap = 0f;
    float frameTime = 0f;

    private void Update()
    {
        frames++;
        timeElap += Time.unscaledDeltaTime;

        if (timeElap > 1f)
        {
            frameTime = timeElap / (float) frames;
            timeElap -= 1f;
            UpdateText();
            frames = 0f;
        }
    }

    private void UpdateText()
    {
        text.text = string.Format(
            "FPS : {0}, FrameTime : {1:F2} ms",
            frames, frameTime * 1000.0f
            );
    }
}
