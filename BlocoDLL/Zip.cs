using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;
using System.IO;

namespace BlocoDLL.Relatorio
{
    class Zip
    {
        public string zipFIle(string path)
        {
            ZipFile zip = new ZipFile();
            zip.AddFile(path,"XML Assinado");
            path = path.Substring(0, (path.Length - 4));
            path = ($@"{path}.zip");
            zip.Save(path);
            return path;
      }
    }
}
