using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    �� �������� ó���ϴµ� �ʿ��� �ð�,
    �� �������� ���۵Ǹ� �ش� �����ӿ� �ʿ��� ������ �����ϰ�
    ���� ȭ�鿡 ����ϴµ� �ɸ� �� �ð��� �������� ��Ÿ���� ��

    Update() �ռ����� ���� Time.unscaledDeltaTime �� �� �������� ó���ϴ� �� �ɸ� �ð��� �ǹ�
    �� �����Ӹ��� ó���ϴµ� �ɸ� �ð��� ������ ���� ����
    �̷��� ���� �����ϴ� ������ ������� ���� �����ϱ� ���ؼ���.
    �� �����Ӹ��� ǥ���ϸ� ������  ���� ���� ���ŴϿ� �����Ӹ��� ���� ���� ���̰� Ŭ �� �ֱ� ������ ���� �Ⱓ ���� ���� �����ؼ� ��� ���� ��.
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
