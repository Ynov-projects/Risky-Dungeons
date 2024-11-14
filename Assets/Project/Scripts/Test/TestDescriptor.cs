using UnityEngine;

public class TestDescriptor : MonoBehaviour
{
    [SerializeField] private GameObject inventoryButton;
    [SerializeField] private Transform inventoryContent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            for (int i = 0; i < 50; i++)
            {
                GameObject button = Instantiate(inventoryButton, inventoryContent);
                button.GetComponent<DescriptorItemScript>().SetupInfo("button" + i.ToString(), 50 - i);
            }
        }
    }
}
