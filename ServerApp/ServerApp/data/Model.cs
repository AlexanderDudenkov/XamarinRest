using System;
using System.Collections.Generic;
using System.Text;

namespace ServerApp
{
    class Model
    {       
        public string Created { get; set; }
        public string IdPhoto { get; set; }
        public PhotosUrl PhotosUrl { get; set; }
        public User User { get; set; }
    }
}
