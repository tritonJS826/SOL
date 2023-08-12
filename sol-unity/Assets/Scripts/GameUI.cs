using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public static GameUI Instance;

    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI inputText;
    [SerializeField] private TMP_InputField inputField;
    
    
    private void Awake()
    {
        Instance = this;
        inputField.onEndEdit.AddListener(OnEndEdit);
    }

    
    private void OnEndEdit(string text)
    {
        inputText.text = text;
        print(text);
    }
    
    public void OnButtonCheckClicked()
    {
        print("Button Check Clicked");
    }
    
    
    public void FillQuestion(string question)
    {
        panel.SetActive(true);
        
        inputText.text = question;
        inputField.text = "";
    }
   
}
