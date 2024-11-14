using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region "singleton"
    public static UIManager Instance;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
    }
    #endregion

    #region "Descriptor"
    [SerializeField] private TextMeshProUGUI itemDescriptorName;
    [SerializeField] private TextMeshProUGUI itemDescriptorId;

    public void changeDescriptorItemInfo(string name, int id)
    {
        itemDescriptorName.text = name;
        itemDescriptorId.text = id.ToString();
    }
    #endregion
}
