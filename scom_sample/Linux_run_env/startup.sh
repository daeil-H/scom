#!/bin/bash

if [ -z $1 ]
then
	echo "No parameter Inputed"
else
	java -cp ./:./lib/Scomdriver1.0.jar:./lib/xutil4j-1.0.jar:./lib/jdom-1.0.jar:./lib/log4j-1.2.15.jar SECSWrapper $1
fi
