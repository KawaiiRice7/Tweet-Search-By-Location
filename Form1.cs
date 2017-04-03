using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;
using Tweetinvi.WebLogic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace TwitterAPIForms
{
    
    public partial class Form1 : Form
    {



        public Form1()
        {
            //Twitter API
            Auth.SetUserCredentials("ckey", "csecret", "atoken", "atokensecret");
            //My creds. Consumer key, consumer secret, access token, access token secret.
            var user = User.GetAuthenticatedUser();
            InitializeComponent();
            label2.Text = user.ScreenName;
        }

        private void SearchConfirm_Click(object sender, EventArgs e)
        {
            QueryResult.Clear();
            var locationQuery = LocationEntry.Text;

            //Google Place API
            //Search the location name for the GeoCode.
            string googleAPIKey = "yourapikey";
            
            string mapsAPI = String.Format("https://maps.googleapis.com/maps/api/place/textsearch/json?query={0}&key={1}", locationQuery, googleAPIKey);
            var json2 = new WebClient().DownloadString(mapsAPI);
            JObject myJson2 = JObject.Parse(json2);
            double latitude = 0;
            double longitude = 0;
            foreach (var i in myJson2["results"])
            {
                latitude = double.Parse(i["geometry"]["location"]["lat"].ToString());
                longitude = double.Parse(i["geometry"]["location"]["lng"].ToString());
            }

            //Place the GeoCode into the Search Params.
            var searchParameter = new SearchTweetsParameters(SearchEntry.Text)
            {
                GeoCode = new GeoCode(latitude, longitude, 1000, DistanceMeasure.Miles),
                Lang = LanguageFilter.English
            };

            var tweets = Search.SearchTweets(searchParameter);
            foreach (var i in tweets)
            {
                QueryResult.AppendText(i.ToString());
                QueryResult.AppendText("\n");
            }
        }
    }
}
