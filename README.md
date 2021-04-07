# EfsTools. Консольная программа для доступа к файловой системе EFS модемов Qualcomm

Программа позволяет:
- Получить информацию о подключенном устройстве
- Получить информацию о параметрах файловой сиситемы EFS
- Прочитать файл из устройства в компьютер
- Записать файл из компьютера в устройство
- Удалить файл с устройства
- Переименовать (переместить) файл на устройстве
- Создать каталог в устройстве
- Удалить каталог на устройстве
- Получить список файлов и каталогов 
- Загрузить каталог из устройства на компьютер
- Загрузить каталог с компьютера на утройство.

## Системные требования

- Windows 10 1607 и новее, Windows Server 2012 R2 и новее, Mac OS X 10.13 и новее, Red Hat Enterprise Linux 7 и новее, CentOS 7 и новее, Ubuntu 16.04 и новее, Fedora 30 и новее, Debian 9 и новее, OpenSUSE 15 и новее
- [DotNet 5.0](https://dotnet.microsoft.com/download/dotnet/5.0) и выше.

## Установка
Необходимо скачать архив релиза с [сайта разработчика](http://johnbel.github.io/). Затем распаковать его.

## Конфигурация
Настройки программы хранятся в файле EfsTools.exe.config. Перед началом работы необходимо указать имя COM-порта (параметр ***port***) и его скорость (***baudrate***).

## Параметры командной строки

EfsTools.exe <команда> [параметры команды]

### Список команд
  
***targetInfo***
Получение информации о подключенном устройстве.

Пример: EfsTools.exe targetInfo

***efsInfo***
Получение информации о файловой системе EFS в устройстве

Пример: EfsTools.exe efsInfo

***readFile***
Чтение файла с утройства на компьютер

Пример: EfsTools.exe readFile -i /safe/test/efs -o c:\temp\efs

***writeFile***
Запись файла с компьютера на утройство

Пример: EfsTools.exe writeFile -i c:\temp\efs -o /safe/test/efs

***renameFile***
Переименовать файл на устройстве

Пример: EfsTools.exe renameFile -p /safe/test/efs -n /safe/test/efs2


***deleteFile***
Удалить файл на устройстве

Пример: EfsTools.exe deleteFile -p /safe/test/efs

***createDirectory***
Создать каталог на устройстве

Пример: EfsTools.exe createDirectory -p /safe/test/efs


***deleteDirectory***
Удалить каталог на устройстве

Пример: EfsTools.exe deleteDirectory -p /safe/test/efs


***listDirectory***
Получить список файлов и каталогов 

Пример: EfsTools.exe listDirectory -p /safe/test/efs -r

***downloadDirectory***
Загрузить каталог с устройства на компьютер

Пример: EfsTools.exe downloadDirectory -i / -o c:\backup\efs


***uploadDirectory***
Загрузить каталог c компьютера на устройство

Пример: EfsTools.exe uploadDirectory -i c:\backup\efs -o /


***getModemConfig***
Сгенерировать конфигурацию модема используя устройство или каталог (параметр -i) с EFS-структурой

Пример: EfsTools.exe getModemConfig -i .\backup -p .\items_backup.json 
EfsTools.exe getModemConfig -p .\items_phone.json 


***setModemConfig***
Установить конфигурацию модема в устройстве или сгененировать EFS-структуру в каталоге (параметр -o)

Пример: EfsTools.exe setModemConfig -p .\items.json -o .\efs
EfsTools.exe setModemConfig -p .\items_for_phone.json


***extractMbn***
Распаковать содержимое MBN (Modem configuration BiNary) файла в указанную директорию
Пример: EfsTools.exe extractMbn -i mcfg_sw.mbn -p mcfg

***getLog***
Начать захват логов и сообщений модема

Пример: EfsTools.exe getLog -l IMS_MESSAGE

***webDavServer***
Запуск WebDAV сервера

Пример: EfsTools.exe webDavServer  -p 8888 -r 1
  
  
***help***
Показать справку о команде

Пример: EfsTools.exe help createDirectory

***version***
Отобразить версию программы

Пример: EfsTools.exe version

## Лицензии
Данная программное обеспечение распространяется по лицензии [MIT](/License.md)

Программа использует библиотеку [Commandline](https://github.com/commandlineparser/commandline) Copyright (c) 2005 - 2015 Giacomo Stelluti Scala & Contributors

Программа использует библиотеку [NWebDav](https://github.com/ramondeklein/nwebdav) Copyright (c) 2018 Ramon de Klein

Программа использует библиотеку [Newtonsoft.Json](https://www.newtonsoft.com/json) Copyright (c) 2007 James Newton-King

Программа использует библиотеку [ELFSharp] (http://elfsharp.hellsgate.pl) Copyright (c) Konrad Kruczyński, iotr Zierhoffer, Łukasz Kucharski, Bastian Eicher, Cameron, Fox, Frederik Carlier, Everett Maus

Протокол работы с модемами Qualcomm был прочитан в проекте [libopenpst](https://github.com/openpst/libopenpst) Copyright (c) Gassan Idriss

## Сайт
[JohnBel](http://johnbel.github.io/)
