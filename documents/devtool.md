#	ScomDevTool
###### Overview
* ScomDevTool defines SECS Messages, and it also generates message definitions. In this section, describes how to use ScomDevTool to define structure of messages and generate SMD information.
* ScomDevTool is a SECSEdi tor to edit a SECS messages.

###### ScomDevTool Window

![image](https://user-images.githubusercontent.com/102704655/161019497-8c997c7c-ecc2-41cb-96ed-b9e24c80ba61.png)


###### ScomDevTool Menu Bar
* The ScomDevTool menu bar provides the following menus.
* The Project menu provides you to manage project files. 
* The Edit menu provides you to edit SECS message structure items. For details, see ‘3.4.4.2. Editing SECS Message Definitions’ section.
* The View menu provides you to change the property of SECS Message Definition Pane and choose SECS Message Library. For details, see ‘3.3.3.Loading SECS Message Libraries’ section
* The Build menu provides you to generate SECS Message Definitions File (SMD).
* The Help menu provides the information of ScomDevTool.


###### ScomDevTool Toolbar
 ![image](https://user-images.githubusercontent.com/102704655/161019552-eb214193-ec2d-46f0-a2e1-b41f4f710d88.png)
* The ScomDevTool’s toolbar provides a row of icons for initiating common procedure, as follows:
 ![image](https://user-images.githubusercontent.com/102704655/161019582-34338197-92d6-45d5-8476-f956bdbed936.png)
 New Project - Creating a new project. For details, see ‘3.2.3.Craeting a New Project’ section.
 ![image](https://user-images.githubusercontent.com/102704655/161020071-36a17036-421a-402e-bbc7-4dac472eedcf.png)
* Open Project – Opening a project. For details, see ‘3.2.4.Opening a Project’ section.
  Save Project – Saving a project. For details, see ‘3.2.5.Saving a Project’ section.
  Cut – Cut message that is part of the selected SECS message
  Copy – Copy message that is part of the selected SECS message.
  Paste Next – Paste the copied message below the selected SECS message. 
  Find – Enter values to search for items
  Build SECS Message Definitions – Generating SECS Message Definitions file (SMD).

3.2.3.	Creating a New Project
3.2.3.1.	Choose Project ->New
If you have a project currently open, a following dialog asks if you want to save the current project.
 

	If you click ‘Yes’, ScomDevTool save the current project before creating a new project
	If you click ‘No’, ScomDevTool does not save the current project.
	If you click ‘Cancel’, ScomDevTool cancel the ‘New Project’ command and return to current project.

3.2.3.2.	Assign new Project Name
 

If a ‘New Project’ dialog opens, enter project name in the ‘Project Name’ textbox and select project type and project path.

3.2.3.3.	Create new Project Environment
If you click ‘OK,, ScomDevTool create a new project environment. (For details, see ‘3.3.6.Project Environment’ section.)

3.2.4.	Opening a Project 
3.2.4.1.	Choose Project ->Open
If you have a project currently open, a dialog asks if you want to save the current project. (For details, see ‘3.3.2.Creating New Project’ section.)

3.2.4.2.	Select Project
If you select a ScomDevTool’s project file from an ‘Open Project’ dialog, ScomDevTool reads an assigned project file and prepares an environment for a project.
 

3.2.5.	Saving a Project
3.2.5.1.	To save the current project under the same name: Choose Project ->Save
ScomDevTool saves the project under the current project name.

3.2.5.2.	To save the current project under a new name: Choose Project ->SaveAs
A ‘SaveAs Project’ dialog opens, type a new project name in the ‘Project Name’ box and choose OK button. 
ScomDevTool saves the project under a new name.
 

3.2.6.	Project Environment
You can store ScomDevTool project files in any directory. In each project directory, however, ScomDevTool creates the followings.

3.2.6.1.	Project Directory
ScomDevTool creates project directory with project name, and saves project file (‘ProjectName.sdt’) in current location.

3.2.6.2.	‘ScomInfo’ Directory
It contains SECS Message Definitions (‘ProjectName.smd’) file.

3.3.	ScomDevTool SECS Message Editor
3.3.1.	Overview
You use ScomDevTool’s SECSEditor to define the structure of SECS Messages used by the equipment you want to control.
In this section, describes how to use SECSEditor to define SECS Messages.

3.3.2.	SECSEditor Window
 

3.3.2.1.	SECS Message Editing Pane
 

The ‘SECS Message Editing Pane’ enables you to modify the header items of SECS message.
In the ‘Message Definition Editing Pane’, use the following controls to handle the header
Control	Description
Stream	Enter the SECS-II stream number.
Function	Enter the SECS-II function number.
Msg Name	Enter a name for the message definition. The length of message name can be up to 32 characters, and it must start with a letter of the alphabet, and cannot have any spaces. It becomes a SECS Message Class’s name.
Wait	Click this checkbox to turn on the Wait-Flag
AutoReply	Click this checkbox to turn on the AutoReply-Flag.
To Equip	Click this radio button to set the message direction to ‘H->E’.
To Host	Click this radio button to set the message direction to ‘H<-E’.
Both	Click this radio button to set the message direction to ‘H<->E’.
Description	Use the keyboard to alter the message definition description in the text field.
Add	Add defined Message.
Change	Update selected message with a new data.


3.3.2.2.	SECS DataItem Editing Pane
 
The ‘SECS DataItem Editing Pane’ enables you to edit individual items in the body of a SECS message. 
In the ‘SECS DataItem Editing Pane’, use the following controls to alter the item
Control	Description
Item Name	Enter the name of the item. The name must be unique to the message. It becomes SECS Message class’s member property.
Item Count	Enter the item count.
Fixed Count	Click this checkbox to toggle the fixed count setting for the item.
Initial Value	Enter an initial value for the item.
Types	Click the desired data type button.
	Item Type	Means
	List	list.
	Ascii	unit size is 1 byte.
	Binary	unit size is 1 byte.
	Boolean	0 or 1: unit size is 1 byte.
	I1	signed 1-byte integer.
	I2	signed 2-byte integer.
	I4	signed 4-byte integer.
	I8	signed 8-byte integer.
	U1	unsigned 1-byte integer.
	U2	unsigned 2-byte integer.
	U4	unsigned 4-byte integer.
	U8	unsigned 8-byte integer.
	F4	4-byte floating point number.
	F8	4-byte floating point number.
	JIS-8	JIS-8.
	Any	any item type.

3.3.2.3.	SECS Message Library Pane
 

The ‘SECS Message Library Pane’ displays the contents of message definitions of current selected library and provides several ways to choose and import individual message definitions into the current project.

3.3.2.4.	SECS Message Definition Pane
 

The ‘SECS Message Definition Pane’ displays the definition of every message imported into the current project.
To edit a message definition, you select the parts of the definition that you want to change in this pane, and edit it by using the ‘SECS Message Editing Pane’ and the ‘SECS DataItem Editing Pane’.
In this pane, you can cut, copy, and paste individual lines of message definitions or entire message definitions by using Edit Menu and Pop-Up menu.

3.3.3.	Loading SECS Message Libraries
SECSEditor loads the Standard SECS-II Library by default when it runs first. You can load other libraries, including ones that you have defined yourself, to use the ‘SECS Message Library’ command in the ‘View’ menu. You can switch to the SECS Standard library or import custom message definition files.
You can load one of the following message definition libraries into SECSEditor:
	AIM SEMI Standard Library, which contains the entire message currently defined in the SECS-II standard.
	AIM GEM Standard Library, which contains the SECS-II messages currently included in the GEM standard.
	AIM SECS Message Definition File, which contains messages defined using ScomDevTool’s SECSEditor (SMD)

3.3.4.	Editing SECS Message Definitions
3.3.4.1.	Defined SECS Message Format
 

	Message Header
The message header consists of a description of the message’s name and function, followed by a single line providing information in the following format:
MessageName: Sn Fm Wait-Flag AutoReply-Flag Direction
MessageName: Message name. (ASCII format)
Sn Fm: Stream and Function numbers of the message.
Wait-Flag: The letter ‘W’ indicates that the message interpreter must wait for a secondary message after sending this primary message.
AutoReply-Flag: If SECS message includes the string ‘<R>’, ScomDriver replies the secondary message automatically when the primary message is received. 
Direction: Message transmission direction. This field can have three types.
‘H  E’	Host to equipment
‘H  E’	Equipment to host
‘H E’	Both direction

	Message Body
SECSEditor displays the body of message definition using the SECS-II tree structure format used in the Book of SEMI Standard 1996, Equipment Software, Volumn1.

3.3.4.2.	Editing SECS Message Definitions
1)	Importing SECS Messages
You can import message definitions into your current project by selecting what you want from the currently loaded message definitions library and add them to the list displayed in the SECS Message Definition Pane. Also you can define your own messages and import them using the SECS Message Editing Pane.

③	To import definitions using the SECS Message Library Pane
Click the desired definition in the SECS Message Library pane, drag the selected definition over to the SECS Message Definition pane, and drop them there.

④	To add definitions using the SECS Message Editing pane
Enter the desired definition in the SECS Message Editing pane, and click ‘Add’ button. SECSEditor add the message definition to the end of displayed definitions list in the SECS Message Definitions Pane. (For details, see ‘3.3.2.1.SECS Message Editing pane’ section.)

2)	Editing Message Header
⑤	Select the desired definition in SECS Message Definition pane, and click on the definition’s header.
⑥	In the SECS Message Editing Pane, edit properties of definition. (For details, see ‘3.4.1.3.SECS Message Editing pane’ section)
⑦	Click ‘Change’ button. SECSEditor updates the message definition in the SECS Message Definition pane.

3)	Editing Message Body
	To add a new message body.
①	If you want to add the new item definition to the end of defined items in the message body, click the right button on the header of the desired message definition in the SECS Message Definition pane, then select ‘Insert Item’ or ‘Add Child Item’ menu on the popup. (If you select a not-list typed item, SECSEditor disables ‘Add Child Item’ menu)
②	If you want to insert the new item definition in the list of defined items in the message body, click the right button on a specified item of the desired message definition in the SECS Message Definition pane, then select ‘Insert Item’ or ‘Add Child Item’ menu on the popup.
③	If you select ‘Insert Item’ menu, a new SECS DataItem will be added as sibling. If you select ‘Add Child Item’ menu, a new SECS DataItem will be added as a child.
④	After adding a new SECS DataItem, you should edit it in the SECS DataItem Editing Pane.

	To edit a message body.
①	Select the desired definition in SECS Message Definition pane, and click the desired item in the message definition body.
②	SECSEditor displays the current settings for the item in the SECS DataItem Editing Pane.
③	Edit properties of item in the SECS DataItem Editing pane and SECSEditor updates the message definition in the SECS Message Definition pane directly.

3.4.	Building Definitions
3.4.1.	Overview
This section describes how to build definitions on the basis of the SECS.
You use these outputs (SMD) to implement Equipment Interface Program.

3.4.2.	SECS Message Definitions
ScomDriver uses a file called SMD (SECS Message Definitions) to check the validity of SECS Messages exchanged with the equipment.

To generate this SMD File, choose ‘Build->SECS Message Definition’ menu.
Then ScomDevTool will generate the XML formatted SECS Message Definitions file and store it in the current project directory.
