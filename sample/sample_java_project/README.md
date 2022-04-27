# How to use This Project?

#### environment
* Oracle JDK: 1.6.0_45 ~ 1.8.0_231
* OpenJDK : 11.0.11 ~ 

#### dependency
* commons-logging-1.0.4
* dynamic-file-appender-1.0.0.jar
* jdom: 1.0
* junit: 1.0
* log4j: 1.2.15
* xutil4j: 1.0

### 1. download this project
![image](https://user-images.githubusercontent.com/78777059/165448663-b80956f8-7326-43dc-8894-97df4b0bd5e7.png)

### 2. Make a workspace and import this project.
![image](https://user-images.githubusercontent.com/78777059/165443999-6e3e9854-9aec-4060-9d2b-aa94e74f50ad.png)

![image](https://user-images.githubusercontent.com/78777059/165444080-cb9afe62-850f-47a3-a84d-b9fa1bf69f1b.png)

### 3. add lib's in build path (lib files are in the scomdriver installation path..)
![image](https://user-images.githubusercontent.com/78777059/165444319-35c5c2f9-6d90-4106-8bc0-91813ac07bdf.png)

![image](https://user-images.githubusercontent.com/78777059/165444590-cd865eea-038d-4198-ab6d-3cae6e5e1c5f.png)

### 4. add run configurations and argument
![image](https://user-images.githubusercontent.com/78777059/165444736-e093e755-9c34-46dd-a6ae-793631f6dae7.png)

![image](https://user-images.githubusercontent.com/78777059/165444799-167eb5bf-9909-4236-baca-6a8e6411a484.png)

### 5. modify ScomINI.xml
set to suit your environment  
##### SMDPATH, IP, PORT, ROOTDIR
 that must be changed  
``` xml
<SMDPATH>C:\Program Files (x86)\AIM Systems, Inc\SEComEnabler 2.1\SEComSimulator\DEFAULT.SMD</SMDPATH>
<IP>127.0.0.1</IP>
<PORT>9000</PORT>
<ROOTDIR>E:\log</ROOTDIR>
```

### 6. run project.
##### HOST
![image](https://user-images.githubusercontent.com/78777059/165447227-b7c46128-1a76-480b-ad83-8261d42f0428.png)
##### EQP
![image](https://user-images.githubusercontent.com/78777059/165447273-d5d9380d-1b05-4bcf-ba3f-5265a91d20db.png)

# if you use rockey (USB Protect Program) ?
### add jRockey4ND.dll file
![image](https://user-images.githubusercontent.com/78777059/165449801-a6d35fff-2c4a-4094-9476-eae6f88eb823.png)


##### what is rockey??  
scomdriver use rockey4ND.
[ROCKEY4ND GoldenSecurity](http://rockey.co.kr/pages/page_62.php)
