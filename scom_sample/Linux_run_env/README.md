# 💻 Scom Sample on linux server

### Environment
* ubuntu 20.04
* Java(TM) SE Runtime Environment (build 1.6.0_45-b06)

### Structure
* Linux_run_env/
  * lib/
    * commons-logging-1.0.4.jar
    * dynamic-file-appender-1.0.0.jar
    * jdom-1.0.jar
    * junit.jar
    * log4j-1.2.15.jar
    * Scomdriver1.0.jar
    * xutil4j-1.0.jar
  * log/
    * logs..
  * log4j.properties
  * ScomINI.xml
  * SECSWrapper.class
  * smd/
    * DEFAULT.SMD
  * startup.sh
  
#### startup.sh
```sh
#!/bin/bash

if [ -z $1 ]
then
	echo "No parameter Inputed"
else
	java -cp ./:./lib/Scomdriver1.0.jar:./lib/xutil4j-1.0.jar:./lib/jdom-1.0.jar:./lib/log4j-1.2.15.jar SECSWrapper $1
fi

```
