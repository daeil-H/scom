# ScomEmulator 4.0
### Role
* ‘Virtual Equipment or Host’
* Edit and Save Message.
* Communication Test.
* Message Send and Scenario Simulation Test.
* Switch log message.
 
### UI Description
 
 ![image](https://user-images.githubusercontent.com/102704655/161176395-c59b106b-4652-43cf-ae35-778e53296129.png)

 
* Menu  
Where list main function of ScomEmulator program. Press buttons to use specific functions.  
* Message Explorer  
Show message by opening Message File and control it.  
* Scenario Simulation  
Register and control test message and send in an order of message listed.  
* SECS1 Log  
Where output SECS1 invoked log while communicating.  
* SECS2 Log  
Where output SECS2 invoked log while communicating.  
* Simulation Log  
Where output Simulation invoked log while communicating.

#### Message Management
###### Message File and Message are used while communicating with Driver in ScomEmulator. Users can edit, save and test message.

#### Message File
###### Used in Driver of ScomEmulator.
 

##### 1. Open
###### Load opening Message (SMD, TSM) file in Message Explorer. If same name of Scenario file is existing, select whether to open with it.
* Select [Menu] – [Home] – [Message File] – [Open].
* Select message file – press [Open].
* If Scenario file exists, select whether to open Scenario file.
* Load and output Message File and Scenario File.
        
![image](https://user-images.githubusercontent.com/102704655/161176536-927254e7-2cb9-44f0-ab41-272b1124b4cf.png)

##### 2. Save
###### Save Message File which is edit from Simulator as TSM file.
* Select [Menu] – [Home] – [Message File] – [Save].
* Save

##### 3. Save As
###### Save Message File edit from Simulator as with different name.
* Select [Menu] – [Home] – [Message File] – [Save As].
* Save as.

#### Edit Message
###### Edit Message File (SMD, TSM) in ScomEmulator.

##### 1. SetMessage Info
###### Edit Message Information. Apply updated message information while Driver communication.
* Select message in [Message Explorer] and edit Message information in [Menu] – [Edit] – [Message Information].
 
 ![image](https://user-images.githubusercontent.com/102704655/161176687-532d9be6-1581-405d-8d02-6776d0efc347.png)


* Select Message in [Message Explorer] and click menu tool button in [Message Information] – [Message Editor] Dialog is opened and then edit Message information.  Apply Message information without any confirmation. If necessary, with Dialog opened, select Message or Item information in [Message Explorer] for edit.
 
 ![image](https://user-images.githubusercontent.com/102704655/161176703-de2def11-b36d-45f5-8968-1d6c099bc2b5.png)


##### 2. Set Item Info
###### Set Item Information. Apply updated message information while Driver communication.
* Select Item in [Message Explorer] and modify Item information in [Menu] – [Edit] – [Item Information].
 
 ![image](https://user-images.githubusercontent.com/102704655/161176725-d8ca67de-8114-4b67-b675-ad86a3d709ac.png)


* Select Item in [Message Explorer] and select menu tool button of [Item Information] – Open [Item Editor] to edit Item Information. Apply Item information with any confirmation. If necessary, with Dialog opened, select Message or Item information in [Message Explorer] for edit.
 

##### 3. New Message
###### Create new Message.
* Select [Menu] – [Edit] – [Transaction] – [New Message].
* Or right mouse click at [Message Explorer] – Select [New Message].
* Fill in message information and press OK.
* Add message.


##### 4. New Item
###### Create new Item.
* Select [Menu] – [Edit] – [Transaction] – [New Item].
* Or select message to add on item at [Message Explorer] – right mouse click – Select [New Item].
* Fill in Item information and press OK.
* Item is added..

### Scenario
To make it easier to test message transaction, register message and support scenario function which makes it possible to send message in defined order.

#### Scenario File

 ![image](https://user-images.githubusercontent.com/102704655/161176857-aab395b8-e787-44d5-a095-669479bf5222.png)

##### 1. New
###### Open new Scenario page to create as a Scenario File. Until to save, scenario file does not exist yet.
* Select [Menu] – [Home] – [Scenario File] – [New].
* New scenario opened.

##### 2. Open
###### Open predefined Scenario File (.TSS).
* Select [Menu] – [Home] – [Scenario File] – [Open].
* Select Tss file.
* Open scenario selected from Scenario Simulation.

##### 3. Save
###### Save currently selected scenario as Scenario File (. TSS).
* Select [Menu] – [Home] – [Scenario File] – [Save].
* Save Scenario File as in directed path.

##### 4. Save As
###### Save currently selected scenario as with different name.
* Select [Menu] – [Home] – [Scenario File] – [Save As].
* Select path to save files and save scenario file as selected file name.

##### Edit Scenario
###### Register loaded message at Message Explorer to scenario and edit the scenario.

##### 1. Add Message
###### Add message to Send / Receive on scenario.
* Select message to be added on scenario at [Message Explorer].
* Drag this message onto [Scenario Simulation]. (Drag-Drop method)
 
 ![image](https://user-images.githubusercontent.com/102704655/161177042-171f8d8e-5b79-465c-9075-840fe12a35ce.png)


##### 2. Change Message Mode
###### Only case for Send Message. Switch to Send Message mode.
* Change message mode by double-clicking Send message registered at [Scenario Simulation].

![image](https://user-images.githubusercontent.com/102704655/161177133-b8f0b9c2-2278-4f3a-9cc0-519e5ba6b1be.png)  
- Auto: Send message automatically. Use as Default.  
- Manual: Stop when follows on proper order. Send message directly by pressing [Send].  

##### 3. New Optional
###### Several messages are registered waiting for their order. Send those of selected message from message box.
* [Menu from Scenario Simulation] – Click [New Optional] and then Dialog pops up. From left control to right control, register ###### message. After (Add or double-click) and press OK. Register one Optional message in Scenario.

![image](https://user-images.githubusercontent.com/102704655/161177185-3aaa583b-f18e-47a7-a6ab-8fee39dbdcdd.png)


* While Simulation, message selection box pops up when Optional message fits in the proper order defined to send. Click message to send.
 
 ![image](https://user-images.githubusercontent.com/102704655/161177194-d2b54bd9-784b-42ab-9323-8b245fe15532.png)


##### 4. Modify Optional Transaction
###### Modify message registered in Optional message.
* Select Optional message node – right mouse click – Select [Modify Optional Transaction] and modify message registration of Option message at Dialog. Press [OK] to complete.
 
 ![image](https://user-images.githubusercontent.com/102704655/161177264-dce8be68-3aa6-4a1f-afdf-a9cd0a79c206.png)


##### 5. Delete Message
###### Delete Message registered at scenario.
* Select Optional message node and right mouse click – Select [Delete].  
 ![image](https://user-images.githubusercontent.com/102704655/161177271-8b49a240-5382-4925-9b61-386aaadd37ac.png)
 
* Selected message is deleted.

##### 6. Change Scenario Mode
###### Change Message mode. While real communication, run simulation with configured mode of Simulator.
* Select Host / Equipment Radio button and then scenario is changed to that mode.  
![image](https://user-images.githubusercontent.com/102704655/161177298-a20c48a4-0417-41bf-81a1-0e026071db7f.png)

- Host: Mode when Simulator is Host.  
- Equipment: Mode when Simulator is Equipment.  

#### Scenario Simulation Test
###### Start to Test after message file is completed.

#### Connection
###### Communicate with opponent’s Driver.  
![image](https://user-images.githubusercontent.com/102704655/161177361-ffb9f1aa-c6ee-4da6-88e9-0c2d529bf5e7.png)


##### 1. Configure
###### Configure ScomDriver information at ScomEmulator.
* Select [Menu] – [Home] – [Connection] – [Configure].
* Configure default Driver information for communicating at ScomEmulator in ScomDriver Tab.  
- **Driver Name**: Insert ScomDriver name for Simulator.  
- **Device ID**: As a specific Equipment number, able to communicate if Device ID is same as opponent’s.  
- **Identity**: Select whether ScomDriver to be registered is Equipment or Host.  
- **SECS Mode**: Select whether communication mode is HSMS or SECS1.  
- **HSMS Mode**:  Configure when SECS mode is HSMS.  
HSMS Mode: Select HSMS Mode. Select between Active or Passive mode.  
Remote IP: HSMS If Mode is Active, fill in opponent’s IP Address. Format is [0~255].[0~255].[0~255].[0~255].  
Local IP: While Test, check when using Local IP(127.0.0.1).  
Remote Port: HSMS Mode is Active, insert opponent’s Port number.  
Local Port: HSMS Mode is Passive, configure own Port number.  
-	SECS1 Mode: Configure when SECS mode is SECS1.  
**SECS1 Mode**: Select SECS1 mode. Select Slave and Master.  
Interleave: 
Com Port: Select Com Port for communication.  
Retry Count: If not to receive ‘EOT’ or receive ‘NAK’, choose retry count.  
Baud Rate: Choose Baud rate  
- **Log Directory**: ScomDriver leaves log while communicating. Select log directory path to store log  
- **Log Mode**: Configure information when SECS mode is SECS1.  
No Logging: Neither of SECS1 or SECS2 log output.  
Full SECS: Driver, SECS1, SECS2 log output.  
SECS1 Only: SECS1 log output only.  
SECS2 Only: SECS2 log output only.  
- **Log Level**: Choose log level which output from Driver.  
More than Debug level: Debug log or higher.  
More than Info level: Debug, Info log or higher.  
More than Warn level: Debug, Info, Warn log or higher.  
- **Backup Duration**: Choose backup log duration  
Daily: Daily log unit.  
Hourly: Hourly log unit.  

* Configure Driver Option information for communication with ScomEmulator on Option Tab.
- **Row Binary**:  
Use Raw Binary: Whether to use Raw Binary Length.  
Raw Binary Length: Whether to use Raw Binary Length.  
- **Socket Max Length**: Configure max length of socket data.  
- **Report Log**:   
Transaction: Check whether to leave Report Log related to Transaction.  
Connection: Check whether to leave Report Log related to Connection.  
Timeout: Check whetehr to leave Report Log related to Timeout.  
- **Dispatch**: Choose to use Dispatch functions which check whether incoming message is same as defined message by Driver. 
- **Timeout**: Configure Timeout.  
HSMS Timeout : T3, T5, T6, T7, T8  
SECS1 Timeout : T1, T2, T3, T4  
- **LinkTest Duration**: configure LinkTest Duration.


##### 2. Connect
###### Request Connection or get ready for communicating with the status for Listening.
* Select [Menu] – [Home] – [Connection] – [Connect].
* Show connection state at StatusBar.
 ![image](https://user-images.githubusercontent.com/102704655/161178173-8c05d031-9be0-450c-8318-094ff7ac587e.png)


- Connecting: Request to connect.  
![image](https://user-images.githubusercontent.com/102704655/161178189-22400abc-3459-4058-b67a-a8e43ce32965.png)

- Listening: Wait in for connection.  
 ![image](https://user-images.githubusercontent.com/102704655/161178221-c5c2a4f6-ee90-435c-b00d-0a7c87db4f6d.png)

- Connected: Connected successfully.  
 ![image](https://user-images.githubusercontent.com/102704655/161178234-91d20c67-1e6e-48a3-8281-d050e241585c.png)

- Disconnected: Disconnected from opponent.  

##### 3. Disconnect
###### Disconnect communication and close socket. Connection ended.
* Select [Menu] – [Home] – [Connection] – [Disconnect].
* Show connection state at StatusBar.	
![image](https://user-images.githubusercontent.com/102704655/161178259-f42b5ce9-40ba-4752-b3a9-b194ea09601e.png)

- Closed: Connection ended and socket close.

### Send Message
###### Send Message which registered at Message Explorer. Depending on direction of defined message and Function, Send/Receive, Request/Reply is applied differently.
 
##### 1. Send Request Message
##### Send Request (Primary) Message to opponent. If Function number is odd and direction is opposite with Simulator’s, send Message.
* Select Primary Message Node and Select [Menu] – [Home] – [Send Message] – [Request].
* Or selecting Primary Message, right mouse click – Select [Send Request Message].  
![image](https://user-images.githubusercontent.com/102704655/161178334-4dd3617f-a142-444a-a187-5d4e41398a32.png)
 
* Send message. Look up for history Log.

##### 2. Send Reply Message
###### Send Reply(Secondary) Message to opponent. If Function is even and direction is opposite with Simulator’s, send message.
* Select Secondary Message Node and select [Menu] – [Home] – [Send Message] – [Reply].
* Or selecting Secondary Message, right mouse click – Select [Send Reply Message].  
 ![image](https://user-images.githubusercontent.com/102704655/161178386-0050580e-45bd-4a1d-8ef3-6403b2020d1f.png)
 
* Send message. Look up for history Log.

##### 3. Send Control Message
###### Send Control Message.
* Select [Menu] – [Home] – [Send Message] – [Control].
* Configure Control message information.
* Send Control message.

##### 4. Stress Test
###### Selecting message send interval, continuously send message.
* [Menu] – [Home] – [Stress Test] – Choose Interval value and [Menu] – [Home] – [Stress Test] – press [Start].
![image](https://user-images.githubusercontent.com/102704655/161178528-c95c7a63-21c8-4e95-ace6-65ab29962b86.png)

* Selecting message of [Message Explorer], Run (a)Send Request or (b)Send Reply, and then send message following configured interval.
 ![image](https://user-images.githubusercontent.com/102704655/161178531-9d98cec9-6485-4cc6-b215-1c55fdc08401.png)
 
* [Menu] – [Home] – [Stress Test] – [Stop], stop Stress Test. 


### Scenario Simulation
###### If connected, currently selected Scenario tests for Simulation.
 ![image](https://user-images.githubusercontent.com/102704655/161178590-0545a7a7-c9ea-46d9-b576-33ad304c51ec.png)

##### 1. Simulation On
###### Start Testing by currently selected Scenario. After done for testing, it turns into Simulation Off. 
* Turns Simulator as Connected.
* Select [Menu] – [Home] – [Simulation] – [On].
* Ask for using current Scenario at message view. By clicking OK, Simulation starts.
 ![image](https://user-images.githubusercontent.com/102704655/161178608-0bb4c6c3-773e-41b2-8050-3bbc61e92c2a.png)  
* After Scenario Simulation, turn it into OFF.

##### 2. Simulation Off
###### Stop current Simulating.
* Select [Menu] – [Home] – [Simulation] – [Off].

##### 3. Send Scenario Message
###### If Send Message Mode is Manual, send proper message in order by clicking Send button during Simulation.
* If Message Mode is Manual and stops, send message by pressing [Send].  
![image](https://user-images.githubusercontent.com/102704655/161178694-750a4ac6-cd8a-4192-8182-8c95704cbb93.png)


## Other Fuction
### View Panels
###### Open panel view.
 ![image](https://user-images.githubusercontent.com/102704655/161178754-096cb32d-588f-412c-a14d-ea51f392ec76.png)

 
* Scenario Simulation  
Output Scenario Simulation Panel.
* SECS1 Log  
Output SECS1 Log Panel.  
(That show SECS1 log, while Driver communication of Simulator)
* SECS2 Log  
Output SECS2 Log Panel.  
(That show SECS2 log, while Driver communication of Simulator.)
* Simulation Log  
Output Simulation Log Panel.  
(That show Simulation log, while Driver communication of Simulator.)
* Clear  
Clear current SECS1 / SECS2 / Simulation Log output.

### Convert Log
###### Convert Log with different versions. Comfortable for reuse.
 ![image](https://user-images.githubusercontent.com/102704655/161178854-81855068-77dd-43f1-8cd1-1f04dedb4be7.png)

* Select [Menu] – [Home] – [Log] – [Convert].
* Configure information and convert log.  
![image](https://user-images.githubusercontent.com/102704655/161178893-ccbd764a-06fe-49ae-9829-2f044b1f9e7f.png)

* Select Option for converting log at Select Conversion Option.  
- Scom Log Type: Select whether converting log is SECS1 log or SECS2.
* Select [Open Log File] and then select log file to be converted. Output log at text box of [Log File].
* Select [Convert] and then output at V1.0 Message as SECS2 log type by converting log.
* Select [Save As] and then confirm save with indicating saving path and file name.
* Select [Save And Open] and then
* Select [Append] and then

### Clip Board
###### You can Copy,Paste, Duplicate, Delete.
* Select [Menu] – [Edit] – [Clip Board] – [Function] .
* When You select the Component, right mouse click – Select [Function]. 

### Skin
###### You can select the skin color.
* Select [Menu] – [View] – [skin] – [Color] .
