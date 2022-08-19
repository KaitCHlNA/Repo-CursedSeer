
using UnityEngine;

public class TestReflexRT : MonoBehaviour
{
    void Update()
    {
        GetComponent<ReflectionProbe>().RenderProbe();
    }
}
