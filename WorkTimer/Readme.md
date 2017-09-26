# WorkTimer
WorkTimer é um aplicativo de linha de comando para calcular o tempo de trabalho em um dia e se ficou devendo ou recebeu bônus de acordo com a carga-horária do dia. 

Esse aplicativo obtém os dados do arquivo calendario.txt que devem ser cadastrados pelo usuário e gera um novo arquivo dentro da pasta Relatório com os dados processados.

Para utilizá-lo, adicione no arquivo calendario.txt as entradas de dados seguindo o seguinte padrão:

- cada linha é o registro de um dia de trabalho e os campos devem ser separados por virgula. O primeiro campo é a Carga Horária, o segundo campo é a data, os demais campos são pares de entradas e saídas.

Carga horária, Data, entrada, saída, entrada, saída

ex:

8,05/09/2017,8:16,8:39,8:41,11:13,11:21,12:15,14:11,14:30
8,05/09/2017,8:16,8:39, 8:41,11:13, 11:21,12:15, 14:11,14:30, 14:31:35,18:04:25, 18:09:52,18:11:29

Com os dados cadastrados no arquivo calendario.txt basta dar um duplo clique no aplicativo WorkTimer. 
Assim que ele efetuar o processamento acesse a pasta relatório e abra o arquivo gerado para analisar os dados.

O Resultado do exemplo anterior é o seguinte:

|CH:8| Data: 05/09/2017| Tempo trabalho:04:08:00| CH menos tempo trabalho:-03:52:00
|CH:8| Data: 05/09/2017| Tempo trabalho:07:42:27| CH menos tempo trabalho:-00:17:33

O sinal negativo no último valor indica que a pessoa trabalhou menos do que a carga-horária estipulada, portanto está devendo horas.
O sinal positivo indica que a pessoa trabalhou mais do que a carga-horária e portanto possui bônus hora.