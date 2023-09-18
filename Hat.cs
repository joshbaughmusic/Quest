namespace Quest;

public class Hat
{
    public int ShininessLevel { get; set; }

    public string ShininessDescription { 
        get
        {
            string description = null;

            if (ShininessLevel < 2)
            {
                description = "dull";
            }
            else if (ShininessLevel >= 2 || ShininessLevel <= 5 )
            {
                description = "noticable";
            }
            else if (ShininessLevel >= 6 || ShininessLevel <= 9 )
            {
                description = "bright";
            }
            else if (ShininessLevel > 9 )
            {
                description = "blinding";
            }

            return description;
        }
    }
}