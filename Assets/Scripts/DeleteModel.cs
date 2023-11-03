using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteModel : MonoBehaviour
{

    private static GameObject currentModel;
    // Start is called before the first frame update
    void Start()
    {
        ARChangeModelOnSelection.OnSendSelectedModel += SetCurrentSelectedModel;
    }

    private static void SetCurrentSelectedModel(GameObject selectedModel)
    {
        currentModel = selectedModel;
    }

    public void DeleteSelectedModel()
    {
        if (currentModel)
        {
            Destroy(currentModel);
        }
    }
}
