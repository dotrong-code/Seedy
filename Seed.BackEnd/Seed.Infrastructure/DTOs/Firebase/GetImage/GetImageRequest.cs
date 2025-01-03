using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class GetImageRequest
    {
        public string FilePath { get; set; }

        public GetImageRequest(string filePath)
        {  
            FilePath = filePath; 
        }
    }
