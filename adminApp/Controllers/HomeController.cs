using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using adminApp.Models;
using System.Net.Http;
using Nancy.Json;
using System.Net;
using System.Dynamic;
using System.Text;

namespace adminApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();
            string json1 = await client.GetStringAsync("http://springdevops:8080/allPlaylist");
            string json2 = await client.GetStringAsync("http://springdevops:8080/allFeedbacks");


            playlist[] playlistList = new JavaScriptSerializer().Deserialize<playlist[]>(json1);
            feedback[] feedbackList = new JavaScriptSerializer().Deserialize<feedback[]>(json2);
            List<playlist> list1=new List<playlist>();
            List<feedback> list2=new List<feedback>();
            for(var i=0;i<playlistList.Length;i++){
                list1.Add(playlistList[i]);
            }
            for(var i=0;i<feedbackList.Length;i++){
                list2.Add(feedbackList[i]);
            }
            dynamic mymodel = new ExpandoObject();
            mymodel.Playlists=list1;
            mymodel.Feedbacks=list2;
            return View(mymodel);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult> Index(String playlistName,String playlistUrl)
        {
            Console.WriteLine("playlistname here" + playlistName);
            Console.WriteLine("playlisturl here" + playlistUrl);
            playlist newone = new playlist {
                playlist_name = playlistName,
                playlist_url = playlistUrl };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://springdevops:8080/");
            HttpResponseMessage response = client.PostAsync("/addPlaylist", new StringContent(
   new JavaScriptSerializer().Serialize(newone), Encoding.UTF8, "application/json")).Result;

            HttpClient client1 = new HttpClient();
            string json1 = await client1.GetStringAsync("http://springdevops:8080/allPlaylist");
            string json2 = await client1.GetStringAsync("http://springdevops:8080/allFeedbacks");


            playlist[] playlistList = new JavaScriptSerializer().Deserialize<playlist[]>(json1);
            feedback[] feedbackList = new JavaScriptSerializer().Deserialize<feedback[]>(json2);
            List<playlist> list1 = new List<playlist>();
            List<feedback> list2 = new List<feedback>();
            for (var i = 0; i < playlistList.Length; i++)
            {
                list1.Add(playlistList[i]);
            }
            for (var i = 0; i < feedbackList.Length; i++)
            {
                list2.Add(feedbackList[i]);
            }
            dynamic mymodel = new ExpandoObject();
            mymodel.Playlists = list1;
            mymodel.Feedbacks = list2;


            if (response.IsSuccessStatusCode)
            {
                
                return View("Index",mymodel);
            }
            else
            {
                ViewBag.alertMessage = "Https Error: Check the URL format to be 0-100";
                return View("Error");
            }
        }
        public async Task<ActionResult> Delete(int? id)
        {
            Console.WriteLine("ID here" +id);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://springdevops:8080/delPlaylist?key="+id);
            if (response.IsSuccessStatusCode)
            {
                HttpClient client1 = new HttpClient();
                string json1 = await client1.GetStringAsync("http://springdevops:8080/allPlaylist");
                string json2 = await client1.GetStringAsync("http://springdevops:8080/allFeedbacks");


                playlist[] playlistList = new JavaScriptSerializer().Deserialize<playlist[]>(json1);
                feedback[] feedbackList = new JavaScriptSerializer().Deserialize<feedback[]>(json2);
                List<playlist> list1 = new List<playlist>();
                List<feedback> list2 = new List<feedback>();
                for (var i = 0; i < playlistList.Length; i++)
                {
                    list1.Add(playlistList[i]);
                }
                for (var i = 0; i < feedbackList.Length; i++)
                {
                    list2.Add(feedbackList[i]);
                }
                dynamic mymodel = new ExpandoObject();
                mymodel.Playlists = list1;
                mymodel.Feedbacks = list2;
                return View("Index", mymodel);
            }
            else
            {
                ViewBag.alertMessage = "Https Error: Entry could not be deleted";
                return View("Error");
            }

        }

        public async Task<ActionResult> Edit(int playlistId, String playlistUrl, List<playlist> playlists)
        {
            String playlistName = "";
            for (var i = 0; i < playlists.Count; i++)
            {
                if (playlists[i].id == playlistId)
                {
                    playlistName = playlists[i].playlist_name;
                }
            }
            playlist newone = new playlist
            {
                id = playlistId,
                playlist_name = playlistName,
                playlist_url = playlistUrl
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://springdevops:8080/");
            HttpResponseMessage response = client.PostAsync("editIt?key=" + playlistId, new StringContent(
   new JavaScriptSerializer().Serialize(newone), Encoding.UTF8, "application/json")).Result;

            HttpClient client1 = new HttpClient();
            string json1 = await client1.GetStringAsync("http://springdevops:8080/allPlaylist");
            string json2 = await client1.GetStringAsync("http://springdevops:8080/allFeedbacks");


            playlist[] playlistList = new JavaScriptSerializer().Deserialize<playlist[]>(json1);
            feedback[] feedbackList = new JavaScriptSerializer().Deserialize<feedback[]>(json2);
            List<playlist> list1 = new List<playlist>();
            List<feedback> list2 = new List<feedback>();
            for (var i = 0; i < playlistList.Length; i++)
            {
                list1.Add(playlistList[i]);
            }
            for (var i = 0; i < feedbackList.Length; i++)
            {
                list2.Add(feedbackList[i]);
            }
            dynamic mymodel = new ExpandoObject();
            mymodel.Playlists = list1;
            mymodel.Feedbacks = list2;


            if (response.IsSuccessStatusCode)
            {

                return View("Index", mymodel);
            }
            else
            {
                ViewBag.alertMessage = "Https Error: Check the URL format to be 0-100";
                return View("Error");
            }
        }
        public ActionResult Email(string email,string response)
        {
            Console.WriteLine(" email here" + email);
            Console.WriteLine(" response here" + response);
            Response newone = new Response
            {
                email=email,
                response=response
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://springdevops:8080/");
            HttpResponseMessage response1 = client.PostAsync("sendEmail", new StringContent(
   new JavaScriptSerializer().Serialize(newone), Encoding.UTF8, "application/json")).Result;
            if (response1.IsSuccessStatusCode)
            {

                return Ok();
            }
            else
            {
                return BadRequest();
            }
            //return View("Index");
        }
        /*
         public ActionResult delete()
        {
            //return new HttpStatusCodeResult(HttpStatusCode.OK);  // OK = 200
        }
        [HttpPost]
         public ActionResult edit()
        {
            //return new HttpStatusCodeResult(HttpStatusCode.OK);  // OK = 200
        }
        [HttpPost]
         public ActionResult add()
        {
            return;
        }
        [HttpPost]
         public ActionResult email()
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);  // OK = 200
        }
        */

        public async Task<ActionResult> Gender()
        {
            HttpClient client = new HttpClient();
            string json1 = await client.GetStringAsync("http://springdevops:8080/genderMongo");
            Gender[] genderList = new JavaScriptSerializer().Deserialize<Gender[]>(json1);
            ViewBag.genders = new List<Gender>();
            ViewBag.genders.Add(genderList[0]);
            ViewBag.genders.Add(genderList[1]);


            return View();
        }

        public async Task<ActionResult> Age()
        {
            HttpClient client = new HttpClient();
            string json2 = await client.GetStringAsync("http://springdevops:8080/ageMongo");
            Age[] ageList = new JavaScriptSerializer().Deserialize<Age[]>(json2);
            ViewBag.ages = new List<Age>();
            ViewBag.ages.Add(ageList[0]);
            ViewBag.ages.Add(ageList[1]);
            ViewBag.ages.Add(ageList[2]);
            ViewBag.ages.Add(ageList[3]);
            ViewBag.ages.Add(ageList[4]);
            ViewBag.ages.Add(ageList[5]);

            return View();
        }

        public async Task<ActionResult> Count()
        {
            HttpClient client = new HttpClient();
            string json2 = await client.GetStringAsync("http://springdevops:8080/countMongo");
            Count[] countList = new JavaScriptSerializer().Deserialize<Count[]>(json2);

            ViewBag.counts = new List<Count>();
            ViewBag.counts.Add(countList[0]);
            ViewBag.counts.Add(countList[1]);
            ViewBag.counts.Add(countList[2]);
            ViewBag.counts.Add(countList[3]);
            ViewBag.counts.Add(countList[4]);
            return View();
        }

        public async Task<ActionResult> Top()
        {
            HttpClient client = new HttpClient();
            string json2 = await client.GetStringAsync("http://springdevops:8080/topMongo");
            Top[] topList = new JavaScriptSerializer().Deserialize<Top[]>(json2);

            ViewBag.tops = new List<Top>();
            ViewBag.tops.Add(topList[0]);
            ViewBag.tops.Add(topList[1]);
            ViewBag.tops.Add(topList[2]);
            ViewBag.tops.Add(topList[3]);
            ViewBag.tops.Add(topList[4]);
            return View();
        }
    }
}
