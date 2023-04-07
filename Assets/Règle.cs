using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Règle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Hide), 10f);
    }

    void Hide()
    {
        gameObject.SetActive(false);
    }
}
