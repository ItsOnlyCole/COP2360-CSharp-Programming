//Cole Hemp
//COP2360
//3/18/18
//StateAreaCodes.cs
//A class for checking and managing state area codes

namespace StateAreaCodes
{
    class StateAreaCodes
    {
        //Properties
        public string StateInitials { get; set; }
        public int[] AreaCodes { get; set; }

        //Default Constructor
        public StateAreaCodes()
        {

        }
        //Overloaded Constructor
        public StateAreaCodes(string stateInitials, int[] areaCodes)
        {
            this.AreaCodes = areaCodes;
            this.StateInitials = stateInitials;
        }

        //Checks if user's inputed area code is in the array
        public bool CheckForAreaCode(int userInput)
        {
            for(int i = 0; i < AreaCodes.Length; i++)
            {
                if(userInput == AreaCodes[i])
                {
                    //Returns true if there is a match
                    return true;
                }
            }

            //If no match happens in the for loop, returns false
            return false;
        }

        public override string ToString()
        {
            string outputString;

            outputString = StateInitials + ": ";

            for(int i = 0; i < AreaCodes.Length; i++)
            {
                outputString = outputString + "(" + AreaCodes[i] + ") ";
            }
            return outputString;
        }
    }
}
