 DLL para consumo Bloco X Santa Catarina
 <h1> TODOS OS METODOS ESTÃO NA CLASSE API</h1>
 
transmitirArquivo -> Este metodo pede 2 parâmetros, o ambiente (1 para produção 2 para homologação) e o caminho do arquivo já assinado digitalmente sendo ele .zip ex: transmitirArquivo(1, "C:\Users\BlocoX\Desktop")

--

consultarArquivo -> Este metodo pede 2 parâmetros, o ambiente (1 para produção 2 para homologação) e uma string com o arquivo xml nos moldes: 
  <?xml version="1.0" encoding="utf-8"?>
  <Manutencao Versao="1.0">
  <Mensagem>
  <Recibo>00000-000000-000-00000-0000</Recibo>
  </Mensagem>
  <Signature>...</Signature>
  </Manutencao>

--

cancelarArquivo->Este metodo pede 2 parâmetros, o ambiente (1 para produção 2 para homologação) e uma string com o arquivo xml nos moldes: 

<Manutencao Versao="1.0">
<Mensagem>
<Recibo>00000-000000-000-00000-0000</Recibo>
<Motivo>Motivo</Motivo>
</Mensagem>
<Signature>...</Signature>
</Manutencao>

--

consultarHistoricoArquivo - >Este metodo pede 2 parâmetros, o ambiente (1 para produção 2 para homologação) e uma string com o arquivo xml nos moldes: 

<?xml version="1.0" encoding="utf-8"?>
<ConsultarHistoricoArquivo Versao="1.0">
<Mensagem>
<Recibo>00000-000000-000-00000-0000</Recibo>
</Mensagem>
<Signature>...</Signature>
</ConsultarHistoricoArquivo>

--

consultarPendenciasContribuinte->  Este metodo pede 2 parâmetros, o ambiente (1 para produção 2 para homologação) e uma string com o arquivo xml nos moldes: 

<ConsultarPendenciasContribuinte Versao="1.0">
<Mensagem>
<IE>000000000</IE>
</Mensagem>
<Signature xmlns="http://www.w3.org/2000/09/xmldsig#">...</Signature>
</ConsultarPendenciasContribuinte>

--

downloadArquivo-> Este metodo pede 2 parâmetros, o ambiente (1 para produção 2 para homologação) e uma string com o arquivo xml nos moldes: 

<DownloadArquivo Versao="1.0">
<Mensagem>
<Recibo>000000-0000-000000-000-00000</Recibo>
</Mensagem>
<Signature>...</Signature>
</DownloadArquivo>

--

listarArquivos-> Este metodo pede 2 parâmetros, o ambiente (1 para produção 2 para homologação) e uma string com o arquivo xml nos moldes: 

<ListarArquivos>
<Mensagem>
<IE>000000000</IE>
</Mensagem>
<Signature>...</Signature>
</ListarArquivos>

--

reprocessarArquivo-> Este metodo pede 2 parâmetros, o ambiente (1 para produção 2 para homologação) e uma string com o arquivo xml nos moldes:

<Manutencao Versao="1.0">
<Mensagem>
<Recibo>00000-000000-000-00000-0000</Recibo>
<Motivo>Motivo</Motivo>
</Mensagem>
<Signature>...</Signature>
</Manutencao>
