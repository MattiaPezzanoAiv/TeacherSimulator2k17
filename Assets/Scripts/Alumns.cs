using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alumns : MonoBehaviour {

    private Dropdown dropDown;
    private Dictionary<string, Data> alumnsData;
    public Dictionary<string, Data> GetData()
    {
        return alumnsData;
    }
    private Text alumnName;
    private Text description;
    private Text birthDate;
    private Text absence;
    private Text medium;
    [HideInInspector]
    public Toggle present;


    private string CurrentValue
    {
        get { return dropDown.options[dropDown.value].text; }
    }

    void Awake()
    {
        dropDown = GetComponent<Dropdown>();
        alumnsData = new Dictionary<string, Data>();
        alumnsData.Add("Sergio", new Data("Sergio Rossi", "E' un tipo allegro","30/07/1993","5","8.5"));
        alumnsData.Add("Mattia", new Data("Mattia Rossi", "E' un tipo spensierato", "12/10/1992", "5", "8.5"));
        alumnsData.Add("Luca", new Data("Luca Rossi", "E' un tipo diligente", "30/01/1992", "5", "8.5"));
        alumnsData.Add("Elena", new Data("Elena Rossi", "E' una tipa stanca", "07/03/1994", "5", "8.5"));
        alumnsData.Add("Samuel", new Data("Samuel Rossi", "E' un tipo interessato", "27/01/1993", "5", "8.5"));
        alumnsData.Add("Claudio", new Data("Claudio Rossi", "E' un tipo timido", "30/5051992", "5", "8.5"));
        alumnsData.Add("Mario", new Data("Mario Rossi", "E' un tipo semplice", "10/04/1992", "5", "8.5"));
        alumnsData.Add("Paolo", new Data("Paolo Rossi", "E' un tipo fra le nuvole", "20/01/1992", "5", "8.5"));
        alumnsData.Add("Chiara", new Data("Chiara Rossi", "E' un tipo intelligente", "21/11/1992", "5", "8.5"));


        alumnName = transform.FindChild("Name").GetComponent<Text>();
        description = transform.FindChild("Description").GetComponent<Text>();
        birthDate = transform.FindChild("BirthDate").GetComponent<Text>();
        absence = transform.FindChild("Assenze").GetComponent<Text>();
        medium = transform.FindChild("Media").GetComponent<Text>();
        present = transform.FindChild("Toggle").GetComponent<Toggle>();
    }

    // Use this for initialization
    void Start () {

        SetAlumns();
	}
	
	// Update is called once per frame
	void Update () {
		
        
	}

    public void SetAlumns()
    {
        alumnName.text = alumnsData[CurrentValue].name;
        description.text = alumnsData[CurrentValue].description;
        birthDate.text = alumnsData[CurrentValue].birthDate;
        absence.text = alumnsData[CurrentValue].absence;
        medium.text = alumnsData[CurrentValue].medium;
        present.isOn = alumnsData[CurrentValue].present;
    }

    public void OnToggleChange()
    {
        alumnsData[CurrentValue].present = GetComponentInChildren<Toggle>().isOn;
    }
    public class Data
    {
        public string name;
        public string description;
        public string birthDate;
        public string absence;
        public string medium;
        public bool present;

        public Data(string name, string description, string birthDate, string absence, string medium)
        {
            this.name = name;
            this.description = description;
            this.birthDate = birthDate;
            this.absence = absence;
            this.medium = medium;
            present = false;
        }
    }
}
