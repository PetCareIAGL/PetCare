using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ImageController : Controller
    {
        //Method to convert file into byte array
        public byte[] GetBytesFromFile(HttpPostedFileBase file)
        {
            using (Stream inputStream = file.InputStream)
            {
                MemoryStream memoryStream = inputStream as MemoryStream;
                if (memoryStream == null)
                {
                    memoryStream = new MemoryStream();
                    inputStream.CopyTo(memoryStream);
                }
                return memoryStream.ToArray();
            }
        }

        public ImageModel GetImage(HttpPostedFileBase file)
        {
            ImageModel imgModel = new ImageModel();
            
            if (file != null && file.ContentLength > 0)
            {
                imgModel.description = System.IO.Path.GetFileName(file.FileName);                
                using (var reader = new System.IO.BinaryReader(file.InputStream))
                    imgModel.image = reader.ReadBytes(file.ContentLength);
            }
            return imgModel;
        }
    }
}