# WorkTimer
WorkTimer � um aplicativo de linha de comando para calcular o tempo de trabalho em um dia e se ficou devendo ou recebeu b�nus de acordo com a carga-hor�ria do dia. 

Esse aplicativo obt�m os dados do arquivo calendario.txt que devem ser cadastrados pelo usu�rio e gera um novo arquivo dentro da pasta Relat�rio com os dados processados.

Para utiliz�-lo, adicione no arquivo calendario.txt as entradas de dados seguindo o seguinte padr�o:

- cada linha � o registro de um dia de trabalho e os campos devem ser separados por virgula. O primeiro campo � a Carga Hor�ria, o segundo campo � a data, os demais campos s�o pares de entradas e sa�das.

Carga hor�ria, Data, entrada, sa�da, entrada, sa�da

ex:

8,05/09/2017,8:16,8:39,8:41,11:13,11:21,12:15,14:11,14:30
8,05/09/2017,8:16,8:39, 8:41,11:13, 11:21,12:15, 14:11,14:30, 14:31:35,18:04:25, 18:09:52,18:11:29

Com os dados cadastrados no arquivo calendario.txt basta dar um duplo clique no aplicativo WorkTimer. 
Assim que ele efetuar o processamento acesse a pasta relat�rio e abra o arquivo gerado para analisar os dados.

O Resultado do exemplo anterior � o seguinte:

|CH:8| Data: 05/09/2017| Tempo trabalho:04:08:00| CH menos tempo trabalho:-03:52:00
|CH:8| Data: 05/09/2017| Tempo trabalho:07:42:27| CH menos tempo trabalho:-00:17:33

O sinal negativo no �ltimo valor indica que a pessoa trabalhou menos do que a carga-hor�ria estipulada, portanto est� devendo horas.
O sinal positivo indica que a pessoa trabalhou mais do que a carga-hor�ria e portanto possui b�nus hora.