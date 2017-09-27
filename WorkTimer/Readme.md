# WorkTimer
WorkTimer is a console app wrote in C# and .NET Core, you can run it in Windows, Ubuntu or OSx. I've tested it just in Windows.
This app calculates the worked time in a particular day. So you'll know the time worked and how much time you need to work if you work less then a minimum number of hours.

This app get the data from the file schedule.txt. You should write the data on it like the example bellow:

8,05/09/2017,8:16,8:39,8:41,11:13,11:21,12:15,14:11,14:30

8,05/09/2017,8:16,8:39, 8:41,11:13, 11:21,12:15, 14:11,14:30, 14:31:35,18:04:25, 18:09:52,18:11:29

The pattern above means: 
minimum hour por day in the job, Date, entry Time, Exit Time, Entry Time, Exit Time 

All the itens separated by a comma. After the date, all peers are entry and exit time. 

After put the data you should execute WorkTimer app, double click on it. 

Then look for the folder Report and open the specific file with your result.


## The result looks like this:

|hours per day:8| Date: 05/09/2017| worked time:04:08:00| hours per day minus worked time:-03:52:00

|hours per day:8| Date: 05/09/2017| Worked Time:07:42:27| hours per day minus worked time:-00:17:33

## publishing the app

Open cmd prompt and access the root directory of the app and digit:

'dotnet publish -c release -r win-x64'

## Installing in other machine with Windows 64 bits

1. Create a folder with the name WorkTimer
2. Inside of WorkTimer folder make a new folder with report name
3. Inside of WorkTimer make a new folder with app name
4. Copy al files from folder \bin\Release\netcoreapp2.0\win-x64\publish to the app folder
5. Open app folder and create a Windows shortcut from WorkTimer.exe file. 
6. Copy the shortcut to root folder WorkTimer
8. Create a new file called schedulle.txt in root folder WorkTimer and add to it the data. Eg: `8,07/09/2017,8:00,12:00,14:00,18:00`
9. Double click on the shortcut WorkTimer
10. Finally access the folder report to see the results

### Bellow helper in Portuguese

# WorkTimer
WorkTimer é um aplicativo de linha de comando para calcular o tempo de trabalho em um dia e se ficou devendo ou recebeu bônus de acordo com a carga-horária do dia. 

Esse aplicativo obtém os dados do arquivo calendario.txt que devem ser cadastrados pelo usuário e gera um novo arquivo dentro da pasta Relatório com os dados processados.

Para utilizá-lo, adicione no arquivo calendario.txt as entradas de dados seguindo o seguinte padrão:

- cada linha é o registro de um dia de trabalho e os campos devem ser separados por virgula. O primeiro campo é a Carga Horária, o segundo campo é a data, os demais campos são pares de entradas e saídas.

Carga horária, Data, entrada, saída, entrada, saída

## ex:

8,05/09/2017,8:16,8:39,8:41,11:13,11:21,12:15,14:11,14:30

8,05/09/2017,8:16,8:39, 8:41,11:13, 11:21,12:15, 14:11,14:30, 14:31:35,18:04:25, 18:09:52,18:11:29

Com os dados cadastrados no arquivo calendario.txt basta dar um duplo clique no aplicativo WorkTimer. 
Assim que ele efetuar o processamento acesse a pasta relatório e abra o arquivo gerado para analisar os dados.

## O Resultado do exemplo anterior é o seguinte:

|CH:8| Data: 05/09/2017| Tempo trabalho:04:08:00| CH menos tempo trabalho:-03:52:00

|CH:8| Data: 05/09/2017| Tempo trabalho:07:42:27| CH menos tempo trabalho:-00:17:33

O sinal negativo no último valor indica que a pessoa trabalhou menos do que a carga-horária estipulada, portanto está devendo horas.
O sinal positivo indica que a pessoa trabalhou mais do que a carga-horária e portanto possui bônus hora.

## publicação do app 

'dotnet publish -c release -r win-x64'

## Instalação em outra máquina

1. Cria uma pasta como o nome WorkTimer
2. Dentro da pasta WorkTimer cria uma pasta com o nome Relatorio
3. Dentro da pasta WorkTimer cria uma pasta como o nome app
4. Copia todos os arquivos que estão na pasta \bin\Release\netcoreapp2.0\win-x64\publish para a pasta app dentro dessa pasta WorkTimerque acabou de ser criada
5. Abre a pasta app e cria um atalho de Windows, a partir do arquivo WorkTimer.exe. 
6. Copia esse atalho criado para a pasta raiz WorkTimer
8. Cria um arquivo com o nome calendario.txt na pasta raiz WorkTimer e preenche com os dados a serem processados. Ex: `8,07/09/2017,8:00,12:00,14:00,18:00`
9. Após isso dá um duplo clique no atalho WorkTimer
10. Acessa a pasta relatório e abre os arquivos para ver os resultados.



