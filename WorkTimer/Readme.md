# WorkTimer
WorkTimer is a console app wrote in C# and .NET Core, you can run it in Windows, Ubuntu or OSx. I've tested it just in Windows.
This app calculates the worked time in a particular day. So you'll know the time worked and how much time you need to work if you work less then a minimum number of hours.

This app get the data from the file schedule.txt. You should write the data on it like the example bellow:

8,05/09/2017,8:16,8:39,8:41,11:13,11:21,12:15,14:11,14:30
8,05/09/2017,8:16,8:39, 8:41,11:13, 11:21,12:15, 14:11,14:30, 14:31:35,18:04:25, 18:09:52,18:11:29

The pattern above means: 
minimum hour por day in the job, Date, entry Time, Exit Time, Entry Time, Exit Time 

All the itens separated by a comma. After the date, all peers are entry and exit time. 

After put da data you should execute WorkTimer app, double click in it. 

Then look for the folder Report and open the specific file with your result.


## The result looks like this:

|hours per day:8| Date: 05/09/2017| worked time:04:08:00| hours per day minus worked time:-03:52:00
|hours per day:8| Date: 05/09/2017| Worked Time:07:42:27| hours per day minus worked time:-00:17:33


### Bellow helper in Portuguese

# WorkTimer
WorkTimer � um aplicativo de linha de comando para calcular o tempo de trabalho em um dia e se ficou devendo ou recebeu b�nus de acordo com a carga-hor�ria do dia. 

Esse aplicativo obt�m os dados do arquivo calendario.txt que devem ser cadastrados pelo usu�rio e gera um novo arquivo dentro da pasta Relat�rio com os dados processados.

Para utiliz�-lo, adicione no arquivo calendario.txt as entradas de dados seguindo o seguinte padr�o:

- cada linha � o registro de um dia de trabalho e os campos devem ser separados por virgula. O primeiro campo � a Carga Hor�ria, o segundo campo � a data, os demais campos s�o pares de entradas e sa�das.

Carga hor�ria, Data, entrada, sa�da, entrada, sa�da

## ex:

8,05/09/2017,8:16,8:39,8:41,11:13,11:21,12:15,14:11,14:30
8,05/09/2017,8:16,8:39, 8:41,11:13, 11:21,12:15, 14:11,14:30, 14:31:35,18:04:25, 18:09:52,18:11:29

Com os dados cadastrados no arquivo calendario.txt basta dar um duplo clique no aplicativo WorkTimer. 
Assim que ele efetuar o processamento acesse a pasta relat�rio e abra o arquivo gerado para analisar os dados.

## O Resultado do exemplo anterior � o seguinte:

|CH:8| Data: 05/09/2017| Tempo trabalho:04:08:00| CH menos tempo trabalho:-03:52:00
|CH:8| Data: 05/09/2017| Tempo trabalho:07:42:27| CH menos tempo trabalho:-00:17:33

O sinal negativo no �ltimo valor indica que a pessoa trabalhou menos do que a carga-hor�ria estipulada, portanto est� devendo horas.
O sinal positivo indica que a pessoa trabalhou mais do que a carga-hor�ria e portanto possui b�nus hora.

## publica��o do arquivo 

`dotnet publish --self-contained`


