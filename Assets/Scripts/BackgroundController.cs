using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Transform _target;

    // Update is called once per frame
    void Update()
    {
        Follow();
    }

    void Follow()
    {
        if(_target != null)
        {
            Vector3 targetPos = this.transform.position;

            targetPos.x = _target.position.x;
            this.transform.position = targetPos;
        }
        else
        {
            Debug.LogWarning("따라갈 대상이 없습니다.");
        }
    }
}
