using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Final
{
    class GameInfo
    {
        // private properties
        private string totalscore;
        private string playeronename;
        private string playeronescore;
        private string playertwoname;
        private string playertwoscore;
        private string playerthreename;
        private string playerthreescore;

        // public properties
        public string TotalScore { get => totalscore; set => totalscore = value; }
        public string PlayerOneName { get => playeronename; set => playeronename = value; }
        public string PlayerOneScore { get => playeronescore; set => playeronescore = value; }
        public string PlayerTwoName { get => playertwoname; set => playertwoname = value; }
        public string PlayerTwoScore { get => playertwoscore; set => playertwoscore = value; }
        public string PlayerThreeName { get => playerthreename; set => playerthreename = value; }
        public string PlayerThreeScore { get => playerthreescore; set => playerthreescore = value; }

        // constructors
        public GameInfo()
        {

        }

        public GameInfo(string totalscore, string playeronename, string playeronescore, string playertwoname, string playertwoscore, string playerthreename, string playerthreescore)
        {
            this.totalscore = totalscore;
            this.playeronename = playeronename;
            this.playeronescore = playeronescore;
            this.playertwoname = playertwoname;
            this.playertwoscore = playertwoscore;
            this.playerthreename = playerthreename;
            this.playerthreescore = playerthreescore;
        }

        // insert override tostring if something doesn't work
        public override string ToString()
        {
            string returnString = "";
            returnString += $"Total Score: {TotalScore}   \n";
            returnString += $"Player One Name: {PlayerOneName}   \n";
            returnString += $"Player One Score: {PlayerOneScore}   \n";
            returnString += $"Player Two Name: {PlayerTwoName}   \n";
            returnString += $"Player Two Score: {PlayerTwoScore}   \n";
            returnString += $"Player Three Name: {PlayerThreeName}   \n";
            returnString += $"Player Three Score: {PlayerThreeScore}   \n";
            return returnString;
        }

        // arraylist return
        public static ArrayList GetAllGameInfo()
        {
            return DataAccess.GetGameInfo();
        }
    }
}
