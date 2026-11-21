using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class mainmenubuttons : MonoBehaviour
{
    public UIDocument document;
    private Button startButton;

    private void OnEnable()
    {
        VisualElement root = document.rootVisualElement;

        startButton = root.Q<Button>("Start");
        Debug.Log(startButton);

        if (startButton != null)
        {
            startButton.clicked += OnButtonClicked;
        }
    }

    private void OnDisable()
    {
        if (startButton != null)
        {
            startButton.clicked -= OnButtonClicked;
        }
    }

    private void OnButtonClicked()
    {
        Debug.Log("Button clicked!");
        SceneManager.LoadScene("SampleScene");
    }
}


