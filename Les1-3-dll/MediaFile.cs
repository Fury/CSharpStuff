using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Les1_3_dll
{
    public class MediaFile
    {

        public enum MediaTypes
        {
            Audio,
            Video,
            Book
        }

        public MediaTypes MediaType { get; set; }
        public FileInfo fileInfo { get; set; }
        public string Description { get; set; }

        public MediaFile()
        {
                
        }

        public MediaFile(FileInfo fileInformation, string description = "")
        {
            this.fileInfo = fileInformation;
            if (description == "" && fileInformation != null)
                description = fileInfo.Name;
            this.Description = description;
        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Bestand: " + fileInfo.Name);
            builder.AppendLine("FileType: " + MediaType);

            TimeSpan dateAccess = DateTime.Now.Subtract(fileInfo.LastAccessTime);
            string appendTime = "";

            if(dateAccess.Days > 0)
            {
                appendTime = dateAccess.Days + " dagen geleden";
            }
            else if (dateAccess.Hours > 0)
            {
                appendTime = dateAccess.Hours + " u(u)r(en) geleden";
            }
            else if (dateAccess.Minutes > 0)
            {
                appendTime = dateAccess.Minutes + " minuten geleden";
            }
            else
            {
                appendTime = dateAccess.Seconds + " seconden geleden";
            }

            builder.AppendLine(appendTime);
            return builder.ToString();
        }
    }
}
