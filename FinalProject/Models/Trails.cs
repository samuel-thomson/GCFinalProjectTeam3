﻿using Newtonsoft.Json.Linq;

namespace FinalProject.Models
{
    public class Trails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Difficulty { get; set; }
        //public double Stars { get; set; }
        //public double StarVotes { get; set; }
        public string Location { get; set; }
        //public string URL { get; set; }
        //public string ImgSqSmall { get; set; }
        //public string ImgSmall { get; set; }
        public string ImgSmallMed { get; set; }
        //public string ImgMedium { get; set; }

        public decimal Length { get; set; }
        //public int Ascent { get; set; }
        //public int Descent { get; set; }
        //public int High { get; set; }
        //public int Low { get; set; }
        //public decimal Longitude { get; set; }
        //public decimal Latitude { get; set; }
        //public string ConditionStatus { get; set; }
        //public string ConditionDetails { get; set; }
        //public Datetime ConditionDate { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }


        public Trails()
        {

        }
        public Trails(JToken t)
        {
            this.Id = int.Parse(t["id"].ToString());
            this.Name = t["name"].ToString();
            this.Summary = t["summary"].ToString();
            this.Difficulty = t["difficulty"].ToString();
            //this.Stars = double.Parse(t["stars"].ToString());
            //this.StarVotes = double.Parse(t["starVotes"].ToString());
            this.Location = t["location"].ToString();
            //this.ImgSqSmall = t["imgSqSmall"].ToString();
            this.ImgSmallMed = t["imgSmallMed"].ToString();
            //this.ImgSmall = t["imgSmall"].ToString();
            // this.ImgMedium = t["imgMedium"].ToString();
            this.Length = decimal.Parse(t["length"].ToString());
            //this.Ascent = int.Parse(t["ascent"].ToString());
            //this.Descent = int.Parse(t["descent"].ToString());
            //this.High = int.Parse(t["high"].ToString());
            //this.Low = int.Parse(t["low"].ToString());
            //this.Longitude = decimal.Parse(t["longitude"].ToString());
            //this.Latitude = decimal.Parse(t["latitude"].ToString());
            //this.ConditionStatus = t["conditionStatus"].ToString();
            //this.ConditionDetails = t["conditionDetails"].ToString();


        }
    }
}