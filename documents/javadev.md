# How to Development EAP for JAVA Developer
<img src="https://img.shields.io/badge/java-007396?style=for-the-badge&logo=java&logoColor=white">

### Make reference to ScomDriver1 Library  
Add libraries in project for further ScomDriver communication.  
Add ScomDriver1.0.jar and libraries from [Property] of project or [Configure Build Path] of Libraries Tab.  
![image](https://user-images.githubusercontent.com/102704655/161182295-6b6ed6a5-f384-4d2b-a6b1-f9cf25b61c4e.png)

##### ScomDriver need these libraries.  
(Libraries are located in RuntimeLib -> JavaLib folder of scom installation folder.)
* Scomdriver1.0.jar
* xutil4j-1.0.jar
* log4j-1.2.15.jar
* jdom-1.0.jar
* junit.jar
* dynamic-file-appender-1.0.0.jar
* commons-logging-1.0.4.jar

### Make SECS Instance
Create SECS instance to approach and control ScomDriver.  
Create SinglePlugIn object from kr.co.aim.Scomdriver.plugin.  
Class SinglePlugIn provides a method to complete communication by approaching ScomDriver.  
Create SinglePlugIn object by using Spring in Java.

``` java
  kr.co.aim.scomdriver.plugin.SinglePlugIn plugIn = new SinglePlugIn()
```
