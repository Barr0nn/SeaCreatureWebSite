using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RegistrationResult.InnerText = "";

        if (IsPostBack)
        {
            if (Form_Validation() && Insert_Into_Database())
            {
                RegistrationResult.InnerText =
                        firstName.Value + ", רישום מוצלח, יש לעבור לדף הכניסה.";
            }
        }
    }

    private bool Form_Validation()
    {
        return
            First_Name_Validation() &&
            Last_Name_Validation() &&
            User_Name_Validation() &&
            Password_Validation() &&
            ID_Validation() &&
            Phone_Validation() &&
            Email_Validation() &&
            Approval_Validation();
    }

    private bool First_Name_Validation()
    {
        string fname = firstName.Value;

        if (fname.Length < 2)
        {
            RegistrationResult.InnerText += "שם פרטי חייב להכיל לפחות שני תווים. ";
            return false;
        }

        return true;
    }

    private bool Last_Name_Validation()
    {
        string lname = lastName.Value;

        if (lname.Length < 2)
        {
            RegistrationResult.InnerText += "שם משפחה חייב להכיל לפחות שני תווים. ";
            return false;
        }

        return true;
    }

    private bool User_Name_Validation()
    {
        // === משימה לתלמיד: וידוא שם משתמש ===
        // 1. בדוק אם אורך שם המשתמש קטן מ-3 או גדול מ-8 תווים
        // לדוגמה של בדיקת אורך, הסתכל בפעולה:
        // First_Name_Validation
        // 2. אם האורך לא תקין, הוסף הודעת שגיאה לתוך:
        // RegistrationResult.InnerText
        // 3. ולאחר מכן עצור את הפעולה על ידי:
        // return false;
        string uname = userName.Value;

        if (uname.Length < 3 || uname.Length > 8)
        {
            RegistrationResult.InnerText += "Invalid username";
            return false;
        }

        return true;
    }

    private bool Password_Validation()
    {
        string password = pswd.Value;
        string pswdV = pswdValidate.Value;

        // קוד שמוודא שהסיסמה בין 6 ל-10 תווים בלבד
        if (password.Length < 6 || password.Length > 10)
        {
            RegistrationResult.InnerText += "הסיסמה חייבת להכיל בין 6 ל-10 תווים. ";
            return false;
        }

        // קוד שמוודא שהסיסמה מכילה אותיות ומספרים
        bool letterExist = false;
        bool numberExist = false;
        for (int i = 0; i < password.Length; i++)
        {
            // בדיקת קיום אותיות
            if (password[i] >= 'a' && password[i] <= 'z' || password[i] >= 'A' && password[i] <= 'Z')
                letterExist = true;
            // בדיקת קיום מספרים
            else if (password[i] >= '0' && password[i] <= '9')
                numberExist = true;
        }
        if (!letterExist || !numberExist)
        {
            RegistrationResult.InnerText += "הסיסמה חייבת להכיל אותיות ומספרים. ";
            return false;
        }

        // קוד לוידוא סיסמה ווידוא סיסמה זהים
        if (password != pswdV)
        {
            RegistrationResult.InnerText += "הסיסמה ווידוא הסיסמה אינם זהים. ";
            return false;
        }

        return true;
    }

    private bool ID_Validation()
    {
        string id = idNum.Value;
        bool letters = false;

        for (int i = 0; i < id.Length; i++)
        {
            if (id[i] >= 'a' && id[i] <= 'z' || id[i] >= 'A' && id[i] <= 'Z')
                letters = true;
        }

        if (id.Length != 9 || letters)
        {
            RegistrationResult.InnerText += "Incorrect id";
            return false;
        }

        return true;
    }

    private bool Phone_Validation()
    {
        string phonenum = phone.Value;
        bool letters = false;

        for (int i = 0; i < phonenum.Length; i++)
        {
            if (phonenum[i] >= 'a' && phonenum[i] <= 'z' || phonenum[i] >= 'A' && phonenum[i] <= 'Z')
                letters = true;
        }

        if (phonenum.Length != 10 || letters || phonenum[0] != 0)
        {
            RegistrationResult.InnerText += "Incorrect phone number";
            return false;
        }

        return true;
    }

    private bool Email_Validation()
    {
        string email = mail.Value;
        bool valid;

        int @ind = 0;
        int dotind = 0;
        int @amnt = 0;

        for (int i = 0; i < email.Length; i++)
        {
            
            if (email[i] == '@')
            {
                @ind = i;
                @amnt++;
            }

            if (email[i] == '.')
            {
                dotind = i;
            }
        }

        if (@amnt != 1 || dotind < @ind)
            {
            RegistrationResult.InnerText += "Incorrect email";
            return false;
            }

            return true;
    }

    private bool Approval_Validation()
    {
        if (!approval.Checked)
        {
            RegistrationResult.InnerText += "יש לאשר את תקנון האתר. ";
            return false;
        }

        return true;
    }

    private bool Insert_Into_Database()
    {
        return true;
    }



}