# How to Development EAP for .NET Developer

### [Example – C# Code](./sample.md)

### Start to Develop EAP  
Explain both cases of .NET project and Java project. For the following explanation of development of each project, .Net project is based on Microsoft Visual Studio and java project is based on Eclipse SDK.

### Make reference to ScomDriver1 Library  
###### Add ScomDriver1 library in project for further ScomDriver communication. 
Add ScomDriver 1.0.dll by selecting [Add Reference…] in Solution Explorer.
 ![image](https://user-images.githubusercontent.com/102704655/161193014-ab9dd331-bca4-4f45-99fd-9875cebcfb64.png)

### Make SECS Instance  
###### Create SECS instance to approach and control ScomDriver.
Create SinglePlugIn object from kr.co.aim.Scomdriver.plugin. Class SinglePlugIn provides a method to complete communication by approaching ScomDriver.
```c#
  kr.co.aim.scomdriver.plugin.SinglePlugIn plugIn = new SinglePlugIn()
```
