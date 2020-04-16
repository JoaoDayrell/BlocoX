using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlocoDLL
{
    public class Api
        
    {
        public string transmitirArquivo(int ambiente, string caminho)
        {
            Consumo soap = new Consumo(EncodeTo64(caminho), ambiente);
            return soap.transmitirArquivo();
            
        }
        public string consultarArquivo(int ambiente, string xml)
        {
            Consumo soap = new Consumo(ambiente, xml);
            return soap.consultarArquivo();
        }
        public string cancelarArquivo(int ambiente, string xml)
        {
            Consumo soap = new Consumo(ambiente, xml);
            return soap.cancelarArquivo();
        }
        public string consultarHistoricoArquivo(int ambiente, string xml)
        {
            Consumo soap = new Consumo(ambiente, xml);
            return soap.consultarHistoricoArquivo();
        }
        public string consultarPendenciasContribuinte(int ambiente, string xml)
        {
            Consumo soap = new Consumo(ambiente, xml);
            return soap.consultarPendenciasContribuinte();
        }
        public string downloadArquivo(int ambiente, string xml)
        {
            Consumo soap = new Consumo(ambiente, xml);
            return soap.downloadArquivo(xml);
        }
        public string listarArquivos(int ambiente, string xml)
        {
            Consumo soap = new Consumo(ambiente, xml);
            return soap.listarArquivos();
        }
        public string reprocessarArquivo(int ambiente, string xml)
        {
            Consumo soap = new Consumo(ambiente, xml);
            return soap.consultarArquivo();
        }
        private byte[] EncodeTo64(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            FileInfo fi = new FileInfo(filename);

            // Create a byte array of file stream length
            byte[] ImageData = new byte[fs.Length];

            //Read block of bytes from stream into the byte array
            fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));

            //Close the File Stream
            fs.Close();
            //fi.Delete();
            return ImageData; //return the byte data
        }
    }
}
