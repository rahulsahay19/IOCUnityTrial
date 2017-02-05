﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOCUnityTrial.Models
{
    public class Movie 
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public string ReleaseYear { get; set; }
    }
}