using System.IO;
namespace BlocoDLL
{
    class Consumo
    {
        byte[] xml64;
        int ambiente;
        string xml;
        //1 produçao;
        //2 homologação;
        public Consumo(byte[] xml64, int ambiente)
        {
            this.xml64 = xml64;
            this.ambiente = ambiente;
        }
        public Consumo(int ambiente,string xml)
        {
            this.xml = xml;
            this.ambiente = ambiente;
        }

        public string transmitirArquivo()
        {
            if (ambiente == 2)
            {
                BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.TransmitirArquivo(xml64);
            }
            else
            {
                BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.TransmitirArquivo(xml64);
            }
        }
        public string consultarArquivo()
        {

            if (ambiente == 2)
            {
                BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.ConsultarProcessamentoArquivo(xml);
            }
            else
            {
                BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.ConsultarProcessamentoArquivo(xml);
            }            
        }
        public string cancelarArquivo()
        {
            if (ambiente == 2)
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.CancelarArquivo(xml);
            }
            else
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.CancelarArquivo(xml);
            }
        }

        public string consultarHistoricoArquivo()
        {
            if (ambiente == 2)
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.ConsultarHistoricoArquivo(xml);
            }
            else
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.ConsultarHistoricoArquivo(xml);
            }
        }

        public string consultarPendenciasContribuinte()
        {
            if (ambiente == 2)
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.ConsultarPendenciasContribuinte(xml);
            }
            else
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.ConsultarPendenciasContribuinte(xml);
            }
        }
        public string downloadArquivo(string xml)
        {
            if (ambiente == 2)
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.DownloadArquivo(xml);
            }
            else
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.DownloadArquivo(xml);
            }
        }
        public string listarArquivos()
        {
            if (ambiente == 2)
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.ListarArquivos(xml);
            }
            else
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.ListarArquivos(xml);
            }
        }
        public string reprocessarArquivo()
        {
            if (ambiente == 2)
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.ReprocessarArquivo(xml);
            }
            else
            {
               BlocoX.BlocoX Soap = new BlocoX.BlocoX();
                return Soap.ReprocessarArquivo(xml);
            }
        }
        

    }
    
}
