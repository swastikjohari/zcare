using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loginMenu001 : MonoBehaviour
{
    public GameObject patient;
    public GameObject Guardian;
    public GameObject Doctor;
    public GameObject log;
    public GameObject IDNumber;
    public GameObject password;
    public GameObject log002;
    public Text IDk;
    public Text pass;
    public GameObject emergencyNumber;
    public GameObject Prescription;
    public GameObject logo001;
    public GameObject logo002;
    public GameObject logo003;
    public GameObject image;
    public GameObject statement;
    public GameObject numberOfMedicines;
    public Text NumberOfMedicines001;
    public GameObject Med1;
    public GameObject Med2;
    public GameObject Med3;
    public GameObject Med4;
    public GameObject Appointment;
    public GameObject AppNo;
    public Text AppNumbers;
    public GameObject App1;
    public GameObject App2;
    public GameObject App3;
    public GameObject Wallet;
    public GameObject Name;
    public GameObject sign;
    public GameObject Enter;
    public GameObject Medname;
    public GameObject days;
    public GameObject times;
    public GameObject starting;
    public GameObject Accept;
    public GameObject Back;//this also has a see details button now with the new updated details.
    public GameObject Details; //this also has a back button. 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void login()
    {
        patient.SetActive(true);
        Guardian.SetActive(true);
        Doctor.SetActive(true);
        log.SetActive(false);
        logo001.SetActive(false);
        logo002.SetActive(false);
        logo003.SetActive(false);
        sign.SetActive(false);

        statement.SetActive(false);
    }

    public void login002()
    {
        patient.SetActive(false);
        Guardian.SetActive(false);
        Doctor.SetActive(false);

        IDNumber.SetActive(true);
        password.SetActive(true);
        log002.SetActive(true);
        //IDk= IDNumber.GetComponent<Text>().text;

    }

    public void passid()
    {
        if (IDk.text == "Sammy" && pass.text == "srm12345")
        {
            password.SetActive(false);
            IDNumber.SetActive(false);
            log002.SetActive(false);
            emergencyNumber.SetActive(true);
            Prescription.SetActive(true);
            Appointment.SetActive(true);
            Wallet.SetActive(true);

        }
        else
        {
            IDk.text = "";
            pass.text = "";
        }

    }

    public void AddPrescription()
    {
        emergencyNumber.SetActive(false);
        Prescription.SetActive(false);
        Appointment.SetActive(false);
        Wallet.SetActive(false);
        Enter.SetActive(true);
        numberOfMedicines.SetActive(true);
    }
    public void Enter001() { 

        if (NumberOfMedicines001.text=="1")
        {
            Med1.SetActive(true);
            Enter.SetActive(false);
            numberOfMedicines.SetActive(false);
        }

       else if (NumberOfMedicines001.text == "2")
        {
            Med1.SetActive(true);
            Med2.SetActive(true);
            Enter.SetActive(false);
            numberOfMedicines.SetActive(false);
        }

        else if (NumberOfMedicines001.text == "3")
        {
            Med1.SetActive(true);
            Med2.SetActive(true);
            Med3.SetActive(true);
            Enter.SetActive(false);
            numberOfMedicines.SetActive(false);
        }

        else if (NumberOfMedicines001.text == "4")
        {
            Med1.SetActive(true);
            Med2.SetActive(true);
            Med3.SetActive(true);
            Med4.SetActive(true);
            Enter.SetActive(false);
            numberOfMedicines.SetActive(false);
        }
    }

    public void AddAppointments()
    {
        emergencyNumber.SetActive(false);
        Prescription.SetActive(false);
        Appointment.SetActive(false);
        Wallet.SetActive(false);

        AppNo.SetActive(true);

        if(AppNumbers.text=="1")
        {
            App1.SetActive(true);
        }

        if (AppNumbers.text == "2")
        {
            App1.SetActive(true);
            App2.SetActive(true);

        }

        if (AppNumbers.text == "3")
        {
            App1.SetActive(true);
            App2.SetActive(true);
            App3.SetActive(true);
        }
    }

    public void checkWallet()
    {

    }

    public void Med001()
    {
        numberOfMedicines.SetActive(false);
        Name.SetActive(true);
    }

    public void Med002()
    {
        numberOfMedicines.SetActive(false);
        Name.SetActive(true);

    }

    public void Med003()
    {
        numberOfMedicines.SetActive(false);
        Name.SetActive(true);

    }

    public void Med004()
    {
        numberOfMedicines.SetActive(false);
        Name.SetActive(true);

    }
}
