﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Forsaj.Extensions
{
    public static class IFormFileExtensions
    {
        public static bool IsFile(this IFormFile file)
        {
            //pdf, .doc, .docx, .txt, .xls, .xlsx, . .ppt, .pptx, .jpeg, .jpg, .png
            return Path.GetExtension(file.FileName) == ".pdf" ||
              Path.GetExtension(file.FileName) == ".doc" ||
                Path.GetExtension(file.FileName) == ".docx" ||
                Path.GetExtension(file.FileName) == ".txt" ||
                 Path.GetExtension(file.FileName) == ".xls" ||
                 Path.GetExtension(file.FileName) == ".xlsx" ||
                 Path.GetExtension(file.FileName) == ".ppt" ||
               Path.GetExtension(file.FileName) == ".pptx" ||
               Path.GetExtension(file.FileName) == ".jpeg" ||
                 Path.GetExtension(file.FileName) == ".jpg" ||
                 Path.GetExtension(file.FileName) == ".PNG" ||
                 Path.GetExtension(file.FileName) == ".JPG" ||
                 Path.GetExtension(file.FileName) == ".PDF" ||
                 Path.GetExtension(file.FileName) == ".DOC" ||
                 Path.GetExtension(file.FileName) == ".XLSX" ||
                 Path.GetExtension(file.FileName) == ".PPT" ||
                 Path.GetExtension(file.FileName) == ".XLS" ||
                 Path.GetExtension(file.FileName) == ".DOC" ||
                 Path.GetExtension(file.FileName) == ".DOCX" ||
                 Path.GetExtension(file.FileName) == ".TXT" ||
                 Path.GetExtension(file.FileName) == ".JPEG" ||
               Path.GetExtension(file.FileName) == ".png";
        }

        public async static Task<string> SaveImagesAsync(this IFormFile image, string root, string subFolder)
        {
            string fullname = Path.Combine(Guid.NewGuid().ToString() +Path.GetFileName(image.FileName)  );
            string uploads = Path.Combine(root, "Document", subFolder);
            string pathfile = Path.Combine(uploads, fullname);
            using (var steam = new FileStream(pathfile, FileMode.Create))
            {
                await image.CopyToAsync(steam);
            }
            return fullname;
        }

    }
}
