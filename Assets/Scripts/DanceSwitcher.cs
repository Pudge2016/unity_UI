using UnityEngine;

public class DanceSwitcher : MonoBehaviour
{
    public RuntimeAnimatorController[] dances;
    private Animator dance;

    public void SetDance(float i)
    {
        i--;
        if (i < 0 || i >= dances.Length)
        {
            Debug.Log("Dance index is out of range");
            return;
        }
        dance.runtimeAnimatorController = dances[(int)i];
    }

    // Start is called before the first frame update
    void Start()
    {
        dance = GetComponent<Animator>();
    }
}
