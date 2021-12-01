using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

public class UniBook_System
{
    #region Runtime_Properties
    public string Description { get; set; }
    public string FileName { get; set; }
    public Color UI_Color1 { get; set; }
    public Color UI_Color2 { get; set; }
    public Color UI_Color3 { get; set; }
    public Color UI_Color4 { get; set; }
    public bool UI_Auto_Generate_IDs { get; set; }
    public bool UI_Auto_Timestamp { get; set; }
    public string UI_Password { get; set; }
    public bool Whole_Number_Balances { get; set; }

    #endregion Runtime_Properties

    //--OBJECT COLLECTIONS--
    public ACCTs Accounts = new ACCTs("");
    public Activities Actions = new Activities("");

    #region public_methods

    public void Clear()
    {
        this.Accounts.items.Clear();
        this.Actions.items.Clear();
    }

    #endregion public_methods



}

public class ACCT
{
    public string name { get; set; }

    public string ID { get; set; }

    public ACCT(string id, string name)
    {
        this.name = name;
        this.ID = id;
    }

    public string DLM()
    {
        string rv = "";
        rv += name + "§";
        rv += ID + "§";
        rv += "¨";
        return rv;
    }
}

public class ACCTs
{
    public List<ACCT> items = new List<ACCT>();

    public ACCTs(string fromDLM)
    {
        string[] records = fromDLM.Split('¨');
        foreach (string s in records)
        {
            string[] fields = s.Split('§');
            if (fields.Length > 1)
            {
                this.items.Add(new ACCT(fields[1], fields[0]));
            }
        }
    }

    public ACCT Get_Acct(string fromID)
    {
        foreach (ACCT A in this.items)
        {
            if (A.ID == fromID) return A;
        }

        return new ACCT("New","New");
    }

    public string DLM()
    {
        string rv = "";
        foreach (ACCT A in this.items)
        {
            rv += A.DLM();
        }
        return rv;
    }

    public string New_UID()
    {
        Random rnd = new Random();
        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "12345767890";
        string rv = "";
        do
        {
            rv = "";
            rv += pick(letters, rnd);
            rv += pick(letters, rnd);
            rv += pick(numbers, rnd);
            rv += pick(numbers, rnd);
            rv += pick(numbers, rnd);
            rv += pick(letters, rnd);
            rv += pick(numbers, rnd);
            rv += pick(numbers, rnd);
            rv += pick(numbers, rnd);
            rv += pick(letters, rnd);
            rv += pick(numbers, rnd);
            rv += pick(numbers, rnd);
            rv += pick(numbers, rnd);
            //Keep doing it until the number is unique
        } while (Get_Acct(rv).ID != "New");
        return rv;
    }

    public string pick(string from, Random rnd)
    {
        int roll = rnd.Next(from.Length);
        return from.Substring(roll, 1);
    }


    public void Add(string name, string id)
    {
        ACCT rv = new ACCT(id,name);
        this.items.Add(rv);
    }

    public List<string> IDs_List()
    {
        List<string> rv = new List<string>();
        foreach (ACCT A in this.items)
        {
            rv.Add(A.ID);
        }
        return rv;
    }

}

public class ACTIVITY
{
    public    DateTime record_date = new DateTime();
    public string UID = "";
    public enum ActionType
    {
        Count=1,
        Increase=2,
        Decrease=3,
        nothing=4
    }
    public ActionType Action = ActionType.nothing;
    public decimal Amount = 0;

    public ACTIVITY(string fromDLM)
    {
        string[] fields = fromDLM.Split('§');
        if (fields.Length>3 )
        {
            this.UID = fields[0];
            this.record_date = DateTime.Parse(fields[1]);
            if (fields[2]=="Count")
            {
                this.Action = ActionType.Count;
            }
            else if (fields[2]=="Increase")
            {
                this.Action = ActionType.Increase ;
            }

            else if (fields[2] == "Decrease")
            {
                this.Action = ActionType.Decrease;
            }
            else 
            {
                this.Action = ActionType.nothing;
            }
            this.Amount = Decimal.Parse(fields[3]);
        }
    }
    public string DLM()
    {
        string rv = "";
        rv += this.UID + "§";
        rv += record_date.ToShortDateString() + " " + record_date.ToShortTimeString() + "§";
        rv += Action.ToString()  +"§";
        rv += Amount.ToString() + "§¨";
        return rv;
    }

}
public class Activities
{
    public List<ACTIVITY> items = new List<ACTIVITY>();
    public string desc_Count = "Count";
    public string desc_Increase = "Increase";
    public string desc_Decrease = "Decrease";
    public string desc_Nothing = "Nothing";

    public  Activities(string FromDLM)
    {
        this.items.Clear();
        if (FromDLM == "") return;
        foreach (string s in FromDLM.Split('¨'))
        {
            this.items.Add(new ACTIVITY(s));
        }
    }


    public string Get_Activty_String(ACTIVITY.ActionType Action_Type)
    {
        if (Action_Type == ACTIVITY.ActionType.Count) return this.desc_Count;
        if (Action_Type == ACTIVITY.ActionType.Increase) return this.desc_Increase;
        if (Action_Type == ACTIVITY.ActionType.Decrease) return this.desc_Decrease;
        return this.desc_Nothing;
    }

    public ACTIVITY.ActionType Get_Action_Type(string FromDescription)
    {
        if (FromDescription == this.desc_Count) return ACTIVITY.ActionType.Count;
        if (FromDescription == this.desc_Increase) return ACTIVITY.ActionType.Increase;
        if (FromDescription == this.desc_Decrease) return ACTIVITY.ActionType.Decrease;
        return ACTIVITY.ActionType.nothing;
    }

    public List<ACTIVITY> Get_action(string forUID)
    {
        List<ACTIVITY> rv = new List<ACTIVITY>();
        foreach (ACTIVITY I in  this.items )
        {
            if (I.UID==forUID)
            {
                rv.Add(I);
            }
        }
        return rv;
    }

    public decimal  Get_Balance(string forUID)
    {
        decimal rv = 0;
        foreach (ACTIVITY I in this.items)
        {
            if (I.UID == forUID)
            {
                if (I.Action==ACTIVITY.ActionType.Count )
                {
                    rv = I.Amount;
                }
                if (I.Action == ACTIVITY.ActionType.Decrease)
                {
                    rv -= I.Amount;
                }
                if (I.Action == ACTIVITY.ActionType.Increase)
                {
                    rv += I.Amount;
                }
            }
        }
        return rv;
    }

    public decimal Get_Average(string forUID)
    {
        decimal rv = 0;
        decimal dpct = 0;
        decimal dacum = 0;
        foreach (ACTIVITY I in this.items)
        {
            if (I.UID == forUID)
            {
                if (I.Action == ACTIVITY.ActionType.Count)
                {
                    rv = I.Amount;
                    dacum += rv;
                    dpct += 1;
                }
                if (I.Action == ACTIVITY.ActionType.Decrease)
                {
                    rv -= I.Amount;
                    dacum += rv;
                    dpct += 1;
                }
                if (I.Action == ACTIVITY.ActionType.Increase)
                {
                    rv += I.Amount;
                    dacum += rv;
                    dpct += 1;
                }
                //(If the Action="Nothing" it doesn't count)
            }
        }
        if (dpct == 0) return 0;
        return dacum / dpct;
    }

    public string DLM()
    {
        string rv = "";
        foreach (ACTIVITY A in this.items)
        {
            rv += A.DLM();
        }
        return rv;
    }

}
