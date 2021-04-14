using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Frbar.Azure.WinContainerFileShare.Api
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TreeStructure = ListDirectoryAndSubDirectories("c:/mount/", 0);
        }

        public string TreeStructure { get; private set; }

        private string ListDirectoryAndSubDirectories(string path, int depth)
        {
            var txt = "";
            var padding = "";

            for (var i = 0; i < depth; i++)
            {
                padding += " ";
            }

            foreach (var subDir in Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly))
            {
                txt += $"{padding}[{Path.GetFileName(subDir)}]{Environment.NewLine}";
                txt += ListDirectoryAndSubDirectories(subDir, depth + 1);
            }

            foreach (var file in Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly))
            {
                var fileInfo = new FileInfo(file);
                txt += $"{padding}{Path.GetFileName(file)}({fileInfo.Length} - {fileInfo.LastWriteTimeUtc}){Environment.NewLine}";
            }

            return txt;
        }
    }
}